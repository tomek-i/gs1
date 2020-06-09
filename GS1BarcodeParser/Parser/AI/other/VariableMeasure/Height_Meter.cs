namespace TI.GS1.Parser.AI.other.VariableMeasure
{
    public sealed class GS1HeightMeter : GS1BarcodeItem
    {
        public GS1HeightMeter()
        {
            Id = "313d";
            Description = "Depth, thickness, height or third dimension, meter (variable measure trade item)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}