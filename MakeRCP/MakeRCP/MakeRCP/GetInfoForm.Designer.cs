﻿namespace MakeRCP
{
    partial class GetInfoForm
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
            this.btnMake = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.BackColor = System.Drawing.SystemColors.Control;
            this.btnMake.Location = new System.Drawing.Point(323, 286);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(122, 45);
            this.btnMake.TabIndex = 6;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = false;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(230, 25);
            this.textBox1.TabIndex = 7;
            // 
            // GetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(457, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMake);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GetInfoForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GetInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox textBox1;
    }
}