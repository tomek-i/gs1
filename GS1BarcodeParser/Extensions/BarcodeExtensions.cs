using System.Collections.Generic;
using System.Linq;
using TI.GS1.API;

namespace TI.GS1.Extensions
{

    /// <summary>
    /// Extension methods for convinience
    /// </summary>
    public static class BarcodeExtensions
    {

        public static T Get<T>(this IList<IGS1Item> barcode) where T : class, IGS1Item
        {
            return barcode.Where(x => x is T).SingleOrDefault() as T;
        }

        /// <summary>
        /// Returns all segments of specific type as a list
        /// </summary>
        /// <typeparam name="T">The Type of the segment you are looking for</typeparam>
        /// <param name="barcode">The barcode to parse</param>
        /// <returns>A list of GS1 Types</returns>
        public static IList<T> All<T>(this IList<IGS1Item> barcode) where T : class, IGS1Item
        {
            return barcode.Where(x => x is T).Cast<T>().ToList();
        }

        public static string GetValue<T>(this IList<IGS1Item> barcode) where T : class, IGS1Item
        {
            return Get<T>(barcode)?.Value;
        }

    }
}
