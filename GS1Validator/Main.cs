using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS1Validator
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void TextBoxBarcode_BarcodeRecieved(object sender, EventArgs e)
        {

            TI.GS1.GS1Barcode barcode = null;
            await Task.Factory.StartNew(() =>
            {
                try
                {
                    barcode = new TI.GS1.GS1Barcode(textBoxBarcode.Text, new TI.GS1.Parser.GS1BarcodeParser() { HasCheckSum = false });
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            });

            flowLayoutPanel1.Controls.Clear();
            foreach (TI.GS1.API.IGS1Item segment in barcode?.Segments)
            {
                flowLayoutPanel1.Controls.Add(new BarcodeSegmentDisplay(segment));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            Console.WriteLine(text);
            textBoxBarcode.Text = text;
        }
    }
}
