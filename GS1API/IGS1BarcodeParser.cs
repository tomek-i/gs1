using System.Collections.Generic;

namespace TI.GS1.API
{
    public interface IGS1BarcodeParser
    {
        string Ean128StartCode { get; set; }
        char GroupSeparator { get; set; }
        bool HasCheckSum { get; set; }
        IList<IGS1Item> Parse(string barcode, bool throwException = false);
    }
}