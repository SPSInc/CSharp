namespace MakeRCP
{
    partial class PowerOnOffForm
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
            this.components = new System.ComponentModel.Container();
            this.cbOnOff = new System.Windows.Forms.CheckBox();
            this.cbBeep = new System.Windows.Forms.CheckBox();
            this.cbVibration = new System.Windows.Forms.CheckBox();
            this.cbLED = new System.Windows.Forms.CheckBox();
            this.cbIllumination = new System.Windows.Forms.CheckBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // cbOnOff
            // 
            this.cbOnOff.AutoSize = true;
            this.cbOnOff.Location = new System.Drawing.Point(89, 36);
            this.cbOnOff.Name = "cbOnOff";
            this.cbOnOff.Size = new System.Drawing.Size(85, 19);
            this.cbOnOff.TabIndex = 0;
            this.cbOnOff.Text = "On / Off";
            this.cbOnOff.UseVisualStyleBackColor = true;
            // 
            // cbBeep
            // 
            this.cbBeep.AutoSize = true;
            this.cbBeep.Location = new System.Drawing.Point(254, 36);
            this.cbBeep.Name = "cbBeep";
            this.cbBeep.Size = new System.Drawing.Size(63, 19);
            this.cbBeep.TabIndex = 1;
            this.cbBeep.Text = "Beep";
            this.cbBeep.UseVisualStyleBackColor = true;
            // 
            // cbVibration
            // 
            this.cbVibration.AutoSize = true;
            this.cbVibration.Location = new System.Drawing.Point(89, 90);
            this.cbVibration.Name = "cbVibration";
            this.cbVibration.Size = new System.Drawing.Size(84, 19);
            this.cbVibration.TabIndex = 2;
            this.cbVibration.Text = "Vibration";
            this.cbVibration.UseVisualStyleBackColor = true;
            // 
            // cbLED
            // 
            this.cbLED.AutoSize = true;
            this.cbLED.Location = new System.Drawing.Point(254, 90);
            this.cbLED.Name = "cbLED";
            this.cbLED.Size = new System.Drawing.Size(56, 19);
            this.cbLED.TabIndex = 3;
            this.cbLED.Text = "LED";
            this.cbLED.UseVisualStyleBackColor = true;
            // 
            // cbIllumination
            // 
            this.cbIllumination.AutoSize = true;
            this.cbIllumination.Location = new System.Drawing.Point(89, 141);
            this.cbIllumination.Name = "cbIllumination";
            this.cbIllumination.Size = new System.Drawing.Size(100, 19);
            this.cbIllumination.TabIndex = 4;
            this.cbIllumination.Text = "Illumination";
            this.cbIllumination.UseVisualStyleBackColor = true;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(323, 286);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(122, 45);
            this.btnMake.TabIndex = 5;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 25);
            this.textBox1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PowerOnOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(457, 343);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.cbIllumination);
            this.Controls.Add(this.cbLED);
            this.Controls.Add(this.cbVibration);
            this.Controls.Add(this.cbBeep);
            this.Controls.Add(this.cbOnOff);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PowerOnOffForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PowerOnOffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOnOff;
        private System.Windows.Forms.CheckBox cbBeep;
        private System.Windows.Forms.CheckBox cbVibration;
        private System.Windows.Forms.CheckBox cbLED;
        private System.Windows.Forms.CheckBox cbIllumination;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}