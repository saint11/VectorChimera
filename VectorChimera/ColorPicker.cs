using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorChimera
{
    public partial class ColorPicker : Form
    {
        public Color OldColor = Color.Black;
        public Color SelectedColor = Color.Black;

        public ColorPicker()
        {
            InitializeComponent();
            
            buttonOk.Click += buttonOk_Click;
            buttonReset.Click += buttonReset_Click;
            buttonWinColor.Click += buttonWinColor_Click;

            trackBarRed.ValueChanged += trackBarRGB_ValueChanged;
            trackBarGreen.ValueChanged += trackBarRGB_ValueChanged;
            trackBarBlue.ValueChanged += trackBarRGB_ValueChanged;

            trackBarHue.ValueChanged += trackBarHSV_ValueChanged;
            trackBarSaturation.ValueChanged += trackBarHSV_ValueChanged;
            trackBarValue.ValueChanged += trackBarHSV_ValueChanged;
        }

        void buttonWinColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                SetColor(colorDialog.Color,false);
            }
        }

        void trackBarHSV_ValueChanged(object sender, EventArgs e)
        {
            UpdateHSVNewColor();
        }

        void buttonReset_Click(object sender, EventArgs e)
        {
            SetColor(OldColor);
            UpdateRGBNewColor();
        }

        void trackBarRGB_ValueChanged(object sender, EventArgs e)
        {
            UpdateRGBNewColor();   
        }

        void UpdateRGBNewColor()
        {
            newColorBox.BackColor = SelectedColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            textBoxR.Text = trackBarRed.Value.ToString();
            textBoxG.Text = trackBarGreen.Value.ToString();
            textBoxB.Text = trackBarBlue.Value.ToString();
        }

        void UpdateHSVNewColor()
        {
            newColorBox.BackColor = SelectedColor = 
                ColorPalette.FromHSV(trackBarHue.Value/3600f, trackBarSaturation.Value/1000f, trackBarValue.Value/255f);
        }

        void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public void SetColor(Color color, bool both = true)
        {
            if (both) OldColor = SelectedColor = color;
            newColorBox.BackColor = oldColorBox.BackColor = OldColor;
            
            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            trackBarBlue.Value = color.B;


            trackBarHue.Value = (int)(color.GetHue()*10);
            trackBarSaturation.Value = (int)(color.GetSaturation()*1000);
            trackBarValue.Value = (int)(Math.Max(Math.Max(color.R,color.G),color.B));

            UpdateRGBNewColor();
        }
    }
}
