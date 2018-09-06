namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1BilateralApplication : GS1BarcodeItem
    {
        public GS1BilateralApplication()
        {
            Id = "90";
            Description = "TODO";
            DataDescription = GS1BarcodeItemDataType.Alphanumeric;
            LengthOfData = 30;
            Fnc1 = true;
        }
    }
}