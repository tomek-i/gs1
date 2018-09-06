namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class GS1ProducerDate : GS1BarcodeItem
    {
        public GS1ProducerDate()
        {
            Id = "11";
            Description = "ProducerDate_JJMMDD";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 6;
            Fnc1 = false;
        }
        
       
    }
}