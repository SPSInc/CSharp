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
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.txResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDevice.SuspendLayout();
            this.gbCommand.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDevice
            // 
            this.gbDevice.Controls.Add(this.cbDevice);
            this.gbDevice.Location = new System.Drawing.Point(11, 12);
            this.gbDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cbDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(186, 23);
            this.cbDevice.TabIndex = 0;
            // 
            // gbCommand
            // 
            this.gbCommand.Controls.Add(this.cbCommand);
            this.gbCommand.Location = new System.Drawing.Point(11, 89);
            this.gbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCommand.Name = "gbCommand";
            this.gbCommand.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCommand.Size = new System.Drawing.Size(475, 78);
            this.gbCommand.TabIndex = 1;
            this.gbCommand.TabStop = false;
            this.gbCommand.Text = "Command";
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
            this.cbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(186, 23);
            this.cbCommand.TabIndex = 0;
            this.cbCommand.SelectedIndexChanged += new System.EventHandler(this.SelectChangeCommand);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.txResult);
            this.gbResult.Location = new System.Drawing.Point(11, 530);
            this.gbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbResult.Size = new System.Drawing.Size(481, 72);
            this.gbResult.TabIndex = 3;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Result";
            // 
            // txResult
            // 
            this.txResult.Location = new System.Drawing.Point(6, 28);
            this.txResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txResult.Name = "txResult";
            this.txResult.Size = new System.Drawing.Size(469, 25);
            this.txResult.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(11, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 351);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbCommand);
            this.Controls.Add(this.gbDevice);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Make RCP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbDevice.ResumeLayout(false);
            this.gbCommand.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.GroupBox gbCommand;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.TextBox txResult;
        private System.Windows.Forms.Panel panel1;
    }
}

