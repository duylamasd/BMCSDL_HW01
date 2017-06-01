namespace BMCSDL_HW01
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
            this.AES = new System.Windows.Forms.Button();
            this.RSA = new System.Windows.Forms.Button();
            this.thresHold = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AES
            // 
            this.AES.Location = new System.Drawing.Point(80, 44);
            this.AES.Name = "AES";
            this.AES.Size = new System.Drawing.Size(75, 23);
            this.AES.TabIndex = 0;
            this.AES.Text = "AES";
            this.AES.UseVisualStyleBackColor = true;
            this.AES.Click += new System.EventHandler(this.AES_Click);
            // 
            // RSA
            // 
            this.RSA.Location = new System.Drawing.Point(80, 90);
            this.RSA.Name = "RSA";
            this.RSA.Size = new System.Drawing.Size(75, 23);
            this.RSA.TabIndex = 1;
            this.RSA.Text = "RSA";
            this.RSA.UseVisualStyleBackColor = true;
            this.RSA.Click += new System.EventHandler(this.RSA_Click);
            // 
            // thresHold
            // 
            this.thresHold.Location = new System.Drawing.Point(80, 142);
            this.thresHold.Name = "thresHold";
            this.thresHold.Size = new System.Drawing.Size(75, 23);
            this.thresHold.TabIndex = 2;
            this.thresHold.Text = "Threshold";
            this.thresHold.UseVisualStyleBackColor = true;
            this.thresHold.Click += new System.EventHandler(this.thresHold_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 219);
            this.Controls.Add(this.thresHold);
            this.Controls.Add(this.RSA);
            this.Controls.Add(this.AES);
            this.Name = "MainForm";
            this.Text = "CryptoProtocol";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AES;
        private System.Windows.Forms.Button RSA;
        private System.Windows.Forms.Button thresHold;
    }
}

