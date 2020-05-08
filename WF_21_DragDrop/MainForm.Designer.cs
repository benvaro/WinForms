namespace WF_21_DragDrop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.ListBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст для перетягування";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результат перетягування";
            // 
            // lbDestination
            // 
            this.lbDestination.AllowDrop = true;
            this.lbDestination.FormattingEnabled = true;
            this.lbDestination.Location = new System.Drawing.Point(185, 63);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(163, 186);
            this.lbDestination.TabIndex = 1;
            this.lbDestination.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbDestination_DragDrop);
            this.lbDestination.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbDestination_DragEnter);
            this.lbDestination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDestination_MouseDown);
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(16, 63);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(152, 20);
            this.tbSource.TabIndex = 2;
            this.tbSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbSource_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(243, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 94);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.lbDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Drag&Drop";
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDestination;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

