namespace WF_12_ComboBox
{
    partial class Form1
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
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chlbType = new System.Windows.Forms.CheckedListBox();
            this.lbManufacturer = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.AllowDrop = true;
            this.cbColor.DropDownHeight = 200;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.IntegralHeight = false;
            this.cbColor.Location = new System.Drawing.Point(12, 74);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(216, 24);
            this.cbColor.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbColor, "Оберіть колір");
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColor.Location = new System.Drawing.Point(13, 13);
            this.lblColor.Name = "lblColor";
            this.lblColor.Padding = new System.Windows.Forms.Padding(10);
            this.lblColor.Size = new System.Drawing.Size(215, 43);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            this.toolTip1.SetToolTip(this.lblColor, "Зразок кольору");
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Підказка";
            // 
            // chlbType
            // 
            this.chlbType.CheckOnClick = true;
            this.chlbType.FormattingEnabled = true;
            this.chlbType.Location = new System.Drawing.Point(12, 153);
            this.chlbType.Name = "chlbType";
            this.chlbType.Size = new System.Drawing.Size(216, 123);
            this.chlbType.TabIndex = 2;
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.FormattingEnabled = true;
            this.lbManufacturer.ItemHeight = 16;
            this.lbManufacturer.Location = new System.Drawing.Point(275, 13);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(258, 116);
            this.lbManufacturer.TabIndex = 3;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(44, 303);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(155, 36);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Обрати";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(44, 357);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 37);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 16;
            this.lbResult.Location = new System.Drawing.Point(275, 153);
            this.lbResult.Name = "lbResult";
            this.lbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbResult.Size = new System.Drawing.Size(508, 276);
            this.lbResult.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(611, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 452);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.chlbType);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cbColor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckedListBox chlbType;
        private System.Windows.Forms.ListBox lbManufacturer;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

