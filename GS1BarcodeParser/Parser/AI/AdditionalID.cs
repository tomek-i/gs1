namespace TI.GS1.Parser.AI
{
    public sealed class AdditionalID : GS1BarcodeItem
    {
        public AdditionalID()
        {
            Id = "240";
            Description = "Additional product identification assigned by the manufacturer";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 30;
            Fnc1 = true;
        }
    }

}