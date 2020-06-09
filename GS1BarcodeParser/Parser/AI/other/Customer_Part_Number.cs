namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1CustomerPartNumber : GS1BarcodeItem
    {

        public GS1CustomerPartNumber()
        {
            Id = "241";
            Description = "Customer Part Number";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 30;
            Fnc1 = true;

        }

    }
}