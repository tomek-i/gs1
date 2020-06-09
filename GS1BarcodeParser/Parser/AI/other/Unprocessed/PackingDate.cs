namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class GS1PackingDate : GS1BarcodeItem
    {
        public GS1PackingDate()
        {
            Id = "13";
            Description = "PackingDate_JJMMDD";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }

    }
}