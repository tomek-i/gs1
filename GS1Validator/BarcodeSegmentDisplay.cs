using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GS1Validator
{
    public partial class BarcodeSegmentDisplay : UserControl
    {
        bool displayFull = false;
        TI.GS1.API.IGS1Item segment;
        public BarcodeSegmentDisplay()
        {
            InitializeComponent();
           
        }
        public BarcodeSegmentDisplay(TI.GS1.API.IGS1Item segment):this()
        {
            this.segment = segment;
        }

        private void BarcodeSegmentDisplay_Load(object sender, EventArgs e)
        {
            textBoxId.Text = segment.Id;
            textBoxValue.Text = segment.Value;
            toolTip1.SetToolTip(textBoxId, $"{segment.Description}");
            toolTip1.SetToolTip(textBoxValue,$"Length: {textBoxValue.Text.Length}");
            labelItemDesc.Text = segment.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (displayFull)
                this.Size = new Size(248, 180);
            else
                this.Size = new Size(248, 63);
        }
    }
}
