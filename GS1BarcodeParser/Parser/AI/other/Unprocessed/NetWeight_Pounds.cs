using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class NetWeight_Pounds : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("320d", "NetWeight_Pounds", 4, DataType.Numeric, 6, false);

        #endregion
    }
}