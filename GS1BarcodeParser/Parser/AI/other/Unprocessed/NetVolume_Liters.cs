using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class NetVolume_Liters : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("315d", "NetVolume_Liters", 4, DataType.Numeric, 6, false);

        #endregion
    }
}