using EyeDropper;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace VectorChimera
{
    public partial class ColorPicker : Form
    {
        public Color OldColor = Color.Black;
        public Color SelectedColor = Color.Black;

        private BitmapSource screenimage;

        private byte[] pixels;

        private DispatcherTimer timer;

        private System.Windows.Point previousposition;

        private Color backBrush;

        private bool ineyedropmode;

        public ColorPicker()
        {
            InitializeComponent();

            if (timer == null)
            {
                timer = new DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
                timer.Tick += new EventHandler(timer_Tick);
            }

            buttonOk.Click += buttonOk_Click;
            buttonReset.Click += buttonReset_Click;
            buttonWinColor.Click += buttonWinColor_Click;

            trackBarRed.ValueChanged += trackBarRGB_ValueChanged;
            trackBarGreen.ValueChanged += trackBarRGB_ValueChanged;
            trackBarBlue.ValueChanged += trackBarRGB_ValueChanged;

            trackBarHue.ValueChanged += trackBarHSV_ValueChanged;
            trackBarSaturation.ValueChanged += trackBarHSV_ValueChanged;
            trackBarValue.ValueChanged += trackBarHSV_ValueChanged;

            textBoxR.TextChanged += textBox_TextChanged;
            textBoxG.TextChanged += textBox_TextChanged;
            textBoxB.TextChanged += textBox_TextChanged;
            textBoxH.TextChanged += textBox_TextChanged;
            textBoxS.TextChanged += textBox_TextChanged;
            textBoxV.TextChanged += textBox_TextChanged;

            textBoxHexa.TextChanged += textBox_HexaTextChanged;
        }

        private void textBox_HexaTextChanged(object sender, EventArgs e)
        {
            if (textBoxHexa.Text.Count() == 6)
            {
                int red = ParseHexa(textBoxHexa.Text.Substring(0, 2), trackBarRed.Minimum, trackBarRed.Maximum);
                int green = ParseHexa(textBoxHexa.Text.Substring(2, 2), trackBarGreen.Minimum, trackBarGreen.Maximum);
                int blue = ParseHexa(textBoxHexa.Text.Substring(4, 2), trackBarBlue.Minimum, trackBarBlue.Maximum);

                SetColor(Color.FromArgb(red, green, blue),false,"hex");
            }
        }

        
        void textBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSlidersFromText();
        }

        private void UpdateSlidersFromText()
        {
            trackBarRed.Value = ParseClamp(textBoxR.Text, trackBarRed.Minimum,trackBarRed.Maximum);
            textBoxR.Text = trackBarRed.Value.ToString();

            trackBarGreen.Value = ParseClamp(textBoxG.Text, trackBarGreen.Minimum, trackBarGreen.Maximum);
            textBoxG.Text = trackBarGreen.Value.ToString();

            trackBarBlue.Value = ParseClamp(textBoxB.Text, trackBarBlue.Minimum, trackBarBlue.Maximum);
            textBoxB.Text = trackBarBlue.Value.ToString();

            trackBarHue.Value = ParseClamp(textBoxH.Text, trackBarHue.Minimum, trackBarHue.Maximum);
            textBoxH.Text = trackBarHue.Value.ToString();

            trackBarSaturation.Value = ParseClamp(textBoxS.Text, trackBarSaturation.Minimum, trackBarSaturation.Maximum);
            textBoxS.Text = trackBarSaturation.Value.ToString();

            trackBarValue.Value = ParseClamp(textBoxV.Text, trackBarValue.Minimum, trackBarValue.Maximum);
            textBoxV.Text = trackBarValue.Value.ToString();
        }

        private int ParseHexa(string text, int min, int max)
        {
            int ret;
            try
            {
                ret = int.Parse(text, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                ret = min;
            }

            return Util.Clamp(ret, min, max);
        }

        private int ParseClamp(string text,int min, int max)
        {
            int ret;
            try
            {
                ret = int.Parse(text);
            }
            catch
            {
                ret = min;
            }
            
            return Util.Clamp(ret,min,max);
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
            textBoxH.Text = trackBarHue.Value.ToString();
            textBoxS.Text = trackBarSaturation.Value.ToString();
            textBoxV.Text = trackBarValue.Value.ToString();
        }

        void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public void SetColor(Color color, bool both = true,string origin="slider")
        {
            if (both)
            {
                OldColor = SelectedColor = color;
                labelOldValue.Text = color.R.ToString("X") + color.G.ToString("X") + color.B.ToString("X");
            }
            newColorBox.BackColor = oldColorBox.BackColor = OldColor;

            trackBarRed.Value = color.R;
            trackBarGreen.Value = color.G;
            trackBarBlue.Value = color.B;

            float cMax = Math.Max(Math.Max(color.R,color.G),color.B);
            float cMin = Math.Min(Math.Min(color.R, color.G), color.B);

            trackBarHue.Value = (int)(color.GetHue()*10);
            if (cMax - cMin == 0) trackBarSaturation.Value = 0;
            else trackBarSaturation.Value = (int)(((cMax-cMin)/cMax )* 1000);
            trackBarValue.Value = (int)(cMax);

            if (origin!="hex") textBoxHexa.Text = color.R.ToString("X") + color.G.ToString("X") + color.B.ToString("X");

            UpdateRGBNewColor();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            System.Drawing.Point _point = System.Windows.Forms.Control.MousePosition;
            System.Windows.Point point = new System.Windows.Point(_point.X, _point.Y);
            if (previousposition == null || previousposition != point)
            {
                if (screenimage != null)
                {
                    int stride = (screenimage.PixelWidth * screenimage.Format.BitsPerPixel + 7) / 8;
                    pixels = new byte[screenimage.PixelHeight * stride];
                    Int32Rect rect = new Int32Rect((int)point.X, (int)point.Y, 1, 1);
                    screenimage.CopyPixels(rect, pixels, stride, 0);
                    rectcolor.BackColor = Color.FromArgb(255,pixels[2], pixels[1], pixels[0]);
                    txt.Text = InteropHelper.ConvertToString(rectcolor.BackColor);
                    SetColor(Color.FromArgb(255, pixels[2], pixels[1], pixels[0]),false,"picker");
                }
            }
            if (System.Windows.Forms.Control.MouseButtons != System.Windows.Forms.MouseButtons.Left)
            {
                timer.Stop();
                ResetCursorToDefault();
            }
            previousposition = point;
        }

        private Dictionary<string, string> paths = new Dictionary<string, string>();

        private void rectcolor_MouseDown(object sender, EventArgs e)
        {
            screenimage = InteropHelper.CaptureRegion(InteropHelper.GetDesktopWindow(),
                                                                       (int)SystemParameters.VirtualScreenLeft,
                                                                       (int)SystemParameters.VirtualScreenTop,
                                                                       (int)SystemParameters.PrimaryScreenWidth,
                                                                       (int)SystemParameters.PrimaryScreenHeight);
            backBrush = rectcolor.BackColor;
            if (paths.Count() > 0)
            {
                ResetCursorToDefault();
            }
            else
            {
                timer.Start();
                ineyedropmode = true;
                ChangeCursor();
            }
        }

        private void ChangeCursor()
        {
            RegistryKey pRegKey = Registry.CurrentUser;
            pRegKey = pRegKey.OpenSubKey(@"Control Panel\Cursors");
            paths.Clear();
            foreach (var key in pRegKey.GetValueNames())
            {
                Object _key = pRegKey.GetValue(key);
                //Take a backup.
                paths.Add(key, _key.ToString());
                Object val = Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\Cursors", key, null);
                Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Cursors", key, AppDomain.CurrentDomain.BaseDirectory + @"eyedropper.cur");
            }

            InteropHelper.SystemParametersInfo(InteropHelper.SPI_SETCURSORS, 0, null, InteropHelper.SPIF_UPDATEINIFILE | InteropHelper.SPIF_SENDCHANGE);
        }

        private void ResetCursorToDefault()
        {
            timer.Stop();

            RegistryKey pRegKey = Registry.CurrentUser;
            pRegKey = pRegKey.OpenSubKey(@"Control Panel\Cursors");
            foreach (string key in paths.Keys)
            {
                string path = paths[key];
                Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Cursors", key, path);
            }
            InteropHelper.SystemParametersInfo(InteropHelper.SPI_SETCURSORS, 0, null, InteropHelper.SPIF_UPDATEINIFILE | InteropHelper.SPIF_SENDCHANGE);
        }
    }
}
