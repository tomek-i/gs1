namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class SerialNumberOfAIntegratedModule : GS1BarcodeItem
    {

        public SerialNumberOfAIntegratedModule()
        {
            Id = "250";
            Description = "SerialNumberOfAIntegratedModule";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 30;
            Fnc1 = true;
        }
       
    }
}