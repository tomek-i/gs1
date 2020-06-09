namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class HIBCCNumber : GS1BarcodeItem
    {
        public HIBCCNumber()
        {
            Id = "22";
            Description = "HIBCCNumber";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 29;
            Fnc1 = false;
        }

    }
}