namespace VectorChimera
{
    partial class ColorPicker
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.trackBarValue = new System.Windows.Forms.TrackBar();
            this.trackBarSaturation = new System.Windows.Forms.TrackBar();
            this.trackBarHue = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxHexa = new System.Windows.Forms.TextBox();
            this.labelOldValue = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rectcolor = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.oldColorBox = new System.Windows.Forms.PictureBox();
            this.newColorBox = new System.Windows.Forms.PictureBox();
            this.buttonWinColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(292, 332);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(61, 26);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "ok!";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(9, 332);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(61, 26);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "nah...";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(74, 332);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(61, 26);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(9, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 162);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.tabPage1.Controls.Add(this.textBoxB);
            this.tabPage1.Controls.Add(this.textBoxG);
            this.tabPage1.Controls.Add(this.textBoxR);
            this.tabPage1.Controls.Add(this.trackBarBlue);
            this.tabPage1.Controls.Add(this.trackBarGreen);
            this.tabPage1.Controls.Add(this.trackBarRed);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(336, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RGB";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(295, 102);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(39, 20);
            this.textBoxB.TabIndex = 6;
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(295, 56);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(39, 20);
            this.textBoxG.TabIndex = 5;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(295, 11);
            this.textBoxR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(39, 20);
            this.textBoxR.TabIndex = 4;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.LargeChange = 10;
            this.trackBarBlue.Location = new System.Drawing.Point(4, 102);
            this.trackBarBlue.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(286, 45);
            this.trackBarBlue.SmallChange = 5;
            this.trackBarBlue.TabIndex = 3;
            this.trackBarBlue.TickFrequency = 32;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Value = 1;
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.LargeChange = 10;
            this.trackBarGreen.Location = new System.Drawing.Point(4, 56);
            this.trackBarGreen.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(286, 45);
            this.trackBarGreen.SmallChange = 5;
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.TickFrequency = 32;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Value = 1;
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 10;
            this.trackBarRed.Location = new System.Drawing.Point(4, 11);
            this.trackBarRed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(286, 45);
            this.trackBarRed.SmallChange = 5;
            this.trackBarRed.TabIndex = 1;
            this.trackBarRed.TickFrequency = 32;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Value = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.tabPage2.Controls.Add(this.textBoxV);
            this.tabPage2.Controls.Add(this.textBoxS);
            this.tabPage2.Controls.Add(this.textBoxH);
            this.tabPage2.Controls.Add(this.trackBarValue);
            this.tabPage2.Controls.Add(this.trackBarSaturation);
            this.tabPage2.Controls.Add(this.trackBarHue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(336, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HSV";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(295, 102);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(39, 20);
            this.textBoxV.TabIndex = 6;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(295, 56);
            this.textBoxS.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(39, 20);
            this.textBoxS.TabIndex = 5;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(295, 11);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(39, 20);
            this.textBoxH.TabIndex = 4;
            // 
            // trackBarValue
            // 
            this.trackBarValue.LargeChange = 10;
            this.trackBarValue.Location = new System.Drawing.Point(4, 102);
            this.trackBarValue.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarValue.Maximum = 255;
            this.trackBarValue.Name = "trackBarValue";
            this.trackBarValue.Size = new System.Drawing.Size(286, 45);
            this.trackBarValue.SmallChange = 5;
            this.trackBarValue.TabIndex = 3;
            this.trackBarValue.TickFrequency = 32;
            this.trackBarValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarValue.Value = 1;
            // 
            // trackBarSaturation
            // 
            this.trackBarSaturation.LargeChange = 10;
            this.trackBarSaturation.Location = new System.Drawing.Point(4, 56);
            this.trackBarSaturation.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarSaturation.Maximum = 1000;
            this.trackBarSaturation.Name = "trackBarSaturation";
            this.trackBarSaturation.Size = new System.Drawing.Size(286, 45);
            this.trackBarSaturation.SmallChange = 5;
            this.trackBarSaturation.TabIndex = 2;
            this.trackBarSaturation.TickFrequency = 32;
            this.trackBarSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSaturation.Value = 1;
            // 
            // trackBarHue
            // 
            this.trackBarHue.LargeChange = 10;
            this.trackBarHue.Location = new System.Drawing.Point(4, 11);
            this.trackBarHue.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarHue.Maximum = 3600;
            this.trackBarHue.Name = "trackBarHue";
            this.trackBarHue.Size = new System.Drawing.Size(286, 45);
            this.trackBarHue.SmallChange = 5;
            this.trackBarHue.TabIndex = 1;
            this.trackBarHue.TickFrequency = 32;
            this.trackBarHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarHue.Value = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.tabPage3.Controls.Add(this.textBoxHexa);
            this.tabPage3.Controls.Add(this.labelOldValue);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(336, 136);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HEX";
            // 
            // textBoxHexa
            // 
            this.textBoxHexa.Location = new System.Drawing.Point(116, 59);
            this.textBoxHexa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHexa.Name = "textBoxHexa";
            this.textBoxHexa.Size = new System.Drawing.Size(130, 20);
            this.textBoxHexa.TabIndex = 1;
            this.textBoxHexa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelOldValue
            // 
            this.labelOldValue.AutoSize = true;
            this.labelOldValue.ForeColor = System.Drawing.Color.White;
            this.labelOldValue.Location = new System.Drawing.Point(158, 33);
            this.labelOldValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOldValue.Name = "labelOldValue";
            this.labelOldValue.Size = new System.Drawing.Size(51, 13);
            this.labelOldValue.TabIndex = 0;
            this.labelOldValue.Text = "hex code";
            this.labelOldValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.tabPage4.Controls.Add(this.rectcolor);
            this.tabPage4.Controls.Add(this.txt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(336, 136);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Color Picker";
            // 
            // rectcolor
            // 
            this.rectcolor.BackColor = System.Drawing.Color.Black;
            this.rectcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectcolor.ForeColor = System.Drawing.Color.White;
            this.rectcolor.Location = new System.Drawing.Point(6, 34);
            this.rectcolor.Name = "rectcolor";
            this.rectcolor.Size = new System.Drawing.Size(324, 99);
            this.rectcolor.TabIndex = 3;
            this.rectcolor.Text = "DRAG ME!";
            this.rectcolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rectcolor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rectcolor_MouseDown);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(6, 18);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(324, 13);
            this.txt.TabIndex = 2;
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldColorBox
            // 
            this.oldColorBox.BackColor = System.Drawing.Color.Black;
            this.oldColorBox.Location = new System.Drawing.Point(9, 182);
            this.oldColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.oldColorBox.Name = "oldColorBox";
            this.oldColorBox.Size = new System.Drawing.Size(126, 136);
            this.oldColorBox.TabIndex = 1;
            this.oldColorBox.TabStop = false;
            // 
            // newColorBox
            // 
            this.newColorBox.BackColor = System.Drawing.Color.Black;
            this.newColorBox.Location = new System.Drawing.Point(132, 182);
            this.newColorBox.Margin = new System.Windows.Forms.Padding(2);
            this.newColorBox.Name = "newColorBox";
            this.newColorBox.Size = new System.Drawing.Size(220, 136);
            this.newColorBox.TabIndex = 1;
            this.newColorBox.TabStop = false;
            // 
            // buttonWinColor
            // 
            this.buttonWinColor.Location = new System.Drawing.Point(172, 332);
            this.buttonWinColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWinColor.Name = "buttonWinColor";
            this.buttonWinColor.Size = new System.Drawing.Size(84, 26);
            this.buttonWinColor.TabIndex = 9;
            this.buttonWinColor.Text = "windows picker";
            this.buttonWinColor.UseVisualStyleBackColor = true;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(363, 375);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonWinColor);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.oldColorBox);
            this.Controls.Add(this.newColorBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(379, 414);
            this.MinimumSize = new System.Drawing.Size(379, 414);
            this.Name = "ColorPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHue)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newColorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox newColorBox;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox oldColorBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar trackBarValue;
        private System.Windows.Forms.TrackBar trackBarSaturation;
        private System.Windows.Forms.TrackBar trackBarHue;
        private System.Windows.Forms.Button buttonWinColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxHexa;
        private System.Windows.Forms.Label labelOldValue;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label rectcolor;
    }
}