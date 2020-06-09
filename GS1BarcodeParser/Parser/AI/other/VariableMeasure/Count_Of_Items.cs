namespace TI.GS1.Parser.AI.other.VariableMeasure
{
    public sealed class GS1CountOfItems : GS1BarcodeItem
    {
        public GS1CountOfItems()
        {
            Id = "30";
            Description = "Count of Items (variable measure trade item)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 8;
            Fnc1 = true;
        }

    }
}