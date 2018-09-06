namespace TI.GS1.Parser.AI
{
    public sealed class GS1BatchNumber: GS1BarcodeItem
    {
     
        public GS1BatchNumber()
        {
            Id = "10";
            Description = "Batch or lot number";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 20;
            Fnc1 = true;
        }
    }

   
}