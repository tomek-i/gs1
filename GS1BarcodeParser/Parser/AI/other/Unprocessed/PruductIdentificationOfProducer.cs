using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class PruductIdentificationOfProducer : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("240", "PruductIdentificationOfProducer", 3, DataType.Alphanumeric, 30, true);

        #endregion
    }
}