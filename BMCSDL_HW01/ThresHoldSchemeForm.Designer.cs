﻿namespace BMCSDL_HW01
{
    partial class ThresHoldSchemeForm
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
            this.thresHoldBox = new System.Windows.Forms.TextBox();
            this.privateBox = new System.Windows.Forms.TextBox();
            this.calculatedBox = new System.Windows.Forms.TextBox();
            this.providedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.provide = new System.Windows.Forms.Button();
            this.caculate = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.modBox = new System.Windows.Forms.TextBox();
            this.Modulus = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thresHoldBox
            // 
            this.thresHoldBox.Location = new System.Drawing.Point(12, 27);
            this.thresHoldBox.Name = "thresHoldBox";
            this.thresHoldBox.Size = new System.Drawing.Size(104, 20);
            this.thresHoldBox.TabIndex = 0;
            // 
            // privateBox
            // 
            this.privateBox.Location = new System.Drawing.Point(12, 69);
            this.privateBox.Name = "privateBox";
            this.privateBox.Size = new System.Drawing.Size(104, 20);
            this.privateBox.TabIndex = 1;
            // 
            // calculatedBox
            // 
            this.calculatedBox.Location = new System.Drawing.Point(12, 106);
            this.calculatedBox.Name = "calculatedBox";
            this.calculatedBox.Size = new System.Drawing.Size(104, 20);
            this.calculatedBox.TabIndex = 2;
            // 
            // providedList
            // 
            this.providedList.FormattingEnabled = true;
            this.providedList.Location = new System.Drawing.Point(133, 28);
            this.providedList.Name = "providedList";
            this.providedList.Size = new System.Drawing.Size(458, 186);
            this.providedList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Private key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caculated key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Provided keys";
            // 
            // provide
            // 
            this.provide.Location = new System.Drawing.Point(12, 200);
            this.provide.Name = "provide";
            this.provide.Size = new System.Drawing.Size(104, 21);
            this.provide.TabIndex = 8;
            this.provide.Text = "Provide keys";
            this.provide.UseVisualStyleBackColor = true;
            this.provide.Click += new System.EventHandler(this.provide_Click);
            // 
            // caculate
            // 
            this.caculate.Location = new System.Drawing.Point(12, 227);
            this.caculate.Name = "caculate";
            this.caculate.Size = new System.Drawing.Size(104, 21);
            this.caculate.TabIndex = 9;
            this.caculate.Text = "Calculate key";
            this.caculate.UseVisualStyleBackColor = true;
            this.caculate.Click += new System.EventHandler(this.caculate_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(305, 227);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 21);
            this.refresh.TabIndex = 10;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // modBox
            // 
            this.modBox.Location = new System.Drawing.Point(12, 143);
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(104, 20);
            this.modBox.TabIndex = 11;
            // 
            // Modulus
            // 
            this.Modulus.AutoSize = true;
            this.Modulus.Location = new System.Drawing.Point(12, 127);
            this.Modulus.Name = "Modulus";
            this.Modulus.Size = new System.Drawing.Size(47, 13);
            this.Modulus.TabIndex = 12;
            this.Modulus.Text = "Modulus";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(12, 171);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(104, 23);
            this.generate.TabIndex = 13;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // ThresHoldSchemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 260);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.Modulus);
            this.Controls.Add(this.modBox);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.caculate);
            this.Controls.Add(this.provide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.providedList);
            this.Controls.Add(this.calculatedBox);
            this.Controls.Add(this.privateBox);
            this.Controls.Add(this.thresHoldBox);
            this.Name = "ThresHoldSchemeForm";
            this.Text = "ThresHoldSchemeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox thresHoldBox;
        private System.Windows.Forms.TextBox privateBox;
        private System.Windows.Forms.TextBox calculatedBox;
        private System.Windows.Forms.ListBox providedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button provide;
        private System.Windows.Forms.Button caculate;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox modBox;
        private System.Windows.Forms.Label Modulus;
        private System.Windows.Forms.Button generate;
    }
}