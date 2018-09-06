namespace TI.GS1.Parser.AI
{

    public sealed class GS1CountOfTradeItems : GS1BarcodeItem
    {
        public GS1CountOfTradeItems()
        {
            Id = "37";
            Description = "Count of trade items";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 8;
            Fnc1 = true;
        }
    }
   
}