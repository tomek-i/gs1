
using TI.GS1.Extensions;
using TI.GS1.Parser;
using TI.GS1.Parser.AI;

namespace GS1_Parser_Console_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //(02) 9 3200051 940212 (37) 864 {GS} (10) 72205 (90) 101270754951
            string GS1BarcodeHuman = "(02) 9 3200051 940212 (37) 864 (10) 72205 (90) 101270754951";
            string GS1Barcode = $"029320005194021237864{(char)29}1072205{(char)29}90101270754951";


            var barcode = new GS1BarcodeParser().Parse(GS1Barcode);
            System.Collections.Generic.IList<GS1EANContent> x = barcode.All<GS1EANContent>();
        }
    }
}
