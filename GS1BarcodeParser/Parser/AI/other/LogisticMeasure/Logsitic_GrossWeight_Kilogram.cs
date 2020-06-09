namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticGrossWeightKilogram : GS1BarcodeItem
    {

        public GS1LogisticGrossWeightKilogram()
        {
            Id = "330d";
            Description = "Logistic weight, kilograms";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}