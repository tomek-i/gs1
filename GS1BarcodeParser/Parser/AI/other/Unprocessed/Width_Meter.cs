using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class Width_Meter : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("312d", "Width_Meter", 4, DataType.Numeric, 6, false);

        #endregion
    }
}