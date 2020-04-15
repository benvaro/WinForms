namespace WF_11_ListBox
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
            this.lbElements = new System.Windows.Forms.ListBox();
            this.lbSelected = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbExtended = new System.Windows.Forms.RadioButton();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cbMultiColumn = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.FormattingEnabled = true;
            this.lbElements.ItemHeight = 16;
            this.lbElements.Location = new System.Drawing.Point(13, 13);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(222, 244);
            this.lbElements.TabIndex = 0;
            this.lbElements.SelectedIndexChanged += new System.EventHandler(this.lbElements_SelectedIndexChanged);
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Location = new System.Drawing.Point(283, 152);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(46, 17);
            this.lbSelected.TabIndex = 4;
            this.lbSelected.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbNew);
            this.groupBox1.Location = new System.Drawing.Point(263, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 120);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новий елемент";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 69);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(23, 32);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(228, 22);
            this.tbNew.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbExtended);
            this.groupBox2.Controls.Add(this.rbSimple);
            this.groupBox2.Controls.Add(this.rbOne);
            this.groupBox2.Location = new System.Drawing.Point(13, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Режим";
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Checked = true;
            this.rbOne.Location = new System.Drawing.Point(7, 22);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(64, 21);
            this.rbOne.TabIndex = 0;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "Один";
            this.rbOne.UseVisualStyleBackColor = true;
            this.rbOne.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(7, 50);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(85, 21);
            this.rbSimple.TabIndex = 1;
            this.rbSimple.Text = "Простий";
            this.rbSimple.UseVisualStyleBackColor = true;
            this.rbSimple.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbExtended
            // 
            this.rbExtended.AutoSize = true;
            this.rbExtended.Location = new System.Drawing.Point(7, 77);
            this.rbExtended.Name = "rbExtended";
            this.rbExtended.Size = new System.Drawing.Size(112, 21);
            this.rbExtended.TabIndex = 2;
            this.rbExtended.Text = "Розширений";
            this.rbExtended.UseVisualStyleBackColor = true;
            this.rbExtended.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(276, 272);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(261, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cbMultiColumn
            // 
            this.cbMultiColumn.AutoSize = true;
            this.cbMultiColumn.Location = new System.Drawing.Point(20, 431);
            this.cbMultiColumn.Name = "cbMultiColumn";
            this.cbMultiColumn.Size = new System.Drawing.Size(133, 21);
            this.cbMultiColumn.TabIndex = 7;
            this.cbMultiColumn.Text = "Багато колонок";
            this.cbMultiColumn.UseVisualStyleBackColor = true;
            this.cbMultiColumn.CheckedChanged += new System.EventHandler(this.cbMultiColumn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 474);
            this.Controls.Add(this.cbMultiColumn);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbExtended;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox cbMultiColumn;
    }
}

