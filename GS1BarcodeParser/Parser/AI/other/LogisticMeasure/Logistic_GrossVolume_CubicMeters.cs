namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticGrossVolumeCubicMeters : GS1BarcodeItem
    {
        public GS1LogisticGrossVolumeCubicMeters()
        {
            Id = "336d";
            Description = "Logistic volume, cubic metres";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}