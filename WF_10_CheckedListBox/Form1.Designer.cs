namespace WF_10_CheckedListBox
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
            this.clbExample = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbExample
            // 
            this.clbExample.CheckOnClick = true;
            this.clbExample.FormattingEnabled = true;
            this.clbExample.Items.AddRange(new object[] {
            "five",
            "four",
            "one",
            "three",
            "two"});
            this.clbExample.Location = new System.Drawing.Point(40, 23);
            this.clbExample.Name = "clbExample";
            this.clbExample.Size = new System.Drawing.Size(247, 208);
            this.clbExample.Sorted = true;
            this.clbExample.TabIndex = 0;
            this.clbExample.SelectedIndexChanged += new System.EventHandler(this.clbExample_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbNew);
            this.groupBox1.Location = new System.Drawing.Point(386, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новий елемент";
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(7, 38);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(350, 22);
            this.tbNew.TabIndex = 0;
            this.tbNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNew_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Location = new System.Drawing.Point(386, 166);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(46, 17);
            this.lbSelected.TabIndex = 2;
            this.lbSelected.Text = "label1";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(40, 253);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(247, 33);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Видалити";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(526, 277);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(226, 22);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Visible = false;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 253);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 47);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search & Remove";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 311);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clbExample);
            this.Name = "Form1";
            this.Text = "Checked List Box";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbExample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

