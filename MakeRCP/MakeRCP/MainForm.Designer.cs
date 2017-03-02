namespace MakeRCP
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private System.Windows.Forms.CheckBox cbOnOff;
        private System.Windows.Forms.CheckBox cbBeep;
        private System.Windows.Forms.CheckBox cbVibration;
        private System.Windows.Forms.CheckBox cbLED;
        private System.Windows.Forms.CheckBox cbIllumination;
        private System.Windows.Forms.RadioButton[] rbInformation;
        private System.Windows.Forms.TextBox tbChannel;
        private System.Windows.Forms.TextBox tbOffset;
        private System.Windows.Forms.ComboBox cbPower;





        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.gbCommand = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txResult = new System.Windows.Forms.TextBox();
            this.gbDevice.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbParameters.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDevice
            // 
            this.gbDevice.Controls.Add(this.cbDevice);
            this.gbDevice.Location = new System.Drawing.Point(12, 12);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Size = new System.Drawing.Size(475, 71);
            this.gbDevice.TabIndex = 0;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "Device";
            this.gbDevice.Enter += new System.EventHandler(this.Device_Enter);
            // 
            // cbDevice
            // 
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Items.AddRange(new object[] {
            "ASR-0230D"});
            this.cbDevice.Location = new System.Drawing.Point(6, 29);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(186, 23);
            this.cbDevice.TabIndex = 0;
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.btnSelect);
            this.gbCommand.Controls.Add(this.cbCommand);
            this.gbCommand.Location = new System.Drawing.Point(12, 89);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Size = new System.Drawing.Size(475, 77);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(238, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(103, 33);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbCommand
            // 
            this.cbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "Power On/Off",
            "Get Information",
            "Set Channel",
            "Set TX Power",
            "Get Session"});
            this.cbCommand.Location = new System.Drawing.Point(6, 24);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(186, 23);
            this.cbCommand.TabIndex = 0;
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.btnMake);
            this.gbParameters.Location = new System.Drawing.Point(12, 172);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(475, 327);
            this.gbParameters.TabIndex = 2;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Parameters";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(356, 286);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(113, 35);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txResult);
            this.gbResult.Location = new System.Drawing.Point(12, 505);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(481, 73);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(6, 28);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(469, 25);
            this.txResult.TabIndex = 0;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 590);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbDevice);
            this.Name = "MainForm";
            this.Text = "Make RCP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbDevice.ResumeLayout(false);
            this.gbCommand.ResumeLayout(false);
            this.gbParameters.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.TextBox txResult;
    }
}

