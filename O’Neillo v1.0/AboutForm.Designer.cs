namespace O_Neillo_v1._0.Classes
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblONeilloV1 = new System.Windows.Forms.Label();
            this.textBoxAboutONeillo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAboutOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblONeilloV1
            // 
            this.lblONeilloV1.AutoSize = true;
            this.lblONeilloV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblONeilloV1.Location = new System.Drawing.Point(388, 99);
            this.lblONeilloV1.Name = "lblONeilloV1";
            this.lblONeilloV1.Size = new System.Drawing.Size(148, 26);
            this.lblONeilloV1.TabIndex = 0;
            this.lblONeilloV1.Text = "O\'Neillo v1.0";
            // 
            // textBoxAboutONeillo
            // 
            this.textBoxAboutONeillo.Location = new System.Drawing.Point(361, 159);
            this.textBoxAboutONeillo.Multiline = true;
            this.textBoxAboutONeillo.Name = "textBoxAboutONeillo";
            this.textBoxAboutONeillo.ReadOnly = true;
            this.textBoxAboutONeillo.Size = new System.Drawing.Size(216, 202);
            this.textBoxAboutONeillo.TabIndex = 1;
            this.textBoxAboutONeillo.Text = resources.GetString("textBoxAboutONeillo.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAboutOk
            // 
            this.btnAboutOk.Location = new System.Drawing.Point(277, 415);
            this.btnAboutOk.Name = "btnAboutOk";
            this.btnAboutOk.Size = new System.Drawing.Size(75, 23);
            this.btnAboutOk.TabIndex = 3;
            this.btnAboutOk.Text = "OK";
            this.btnAboutOk.UseVisualStyleBackColor = true;
            this.btnAboutOk.Click += new System.EventHandler(this.btnAboutOk_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnAboutOk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxAboutONeillo);
            this.Controls.Add(this.lblONeilloV1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "About Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblONeilloV1;
        private System.Windows.Forms.TextBox textBoxAboutONeillo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAboutOk;
    }
}