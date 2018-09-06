namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1DueDate : GS1BarcodeItem
    {

        public GS1DueDate()
        {
            Id = "12";
            Description = "Due Date (YYMMDD)";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }
       
    }
}