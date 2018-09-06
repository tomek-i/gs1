namespace TI.GS1.Parser.AI.other.VariableMeasure
{
    public sealed class GS1HeightYards : GS1BarcodeItem
    {

        public GS1HeightYards()
        {
            Id = "329d";
            Description = "Depth, thickness, height or third dimension, yards (variable measure trade item)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }
       
    }
}