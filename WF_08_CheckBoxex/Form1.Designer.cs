namespace WF_08_CheckBoxex
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.checkBoxAgree = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 50);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Maybe yes";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox2.Location = new System.Drawing.Point(12, 116);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 49);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Yes";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox3.Location = new System.Drawing.Point(12, 215);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(152, 49);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "No";
            this.checkBox3.ThreeState = true;
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.Location = new System.Drawing.Point(156, 304);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(215, 45);
            this.btn.TabIndex = 1;
            this.btn.Text = "Click";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(216, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(46, 17);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "label1";
            // 
            // checkBoxAgree
            // 
            this.checkBoxAgree.AutoSize = true;
            this.checkBoxAgree.Location = new System.Drawing.Point(140, 277);
            this.checkBoxAgree.Name = "checkBoxAgree";
            this.checkBoxAgree.Size = new System.Drawing.Size(95, 21);
            this.checkBoxAgree.TabIndex = 3;
            this.checkBoxAgree.Text = "Check me!";
            this.checkBoxAgree.UseVisualStyleBackColor = true;
            this.checkBoxAgree.CheckedChanged += new System.EventHandler(this.checkBoxAgree_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxAgree);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox checkBoxAgree;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

