using System;
using System.Drawing;
using System.Windows.Forms;

namespace GS1Validator
{
    public partial class BarcodeSegmentDisplay : UserControl
    {
        private readonly TI.GS1.API.IGS1Item segment;
        public BarcodeSegmentDisplay()
        {
            InitializeComponent();

        }
        public BarcodeSegmentDisplay(TI.GS1.API.IGS1Item segment) : this()
        {
            this.segment = segment;
        }

        private void BarcodeSegmentDisplay_Load(object sender, EventArgs e)
        {
            textBoxId.Text = segment.Id;
            textBoxValue.Text = segment.Value;
            toolTip1.SetToolTip(textBoxId, $"{segment.Description}");
            toolTip1.SetToolTip(textBoxValue, $"Length: {textBoxValue.Text.Length}");
            labelItemDesc.Text = segment.Description;
        }

    }
}
