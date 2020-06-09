using TI.GS1.API;


namespace TI.GS1.Parser
{

    public abstract class GS1BarcodeItem : IGS1Item
    {
        public string Id { get; internal set; }
        public string Value { get; internal set; }
        public string Description { get; internal set; }

        protected internal int LengthOfAi => Id.Length;
        protected internal GS1BarcodeItemDataType DataDescription { get; internal set; }
        protected internal int LengthOfData { get; internal set; }
        protected internal bool Fnc1 { get; internal set; }

        public override string ToString()
        {
            return $"({Id}) {Value}";
        }
    }
}