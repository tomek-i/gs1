namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticGrossVolumeLiters : GS1BarcodeItem
    {
        public GS1LogisticGrossVolumeLiters()
        {
            Id = "335d";
            Description = "Logistic volume, litres";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}