namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class GS1SerialNumber : GS1BarcodeItem
    {
        public GS1SerialNumber()
        {
            Id = "21";
            Description = "SerialNumber";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 20;
            Fnc1 = true;
        }

    }
}