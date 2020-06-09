namespace TI.GS1.Parser.AI.other.LogisticMeasure
{
    public sealed class GS1LogisticLengthInches : GS1BarcodeItem
    {
        public GS1LogisticLengthInches()
        {
            Id = "341d";
            Description = "Length_Inches";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;

        }

    }
}