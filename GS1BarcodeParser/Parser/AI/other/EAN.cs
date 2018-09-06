namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1EAN : GS1BarcodeItem
    {
        public GS1EAN()
        {
            Id = "01";
            Description = "Global Trade Item Number (GTIN/EAN)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 14;
            Fnc1 = false;
        }
       
    }
}