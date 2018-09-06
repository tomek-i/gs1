namespace TI.GS1.Parser.AI.other
{
    public sealed class GS1GlobalIdentifierSerialisedForTrade : GS1BarcodeItem
    {
        public GS1GlobalIdentifierSerialisedForTrade()
        {
            Id = "252";
            Description = "Global Identifier Serialised for Trade";
            DataDescription = GS1BarcodeItemDataType.Numeric;
            LengthOfData = 2;
            Fnc1 = false;
        }
       
    }
}