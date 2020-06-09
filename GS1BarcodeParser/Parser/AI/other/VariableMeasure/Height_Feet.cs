namespace TI.GS1.Parser.AI.other.VariableMeasure
{
    public sealed class GS1HeightFeet : GS1BarcodeItem
    {
        public GS1HeightFeet()
        {
            Id = "328d";
            Description = "Depth, thickness, height or third dimension, feet (variable measure trade item)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}