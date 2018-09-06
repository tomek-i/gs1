namespace TI.GS1.Parser.AI
{

    public sealed class GS1EANContent : GS1BarcodeItem
    {
        public GS1EANContent()
        {
            Id = "02";
            Description = "Global Trade Item Number (GTIN/EAN) of contained trade items";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 14;
            Fnc1 = false;
        }
    }

}