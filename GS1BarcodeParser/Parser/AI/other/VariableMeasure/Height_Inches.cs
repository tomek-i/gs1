namespace TI.GS1.Parser.AI.other.VariableMeasure
{
    public sealed class GS1HeightInches : GS1BarcodeItem
    {

        public GS1HeightInches()
        {
            Id = "327d";
            Description = "Depth, thickness, height or third dimension, inches (variable measure trade item)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;

        }

    }
}