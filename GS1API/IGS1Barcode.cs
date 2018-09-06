using System.Collections.Generic;

namespace TI.GS1.API
{
    public interface IGS1Barcode
    {
        string Barcode { get; }
        string BarcodeReadable { get; }
        IList<IGS1Item> Segments { get; }

        bool Contains(string applicationIdentifier);
        bool Contains(IGS1Item item);
        T GetSegment<T>() where T : IGS1Item;
        T GetSegment<T>(string applicationIdentifier) where T : IGS1Item;
        IGS1Item GetSegment(string applicationIdentifier);
        

        void ReparseSegments();
        void ReparseSegments(IGS1BarcodeParser parser);
    }
}