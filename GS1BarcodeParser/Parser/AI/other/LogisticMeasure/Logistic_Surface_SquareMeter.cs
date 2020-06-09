namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticSurfaceSquareMeter : GS1BarcodeItem
    {
        public GS1LogisticSurfaceSquareMeter()
        {
            Id = "334d";
            Description = "Surface_SquareMeter";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;

        }


    }
}