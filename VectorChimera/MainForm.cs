using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorChimera
{
    public partial class MainForm : Form
    {
        public Dictionary<int, int> Palette;

        List<string> FileList;
        private int Zoom=1;

        private ColorLists ColorLists;

        public MainForm()
        {
            InitializeComponent();

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(DragFileEnter);
            this.DragDrop += new DragEventHandler(DragFileDrop);
            this.DragLeave += new EventHandler(DragFileLeave);

            fileListBox.SelectedIndexChanged += fileListBox_SelectedIndexChanged;

            zoom1x.CheckedChanged += zoom1x_CheckedChanged;
            zoom2x.CheckedChanged += zoom2x_CheckedChanged;
            zoom4x.CheckedChanged += zoom3x_CheckedChanged;

            buttonSaveAll.Click += buttonSaveAll_Click;

            ColorLists = new ColorLists(paletteBoxOld, paletteBoxNew, this)
            {
                ShowColorDialog = showColorDialog,
                RefreshImage = RefreshImage
            };

            imagePreviewArea.MouseClick += imagePreviewArea_MouseClick;
            Bitmap dropImage = new Bitmap(ImageHandler.LoadImageNoLock(AppDomain.CurrentDomain.BaseDirectory + "dropFiles.png"));
            imagePreviewArea.Image = ImageHandler.ResizeBitmap(dropImage, dropImage.Width * 4, dropImage.Height * 4);

        }

        void imagePreviewArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (imagePreviewArea.Image != null && e.Button == MouseButtons.Left)
            {
                Color selectedColor = Color.Black;

                Bitmap image = new Bitmap(imagePreviewArea.Image);
                int offsetX = imagePreviewArea.Width / 2 - image.Width / 2;
                int offsetY = imagePreviewArea.Height / 2 - image.Height / 2;

                if ((new Rectangle(offsetX, offsetY, image.Width, image.Height)).Contains(e.X, e.Y))
                    selectedColor = image.GetPixel(e.X - offsetX, e.Y - offsetY);

                ColorLists.SelectColor(selectedColor);
            }
        }

    #region Buttons
        void buttonSaveAll_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to overwrite everything? There's no undo here.",
                        "Confirm Overwrite!",
                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ColorPalette.SaveFiles(Palette, FileList);
            }
            else
            {

            }
            
        }

        private void zoom1x_CheckedChanged(object sender, EventArgs e)
        {
            Zoom = 1;
            RefreshImage();
        }
        void zoom2x_CheckedChanged(object sender, EventArgs e)
        {
            Zoom = 2;
            RefreshImage();
        }
        private void zoom3x_CheckedChanged(object sender, EventArgs e)
        {
            Zoom = 4;
            RefreshImage();
        }
#endregion

    #region DragFiles
        private void DragFileLeave(object sender, EventArgs e)
        {
            imagePreviewArea.BackColor = Color.FromArgb(32, 32, 32);
        }

        void DragFileEnter(object sender, DragEventArgs e)
        {
            imagePreviewArea.BackColor = Color.FromArgb(80, 80, 80);            
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void DragFileDrop(object sender, DragEventArgs e)
        {
            imagePreviewArea.BackColor = Color.FromArgb(32, 32, 32);

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (FileList == null) FileList = new List<string>();

            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    Bitmap mainImage = null;

                    if (!FileList.Contains(file)) FileList.Add(file);
                    try
                    {
                        mainImage = new Bitmap(ImageHandler.LoadImageNoLock(file));
                    }
                    catch
                    {
                        Console.WriteLine("Not an image!");
                    }

                    if (mainImage != null)
                    {
                        if (Palette == null) Palette = new Dictionary<int, int>();
                        foreach (var c in ColorPalette.ExtractPalette(mainImage)) if (!Palette.ContainsKey(c)) Palette[c] = c;
                    }
                }
            }


            fileListBox.Items.Clear();
            foreach (var f in FileList) fileListBox.Items.Add(f);
            fileListBox.Refresh();

            fileListBox.SelectedIndex = fileListBox.Items.Count-1;

            RefreshImage();
            ColorLists.RefreshPalette();
            buttonSaveAll.Enabled = true;
        }

    #endregion

    #region Refreshes
        private void RefreshImage()
        {
            Image temp = ImageHandler.LoadImageNoLock(FileList[fileListBox.SelectedIndex]);
            imagePreviewArea.Image = ImageHandler.ResizeBitmap(ColorPalette.SwapColors(Palette, new Bitmap(temp)), Zoom * temp.Width, Zoom * temp.Height);
        }

        
    #endregion

        void fileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshImage();
        }

        ColorResult showColorDialog()
        {
            DialogResult colorResult = colorDialog.ShowDialog();

            return new ColorResult() { Dialog = colorDialog, Result= colorResult };
        }

    }
}
