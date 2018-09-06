using System.Collections.Generic;
using System.Linq;
using System.Text;
using TI.GS1.API;
using TI.GS1.Parser;

namespace TI.GS1
{
    // ReSharper disable once InconsistentNaming
    public sealed class GS1Barcode : IGS1Barcode
    {

        public string Barcode { get; internal set; }
        public string BarcodeReadable { get
            {
                StringBuilder sb = new StringBuilder();
                foreach (var segment in Segments)
                {
                    sb.Append($"{segment} ");
                }
                return sb.ToString().TrimEnd();
            } }
        public IList<IGS1Item> Segments { get; private set; }

        public IGS1BarcodeParser BarcodeParser { get; private set; }

        public GS1Barcode(string barcode, IGS1BarcodeParser parser)
        {
            Barcode = barcode;
            ReparseSegments(parser);

        }
        public GS1Barcode(string barcode):
            this(barcode, new GS1BarcodeParser())
        {
            
            

        }

        internal void Add(IGS1Item segment)
        {
            Segments.Add(segment);
        }

        //facade
        public bool Contains(string applicationIdentifier)
        {
            return Segments.SingleOrDefault(x => x.Id == applicationIdentifier) != null;
        }
        public bool Contains(IGS1Item item)
        {
            return Contains(item.Id);
        }

        public T GetSegment<T>() where T : IGS1Item
        {
            return Segments.OfType<T>().Select(item => item).SingleOrDefault();
        }
        
        public T GetSegment<T>(string applicationIdentifier) where T : IGS1Item
        {
            return  (T)GetSegment(applicationIdentifier);
        }

        public IGS1Item GetSegment(string applicationIdentifier)
        {
           return Segments.Select(item => item).SingleOrDefault(x => x.Id == applicationIdentifier);
        }

        public void ReparseSegments()
        {
            Segments = null;
            Segments = BarcodeParser.Parse(Barcode);
        }

        public void ReparseSegments(IGS1BarcodeParser parser)
        {
            BarcodeParser = parser;
            ReparseSegments();
        }
    }
}