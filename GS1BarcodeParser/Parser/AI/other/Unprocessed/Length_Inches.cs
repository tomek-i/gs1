using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class Length_Inches : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("321d", "Length_Inches", 4, DataType.Numeric, 6, false);

        #endregion
    }
}