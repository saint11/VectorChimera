namespace VectorChimera
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imagePreviewArea = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.paletteBoxOld = new System.Windows.Forms.ListBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.paletteBoxNew = new System.Windows.Forms.ListBox();
            this.zoom1x = new System.Windows.Forms.RadioButton();
            this.zoom2x = new System.Windows.Forms.RadioButton();
            this.zoom4x = new System.Windows.Forms.RadioButton();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePreviewArea
            // 
            this.imagePreviewArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePreviewArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.imagePreviewArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imagePreviewArea.InitialImage = null;
            this.imagePreviewArea.Location = new System.Drawing.Point(12, 12);
            this.imagePreviewArea.Name = "imagePreviewArea";
            this.imagePreviewArea.Size = new System.Drawing.Size(568, 544);
            this.imagePreviewArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagePreviewArea.TabIndex = 1;
            this.imagePreviewArea.TabStop = false;
            // 
            // paletteBoxOld
            // 
            this.paletteBoxOld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteBoxOld.BackColor = System.Drawing.SystemColors.Window;
            this.paletteBoxOld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteBoxOld.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paletteBoxOld.FormattingEnabled = true;
            this.paletteBoxOld.IntegralHeight = false;
            this.paletteBoxOld.ItemHeight = 25;
            this.paletteBoxOld.Location = new System.Drawing.Point(911, 95);
            this.paletteBoxOld.Name = "paletteBoxOld";
            this.paletteBoxOld.Size = new System.Drawing.Size(98, 460);
            this.paletteBoxOld.TabIndex = 3;
            // 
            // fileListBox
            // 
            this.fileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.fileListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileListBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.IntegralHeight = false;
            this.fileListBox.ItemHeight = 16;
            this.fileListBox.Location = new System.Drawing.Point(586, 14);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileListBox.Size = new System.Drawing.Size(307, 541);
            this.fileListBox.TabIndex = 2;
            // 
            // paletteBoxNew
            // 
            this.paletteBoxNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paletteBoxNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paletteBoxNew.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paletteBoxNew.FormattingEnabled = true;
            this.paletteBoxNew.IntegralHeight = false;
            this.paletteBoxNew.ItemHeight = 25;
            this.paletteBoxNew.Location = new System.Drawing.Point(1015, 95);
            this.paletteBoxNew.Name = "paletteBoxNew";
            this.paletteBoxNew.Size = new System.Drawing.Size(98, 460);
            this.paletteBoxNew.TabIndex = 4;
            // 
            // zoom1x
            // 
            this.zoom1x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom1x.AutoSize = true;
            this.zoom1x.Checked = true;
            this.zoom1x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom1x.Location = new System.Drawing.Point(13, 561);
            this.zoom1x.Name = "zoom1x";
            this.zoom1x.Size = new System.Drawing.Size(77, 21);
            this.zoom1x.TabIndex = 5;
            this.zoom1x.TabStop = true;
            this.zoom1x.Text = "zoom1x";
            this.zoom1x.UseVisualStyleBackColor = true;
            // 
            // zoom2x
            // 
            this.zoom2x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom2x.AutoSize = true;
            this.zoom2x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom2x.Location = new System.Drawing.Point(96, 560);
            this.zoom2x.Name = "zoom2x";
            this.zoom2x.Size = new System.Drawing.Size(77, 21);
            this.zoom2x.TabIndex = 5;
            this.zoom2x.Text = "zoom2x";
            this.zoom2x.UseVisualStyleBackColor = true;
            // 
            // zoom4x
            // 
            this.zoom4x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom4x.AutoSize = true;
            this.zoom4x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom4x.Location = new System.Drawing.Point(179, 560);
            this.zoom4x.Name = "zoom4x";
            this.zoom4x.Size = new System.Drawing.Size(77, 21);
            this.zoom4x.TabIndex = 5;
            this.zoom4x.Text = "zoom4x";
            this.zoom4x.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveAll.Enabled = false;
            this.buttonSaveAll.Location = new System.Drawing.Point(786, 561);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(107, 30);
            this.buttonSaveAll.TabIndex = 6;
            this.buttonSaveAll.Text = "ovewride all";
            this.buttonSaveAll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(908, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "old";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(1012, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "new";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::VectorChimera.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(945, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 70);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1125, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.zoom4x);
            this.Controls.Add(this.zoom2x);
            this.Controls.Add(this.zoom1x);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.paletteBoxNew);
            this.Controls.Add(this.paletteBoxOld);
            this.Controls.Add(this.imagePreviewArea);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Vector Chimera";
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePreviewArea;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ListBox paletteBoxOld;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.ListBox paletteBoxNew;
        private System.Windows.Forms.RadioButton zoom1x;
        private System.Windows.Forms.RadioButton zoom2x;
        private System.Windows.Forms.RadioButton zoom4x;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

