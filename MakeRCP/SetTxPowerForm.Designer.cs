namespace MakeRCP
{
    partial class SetTxPowerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPower = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(323, 286);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(122, 45);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "TX Power (dBm : 18.0~25.0) : ";
            // 
            // cbPower
            // 
            this.cbPower.FormattingEnabled = true;
            this.cbPower.Items.AddRange(new object[] {
            "18.0",
            "18.5",
            "19.0",
            "19.5",
            "20.0",
            "20.5",
            "21.0",
            "21.5",
            "22.0",
            "22.5",
            "23.0",
            "23.5",
            "24.0",
            "24.5",
            "25.0"});
            this.cbPower.Location = new System.Drawing.Point(234, 45);
            this.cbPower.Name = "cbPower";
            this.cbPower.Size = new System.Drawing.Size(121, 23);
            this.cbPower.TabIndex = 10;
            // 
            // SetTxPowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 343);
            this.Controls.Add(this.cbPower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMake);
            this.Name = "SetTxPowerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPower;
    }
}