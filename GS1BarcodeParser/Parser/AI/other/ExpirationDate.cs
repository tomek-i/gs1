namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1ExpirationDate : GS1BarcodeItem
    {
        public GS1ExpirationDate()
        {
            Id = "17";
            Description = "Expiration date (YYMMDD)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}