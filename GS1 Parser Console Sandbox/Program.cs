using WarburnEstate.GS1;

namespace GS1_Parser_Console_Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //(02) 9 3200051 940212 (37) 864 {GS} (10) 72205 (90) 101270754951
            string GS1BarcodeHuman = "(02) 9 3200051 940212 (37) 864 (10) 72205 (90) 101270754951";
            string GS1Barcode = $"029320005194021237864{(char)29}1072205{(char)29}90101270754951";


            var barcode = new GS1Barcode(GS1Barcode);
            
        }
    }
}
