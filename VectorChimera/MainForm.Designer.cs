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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.paletteBoxOld = new System.Windows.Forms.ListBox();
            this.paletteBoxNew = new System.Windows.Forms.ListBox();
            this.zoom1x = new System.Windows.Forms.RadioButton();
            this.zoom2x = new System.Windows.Forms.RadioButton();
            this.zoom4x = new System.Windows.Forms.RadioButton();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagePreviewArea = new System.Windows.Forms.PictureBox();
            this.checkIgnore = new System.Windows.Forms.CheckBox();
            this.zoom6x = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResizeAll = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewArea)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResizeAll)).BeginInit();
            this.SuspendLayout();
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
            this.paletteBoxOld.Location = new System.Drawing.Point(683, 77);
            this.paletteBoxOld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paletteBoxOld.Name = "paletteBoxOld";
            this.paletteBoxOld.Size = new System.Drawing.Size(74, 394);
            this.paletteBoxOld.TabIndex = 3;
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
            this.paletteBoxNew.Location = new System.Drawing.Point(761, 77);
            this.paletteBoxNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paletteBoxNew.Name = "paletteBoxNew";
            this.paletteBoxNew.Size = new System.Drawing.Size(74, 394);
            this.paletteBoxNew.TabIndex = 4;
            // 
            // zoom1x
            // 
            this.zoom1x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom1x.AutoSize = true;
            this.zoom1x.Checked = true;
            this.zoom1x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom1x.Location = new System.Drawing.Point(10, 476);
            this.zoom1x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoom1x.Name = "zoom1x";
            this.zoom1x.Size = new System.Drawing.Size(61, 17);
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
            this.zoom2x.Location = new System.Drawing.Point(72, 475);
            this.zoom2x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoom2x.Name = "zoom2x";
            this.zoom2x.Size = new System.Drawing.Size(61, 17);
            this.zoom2x.TabIndex = 5;
            this.zoom2x.Text = "zoom2x";
            this.zoom2x.UseVisualStyleBackColor = true;
            // 
            // zoom4x
            // 
            this.zoom4x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom4x.AutoSize = true;
            this.zoom4x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom4x.Location = new System.Drawing.Point(134, 475);
            this.zoom4x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoom4x.Name = "zoom4x";
            this.zoom4x.Size = new System.Drawing.Size(61, 17);
            this.zoom4x.TabIndex = 5;
            this.zoom4x.Text = "zoom4x";
            this.zoom4x.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveAll.Enabled = false;
            this.buttonSaveAll.Location = new System.Drawing.Point(548, 476);
            this.buttonSaveAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(122, 24);
            this.buttonSaveAll.TabIndex = 6;
            this.buttonSaveAll.Text = "ovewride all";
            this.buttonSaveAll.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.label1.Location = new System.Drawing.Point(681, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "old";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(759, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "new";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(440, 476);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(104, 24);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "remove selected";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::VectorChimera.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(709, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imagePreviewArea
            // 
            this.imagePreviewArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePreviewArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.imagePreviewArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.imagePreviewArea.Image = global::VectorChimera.Properties.Resources.dropFiles;
            this.imagePreviewArea.InitialImage = global::VectorChimera.Properties.Resources.dropFiles;
            this.imagePreviewArea.Location = new System.Drawing.Point(9, 10);
            this.imagePreviewArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imagePreviewArea.Name = "imagePreviewArea";
            this.imagePreviewArea.Size = new System.Drawing.Size(426, 462);
            this.imagePreviewArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagePreviewArea.TabIndex = 1;
            this.imagePreviewArea.TabStop = false;
            // 
            // checkIgnore
            // 
            this.checkIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIgnore.AutoSize = true;
            this.checkIgnore.Checked = true;
            this.checkIgnore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIgnore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(76)))), ((int)(((byte)(123)))));
            this.checkIgnore.Location = new System.Drawing.Point(440, 454);
            this.checkIgnore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkIgnore.Name = "checkIgnore";
            this.checkIgnore.Size = new System.Drawing.Size(128, 17);
            this.checkIgnore.TabIndex = 9;
            this.checkIgnore.Text = "ignore non-image files";
            this.checkIgnore.UseVisualStyleBackColor = true;
            // 
            // zoom6x
            // 
            this.zoom6x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoom6x.AutoSize = true;
            this.zoom6x.ForeColor = System.Drawing.SystemColors.Menu;
            this.zoom6x.Location = new System.Drawing.Point(196, 475);
            this.zoom6x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zoom6x.Name = "zoom6x";
            this.zoom6x.Size = new System.Drawing.Size(61, 17);
            this.zoom6x.TabIndex = 5;
            this.zoom6x.Text = "zoom6x";
            this.zoom6x.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFiles);
            this.tabControl1.Controls.Add(this.tabActions);
            this.tabControl1.Location = new System.Drawing.Point(440, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 6);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(230, 440);
            this.tabControl1.TabIndex = 10;
            // 
            // tabFiles
            // 
            this.tabFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabFiles.Controls.Add(this.fileListBox);
            this.tabFiles.Location = new System.Drawing.Point(4, 28);
            this.tabFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFiles.Size = new System.Drawing.Size(222, 408);
            this.tabFiles.TabIndex = 0;
            this.tabFiles.Text = "Files";
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
            this.fileListBox.Location = new System.Drawing.Point(2, 2);
            this.fileListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileListBox.Size = new System.Drawing.Size(220, 408);
            this.fileListBox.TabIndex = 3;
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.label4);
            this.tabActions.Controls.Add(this.textBoxResizeAll);
            this.tabActions.Controls.Add(this.label3);
            this.tabActions.Location = new System.Drawing.Point(4, 28);
            this.tabActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabActions.Name = "tabActions";
            this.tabActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabActions.Size = new System.Drawing.Size(222, 408);
            this.tabActions.TabIndex = 1;
            this.tabActions.Text = "Actions";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "%";
            // 
            // textBoxResizeAll
            // 
            this.textBoxResizeAll.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxResizeAll.Location = new System.Drawing.Point(45, 7);
            this.textBoxResizeAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResizeAll.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxResizeAll.Name = "textBoxResizeAll";
            this.textBoxResizeAll.Size = new System.Drawing.Size(90, 20);
            this.textBoxResizeAll.TabIndex = 2;
            this.textBoxResizeAll.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resize";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(844, 510);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkIgnore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.zoom6x);
            this.Controls.Add(this.zoom4x);
            this.Controls.Add(this.zoom2x);
            this.Controls.Add(this.zoom1x);
            this.Controls.Add(this.paletteBoxNew);
            this.Controls.Add(this.paletteBoxOld);
            this.Controls.Add(this.imagePreviewArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Vector Chimera";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreviewArea)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.tabActions.ResumeLayout(false);
            this.tabActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxResizeAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePreviewArea;
        private System.Windows.Forms.ListBox paletteBoxOld;
        private System.Windows.Forms.ListBox paletteBoxNew;
        private System.Windows.Forms.RadioButton zoom1x;
        private System.Windows.Forms.RadioButton zoom2x;
        private System.Windows.Forms.RadioButton zoom4x;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.CheckBox checkIgnore;
        private System.Windows.Forms.RadioButton zoom6x;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown textBoxResizeAll;
        private System.Windows.Forms.Label label4;

    }
}

