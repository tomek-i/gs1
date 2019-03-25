using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.GS1.API;

namespace TI.GS1.Extensions
{

    /// <summary>
    /// Extension methods for convinience
    /// </summary>
    public static class BarcodeExtensions
    {

        public static T Get<T>(this IList<IGS1Item> barcode) where T: class, IGS1Item
        {
            return barcode.Where(x => x is T).SingleOrDefault() as T;
        }

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
