namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticGrossWeightPounds : GS1BarcodeItem
    {
        public GS1LogisticGrossWeightPounds()
        {
            Id = "340d";
            Description = "Logistic weight, pounds";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;

        }
       
    }
}