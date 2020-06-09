using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TI.GS1.API;

namespace TI.GS1.Parser
{
    // ReSharper disable once InconsistentNaming
    public sealed class GS1BarcodeParser : IGS1BarcodeParser
    {

        internal readonly SortedDictionary<string, IGS1Item> ApplicationItemDictionary;// = new SortedDictionary<string, GS1BarcodeItem>();

        private readonly int _minLengthOfAi;// = 1;
        private readonly int _maxLengthOfAi;// = 4;

        public bool HasCheckSum { get; set; } = true;

        public char GroupSeparator { get; set; } = (char)29;

        public string Ean128StartCode { get; set; } = "]C1";

        private IList<IGS1Item> FindDerivedTypes(Assembly assembly, Type baseType)
        {

            List<IGS1Item> availableBarcodeItems =
                assembly.GetTypes()
                    .Where(t => t != baseType && baseType.IsAssignableFrom(t))
                    .Select(CreateMaterialInstace)
                    .ToList();


            return availableBarcodeItems;
        }
        private IGS1Item CreateMaterialInstace(Type type)
        {
            return Activator.CreateInstance(type) as IGS1Item;
        }

        public GS1BarcodeParser()
        {
            ApplicationItemDictionary = new SortedDictionary<string, IGS1Item>();

            IList<IGS1Item> availableBarcodeItems = FindDerivedTypes(Assembly.GetAssembly(GetType()), typeof(GS1BarcodeItem));
            foreach (IGS1Item gs1Item in availableBarcodeItems)
            {
                GS1BarcodeItem item = (GS1BarcodeItem)gs1Item;
                ApplicationItemDictionary.Add(item.Id, item);
            }


            _minLengthOfAi = ApplicationItemDictionary.Values.Min(x => x.Id.Length);
            _maxLengthOfAi = ApplicationItemDictionary.Values.Min(x => x.Id.Length);

        }

        public IList<IGS1Item> Parse(string data, bool throwException = false)
        {
            // cut off the EAN128 start code 
            if (data.StartsWith(Ean128StartCode))
            {
                data = data.Substring(Ean128StartCode.Length);
            }
            // cut off the check sum
            if (HasCheckSum)
            {
                data = data.Substring(0, data.Length - 2);
            }

            IList<IGS1Item> gs1List = new List<IGS1Item>();

            int index = 0;
            // walkk through the EAN128 code
            while (index < data.Length)
            {
                // try to get the AI at the current position
                GS1BarcodeItem ai = GetAi(data, ref index);
                if (ai == null)
                {
                    if (throwException)
                    {
                        throw new InvalidOperationException("AI not found");
                    }

                    return gs1List;
                }
                // get the data to the current AI
                string code = GetCode(data, ai, ref index);
                ai.Value = code;
                gs1List.Add(ai);
                //result[ai] = code;
            }

            return gs1List;
        }

        /// <summary>
        /// Try to get the AI at the current position
        /// </summary>
        /// <param name="data">The row data from the scanner</param>
        /// <param name="index">The refrence of the current position</param>
        /// <param name="usePlaceHolder">Sets if the last character of the AI should replaced with a placehoder ("d")</param>
        /// <returns>The current AI or null if no match was found</returns>
        private GS1BarcodeItem GetAi(string data, ref int index, bool usePlaceHolder = false)
        {
            if (data.Length < _minLengthOfAi)
            {
                return null;
            }

            IGS1Item result = null;

            // Step through the different lenghts of the AIs
            for (int i = _minLengthOfAi; i <= _maxLengthOfAi; i++)
            {
                // get the AI sub string
                string ai;
                try
                {
                    ai = data.Substring(index, i);
                }
                catch (Exception ex)
                {
                    var appException = new ApplicationException("AI substring failed, see inner exception", ex);
                    appException.Data.Add("data", data);
                    appException.Data.Add("index", index);
                    appException.Data.Add("i", i);

                    throw appException;
                }


                if (usePlaceHolder)
                {
                    try
                    {
                        ai = ai.Remove(ai.Length - 1) + "d";
                    }
                    catch (ArgumentOutOfRangeException argException)
                    {
                        //NOTE: if it fails maybe ignore and break out of the for loop since this GS1.AI doesn't exist?

                        throw new ArgumentOutOfRangeException($"AI Remove threw an exception with placeholder: {ai}{Environment.NewLine}Data: {data}", argException);
                    }

                }


                if (ApplicationItemDictionary.TryGetValue(ai, out result))
                {
                    index += i;
                    return (GS1BarcodeItem)result;
                }
                // if no AI found, try it with the next length
            }
            // if no AI found here, than try it with placeholders. Assumed that is the first sep where usePlaceHolder is false
            if (!usePlaceHolder)
            {
                result = GetAi(data, ref index, true);
            }
            return (GS1BarcodeItem)result;
        }

        /// <summary>
        /// Get the current code to the AI
        /// </summary>
        /// <param name="barcodeString">The row data from the scanner</param>
        /// <param name="ai">The current AI</param>
        /// <param name="index">The refrence of the current position</param>
        /// <returns>the data to the current AI</returns>
        private string GetCode(string barcodeString, GS1BarcodeItem ai, ref int index)
        {
            // get the max lenght to read.
            int lenghtToRead = Math.Min(ai.LengthOfData, barcodeString.Length - index);

            string data;
            try
            {
                // get the data of the current AI
                data = barcodeString.Substring(index, lenghtToRead);
            }
            catch (Exception ex)
            {
                var appException = new ApplicationException("Data for AI substring failed, see inner exception", ex);
                appException.Data.Add("barcodeString", barcodeString);
                appException.Data.Add("index", index);
                appException.Data.Add("lenghtToRead", lenghtToRead);

                throw appException;
            }



            // check if the AI support a group seperator
            if (ai.Fnc1)
            {
                // try to find the index of the group seperator
                int indexOfGroupTermination = data.IndexOf(GroupSeparator);
                if (indexOfGroupTermination >= 0)
                {
                    lenghtToRead = indexOfGroupTermination + 1;
                }

                try
                {
                    // get the data of the current AI till the gorup seperator
                    data = barcodeString.Substring(index, lenghtToRead);
                }
                catch (Exception ex)
                {
                    var appException = new ApplicationException("Data for AI substring failed, see inner exception", ex);
                    appException.Data.Add("barcodeString", barcodeString);
                    appException.Data.Add("index", index);
                    appException.Data.Add("lenghtToRead", lenghtToRead);

                    throw appException;
                }

                if (data.Contains(GroupSeparator.ToString()))
                {
                    data = data.Remove(data.IndexOf(GroupSeparator), 1);
                }
            }

            // Shift the index to the next
            index += lenghtToRead;
            return data;
        }
    }
}