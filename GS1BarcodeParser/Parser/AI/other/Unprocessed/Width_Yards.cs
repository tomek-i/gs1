using Information.Barcode.GS1;

namespace Information.Barcode.AI.other.Unprocessed
{
    public sealed class Width_Yards : GS1BarcodeItem
    {
        #region Overrides of Gs1Item

        public override ApplicationIdentifier Ai { get; } = new ApplicationIdentifier("326d", "Width_Yards", 4, DataType.Numeric, 6, false);

        #endregion
    }
}