using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class ReferenceToTheBasisUnit : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("251", "ReferenceToTheBasisUnit", 3, DataType.Alphanumeric, 30, true);

        #endregion
    }
}