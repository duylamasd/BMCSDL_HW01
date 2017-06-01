namespace BMCSDL_HW01
{
    partial class RSA
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
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decryptedTextBox = new System.Windows.Forms.TextBox();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(154, 140);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(116, 27);
            this.decrypt.TabIndex = 19;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(12, 140);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(121, 27);
            this.encrypt.TabIndex = 18;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Decrypted";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cipher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Plain";
            // 
            // decryptedTextBox
            // 
            this.decryptedTextBox.Location = new System.Drawing.Point(12, 108);
            this.decryptedTextBox.Name = "decryptedTextBox";
            this.decryptedTextBox.Size = new System.Drawing.Size(260, 20);
            this.decryptedTextBox.TabIndex = 14;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Location = new System.Drawing.Point(12, 67);
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(260, 20);
            this.cipherTextBox.TabIndex = 13;
            // 
            // plainTextBox
            // 
            this.plainTextBox.Location = new System.Drawing.Point(12, 26);
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(260, 20);
            this.plainTextBox.TabIndex = 12;
            this.plainTextBox.Text = "Type any thing here for plain text.";
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(15, 179);
            this.publicKeyBox.Multiline = true;
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.Size = new System.Drawing.Size(254, 75);
            this.publicKeyBox.TabIndex = 20;
            this.publicKeyBox.Text = "The public key will be shown here.";
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.publicKeyBox);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptedTextBox);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Name = "RSA";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decryptedTextBox;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.TextBox publicKeyBox;
    }
}