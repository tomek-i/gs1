using System.Collections.Generic;

namespace TI.GS1.API
{
    public interface IGS1Barcode
    {
        /// <summary>
        /// Barcode as string
        /// </summary>
        string Barcode { get; }

        /// <summary>
        /// Barcode as a human readable string
        /// </summary>
        string BarcodeReadable { get; }

        /// <summary>
        /// Individual GS1 items extracted of the barcode
        /// </summary>
        IList<IGS1Item> Segments { get; }

        /// <summary>
        /// Check if the barcode contains the specified application identifier  (AI)
        /// </summary>
        /// <param name="applicationIdentifier"></param>
        /// <returns>true if the barcode contained the AI</returns>
        bool Contains(string applicationIdentifier);
        /// <summary>
        /// Check if the barcode contains the specified GS1 Item
        /// </summary>
        /// <param name="applicationIdentifier"></param>
        /// <returns>true if the barcode contained the GS1 Item</returns>
        bool Contains(IGS1Item item);

        T GetSegment<T>() where T : IGS1Item;
        T GetSegment<T>(string applicationIdentifier) where T : IGS1Item;
        IGS1Item GetSegment(string applicationIdentifier);

        /// <summary>
        /// Re-parse the barcode for GS1 segments
        /// </summary>
        void ReparseSegments();

        /// <summary>
        /// Re-parse the barcode for GS1 segments with the specified parser
        /// </summary>
        void ReparseSegments(IGS1BarcodeParser parser);
    }
}