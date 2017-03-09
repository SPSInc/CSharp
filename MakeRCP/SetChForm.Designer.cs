namespace MakeRCP
{
    partial class SetChForm
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
            this.tbCh = new System.Windows.Forms.TextBox();
            this.tbOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(323, 286);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(122, 45);
            this.btnMake.TabIndex = 7;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // tbCh
            // 
            this.tbCh.Location = new System.Drawing.Point(238, 52);
            this.tbCh.Name = "tbCh";
            this.tbCh.Size = new System.Drawing.Size(100, 25);
            this.tbCh.TabIndex = 8;
            // 
            // tbOffset
            // 
            this.tbOffset.Location = new System.Drawing.Point(238, 101);
            this.tbOffset.Name = "tbOffset";
            this.tbOffset.Size = new System.Drawing.Size(100, 25);
            this.tbOffset.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Channel Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Offset : ";
            // 
            // SetChForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOffset);
            this.Controls.Add(this.tbCh);
            this.Controls.Add(this.btnMake);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SetChForm";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.SetChForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox tbCh;
        private System.Windows.Forms.TextBox tbOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}