namespace TI.GS1.Parser.AI
{
    public sealed class GS1BestBeforeDate : GS1BarcodeItem
    {
        public GS1BestBeforeDate()
        {
            Id = "15";
            Description = "Best before date (YYMMDD)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }
    }

}