namespace TI.GS1.Parser.AI
{
    public sealed class GS1SSCC : GS1BarcodeItem
    {
        public GS1SSCC()
        {
            Id = "00";
            Description = "Serial Shipping Container Code (SSCC)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 18;
            Fnc1 = false;
        }
    }

}