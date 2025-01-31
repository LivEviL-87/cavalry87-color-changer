namespace Cavalry87_Color_Changer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelCurColor = new System.Windows.Forms.Label();
            this.numericLight = new System.Windows.Forms.NumericUpDown();
            this.LightLabel = new System.Windows.Forms.Label();
            this.Redlabel = new System.Windows.Forms.Label();
            this.Greenlabel = new System.Windows.Forms.Label();
            this.Bluelabel = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.LabelHowTo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnApply = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinkLabelLanguage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericLight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 173);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // LabelCurColor
            // 
            this.LabelCurColor.AutoSize = true;
            this.LabelCurColor.Location = new System.Drawing.Point(60, 7);
            this.LabelCurColor.Name = "LabelCurColor";
            this.LabelCurColor.Size = new System.Drawing.Size(78, 13);
            this.LabelCurColor.TabIndex = 3;
            this.LabelCurColor.Text = "Текущий цвет";
            this.LabelCurColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericLight
            // 
            this.numericLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericLight.Location = new System.Drawing.Point(263, 105);
            this.numericLight.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericLight.Name = "numericLight";
            this.numericLight.Size = new System.Drawing.Size(35, 20);
            this.numericLight.TabIndex = 4;
            this.numericLight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericLight.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // LightLabel
            // 
            this.LightLabel.AutoSize = true;
            this.LightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LightLabel.Location = new System.Drawing.Point(196, 105);
            this.LightLabel.Name = "LightLabel";
            this.LightLabel.Size = new System.Drawing.Size(61, 16);
            this.LightLabel.TabIndex = 5;
            this.LightLabel.Text = "Яркость";
            // 
            // Redlabel
            // 
            this.Redlabel.AutoSize = true;
            this.Redlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Redlabel.ForeColor = System.Drawing.Color.Firebrick;
            this.Redlabel.Location = new System.Drawing.Point(196, 28);
            this.Redlabel.Name = "Redlabel";
            this.Redlabel.Size = new System.Drawing.Size(33, 16);
            this.Redlabel.TabIndex = 6;
            this.Redlabel.Text = "Red";
            // 
            // Greenlabel
            // 
            this.Greenlabel.AutoSize = true;
            this.Greenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Greenlabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.Greenlabel.Location = new System.Drawing.Point(196, 53);
            this.Greenlabel.Name = "Greenlabel";
            this.Greenlabel.Size = new System.Drawing.Size(44, 16);
            this.Greenlabel.TabIndex = 7;
            this.Greenlabel.Text = "Green";
            // 
            // Bluelabel
            // 
            this.Bluelabel.AutoSize = true;
            this.Bluelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bluelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Bluelabel.Location = new System.Drawing.Point(196, 79);
            this.Bluelabel.Name = "Bluelabel";
            this.Bluelabel.Size = new System.Drawing.Size(34, 16);
            this.Bluelabel.TabIndex = 8;
            this.Bluelabel.Text = "Blue";
            // 
            // textBoxRed
            // 
            this.textBoxRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRed.Location = new System.Drawing.Point(263, 27);
            this.textBoxRed.MaxLength = 3;
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(35, 20);
            this.textBoxRed.TabIndex = 9;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGreen.Location = new System.Drawing.Point(263, 53);
            this.textBoxGreen.MaxLength = 3;
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(35, 20);
            this.textBoxGreen.TabIndex = 10;
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBlue.Location = new System.Drawing.Point(263, 79);
            this.textBoxBlue.MaxLength = 3;
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(35, 20);
            this.textBoxBlue.TabIndex = 11;
            // 
            // LabelHowTo
            // 
            this.LabelHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHowTo.Location = new System.Drawing.Point(6, 7);
            this.LabelHowTo.Name = "LabelHowTo";
            this.LabelHowTo.Size = new System.Drawing.Size(146, 93);
            this.LabelHowTo.TabIndex = 12;
            this.LabelHowTo.Text = "Значения RGB цветов устанавливаются в диапазоне от 0 до 255\r\n\r\nПри яркости равной" +
    " 0 подсветка выключена";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelHowTo);
            this.groupBox1.Location = new System.Drawing.Point(308, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JSON (*.json)|*.json|All Files (*.*)|*.*";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(373, 9);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 2;
            this.BtnApply.Text = "Применить";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.BackColor = System.Drawing.SystemColors.Control;
            this.labelFileName.Location = new System.Drawing.Point(4, 9);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(282, 23);
            this.labelFileName.TabIndex = 15;
            this.labelFileName.Text = "Файл:  не выбран";
            this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(292, 9);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenFile.TabIndex = 14;
            this.BtnOpenFile.Text = "Выбрать";
            this.BtnOpenFile.UseVisualStyleBackColor = true;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.BtnOpenFile);
            this.groupBox2.Controls.Add(this.labelFileName);
            this.groupBox2.Controls.Add(this.BtnApply);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 36);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // LinkLabelLanguage
            // 
            this.LinkLabelLanguage.AutoSize = true;
            this.LinkLabelLanguage.LinkColor = System.Drawing.Color.MediumBlue;
            this.LinkLabelLanguage.Location = new System.Drawing.Point(440, 7);
            this.LinkLabelLanguage.Name = "LinkLabelLanguage";
            this.LinkLabelLanguage.Size = new System.Drawing.Size(26, 13);
            this.LinkLabelLanguage.TabIndex = 17;
            this.LinkLabelLanguage.TabStop = true;
            this.LinkLabelLanguage.Text = "Eng";
            this.LinkLabelLanguage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLanguage_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(478, 238);
            this.Controls.Add(this.LinkLabelLanguage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.Bluelabel);
            this.Controls.Add(this.Greenlabel);
            this.Controls.Add(this.Redlabel);
            this.Controls.Add(this.LightLabel);
            this.Controls.Add(this.numericLight);
            this.Controls.Add(this.LabelCurColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAVALRY87 Color Changer";
            ((System.ComponentModel.ISupportInitialize)(this.numericLight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelCurColor;
        private System.Windows.Forms.NumericUpDown numericLight;
        private System.Windows.Forms.Label LightLabel;
        private System.Windows.Forms.Label Redlabel;
        private System.Windows.Forms.Label Greenlabel;
        private System.Windows.Forms.Label Bluelabel;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label LabelHowTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LinkLabelLanguage;
    }
}