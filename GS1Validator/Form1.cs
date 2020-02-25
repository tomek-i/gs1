using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS1Validator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void textBoxBarcode_BarcodeRecieved(object sender, EventArgs e)
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
            foreach (var segment in barcode?.Segments)
            {
                flowLayoutPanel1.Controls.Add(new BarcodeSegmentDisplay(segment));
            }
        }

        //private async void textBoxBarcode_TextChanged(object sender, EventArgs e)
        //{
        //    TI.GS1.GS1Barcode barcode = null;
        //    await Task.Factory.StartNew(() =>
        //    {
        //        barcode = new TI.GS1.GS1Barcode(textBoxBarcode.Text);
        //    });


        //    foreach (var segment in barcode.Segments)
        //    {
        //        flowLayoutPanel1.Controls.Add(new BarcodeSegmentDisplay(segment));
        //    }
        //}
    }
}
