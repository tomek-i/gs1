using System.Collections.Generic;

namespace TI.GS1.API
{
    /// <summary>
    /// Interface of a GS1 Barcode Parser
    /// </summary>
    public interface IGS1BarcodeParser
    {
        string Ean128StartCode { get; set; }
        char GroupSeparator { get; set; }
        bool HasCheckSum { get; set; }
        IList<IGS1Item> Parse(string barcode, bool throwException = false);
    }
}