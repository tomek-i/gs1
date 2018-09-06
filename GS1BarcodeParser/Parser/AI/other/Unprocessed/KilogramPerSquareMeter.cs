using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class KilogramPerSquareMeter : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("337d", "KilogramPerSquareMeter", 4, DataType.Numeric, 6, false);

        #endregion
    }
}