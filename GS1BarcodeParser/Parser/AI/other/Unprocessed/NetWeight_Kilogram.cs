using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class NetWeight_Kilogram : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("310d", "NetWeight_Kilogram", 4, DataType.Numeric, 6, false);

        #endregion
    }
}