namespace TI.GS1.Parser.AI.other.Unprocessed
{
    public sealed class GS1ProductModel: GS1BarcodeItem
    {
        public GS1ProductModel()
        {
            Id = "20";
            Description = "ProductModel";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 2;
            Fnc1 = false;
        }
       
    }
}