namespace AttendanceLog
{
    partial class AttendanceLogForm
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
      this.PortLabel = new System.Windows.Forms.Label();
      this.ipAddressTextBox = new System.Windows.Forms.TextBox();
      this.portTextBox = new System.Windows.Forms.TextBox();
      this.saveToDatatpBtn = new System.Windows.Forms.Button();
      this.findAllLogsBtn = new System.Windows.Forms.Button();
      this.IpAddressLabel = new System.Windows.Forms.Label();
      this.connectToMachineBtn = new System.Windows.Forms.Button();
      this.attLogsTextBox = new System.Windows.Forms.RichTextBox();
      this.AttLogLabel = new System.Windows.Forms.Label();
      this.connectionStateLabel = new System.Windows.Forms.Label();
      this.deviceStatusComboBox = new System.Windows.Forms.ComboBox();
      this.getDeviceStatusBtn = new System.Windows.Forms.Button();
      this.connectToDeviceLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // PortLabel
      // 
      this.PortLabel.AutoSize = true;
      this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PortLabel.Location = new System.Drawing.Point(12, 67);
      this.PortLabel.Name = "PortLabel";
      this.PortLabel.Size = new System.Drawing.Size(26, 13);
      this.PortLabel.TabIndex = 4;
      this.PortLabel.Text = "Port";
      // 
      // ipAddressTextBox
      // 
      this.ipAddressTextBox.Location = new System.Drawing.Point(80, 38);
      this.ipAddressTextBox.Name = "ipAddressTextBox";
      this.ipAddressTextBox.Size = new System.Drawing.Size(112, 20);
      this.ipAddressTextBox.TabIndex = 2;
      this.ipAddressTextBox.Text = "27.72.244.199";
      // 
      // portTextBox
      // 
      this.portTextBox.Location = new System.Drawing.Point(80, 64);
      this.portTextBox.Name = "portTextBox";
      this.portTextBox.Size = new System.Drawing.Size(112, 20);
      this.portTextBox.TabIndex = 5;
      this.portTextBox.Text = "8080";
      // 
      // saveToDatatpBtn
      // 
      this.saveToDatatpBtn.Location = new System.Drawing.Point(867, 646);
      this.saveToDatatpBtn.Name = "saveToDatatpBtn";
      this.saveToDatatpBtn.Size = new System.Drawing.Size(97, 23);
      this.saveToDatatpBtn.TabIndex = 0;
      this.saveToDatatpBtn.Text = "Save to Datatp";
      this.saveToDatatpBtn.UseVisualStyleBackColor = true;
      this.saveToDatatpBtn.Click += new System.EventHandler(this.SaveToDatatp_Click);
      // 
      // findAllLogsBtn
      // 
      this.findAllLogsBtn.Location = new System.Drawing.Point(786, 646);
      this.findAllLogsBtn.Name = "findAllLogsBtn";
      this.findAllLogsBtn.Size = new System.Drawing.Size(75, 23);
      this.findAllLogsBtn.TabIndex = 1;
      this.findAllLogsBtn.Text = "Find All Logs";
      this.findAllLogsBtn.UseVisualStyleBackColor = true;
      this.findAllLogsBtn.Click += new System.EventHandler(this.FindAllLogs_Click);
      // 
      // IpAddressLabel
      // 
      this.IpAddressLabel.AutoSize = true;
      this.IpAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.IpAddressLabel.Location = new System.Drawing.Point(12, 41);
      this.IpAddressLabel.Name = "IpAddressLabel";
      this.IpAddressLabel.Size = new System.Drawing.Size(58, 13);
      this.IpAddressLabel.TabIndex = 3;
      this.IpAddressLabel.Text = "IP Address";
      // 
      // connectToMachineBtn
      // 
      this.connectToMachineBtn.Location = new System.Drawing.Point(117, 90);
      this.connectToMachineBtn.Name = "connectToMachineBtn";
      this.connectToMachineBtn.Size = new System.Drawing.Size(75, 23);
      this.connectToMachineBtn.TabIndex = 6;
      this.connectToMachineBtn.Text = "Connect";
      this.connectToMachineBtn.UseVisualStyleBackColor = true;
      this.connectToMachineBtn.Click += new System.EventHandler(this.ConnectToMachineBtn_Click);
      // 
      // attLogsTextBox
      // 
      this.attLogsTextBox.Location = new System.Drawing.Point(202, 38);
      this.attLogsTextBox.Name = "attLogsTextBox";
      this.attLogsTextBox.ReadOnly = true;
      this.attLogsTextBox.Size = new System.Drawing.Size(762, 601);
      this.attLogsTextBox.TabIndex = 7;
      this.attLogsTextBox.Text = "";
      this.attLogsTextBox.WordWrap = false;
      // 
      // AttLogLabel
      // 
      this.AttLogLabel.AutoSize = true;
      this.AttLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.AttLogLabel.Location = new System.Drawing.Point(198, 12);
      this.AttLogLabel.Name = "AttLogLabel";
      this.AttLogLabel.Size = new System.Drawing.Size(44, 20);
      this.AttLogLabel.TabIndex = 8;
      this.AttLogLabel.Text = "Logs";
      // 
      // connectionStateLabel
      // 
      this.connectionStateLabel.AutoSize = true;
      this.connectionStateLabel.BackColor = System.Drawing.Color.Red;
      this.connectionStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectionStateLabel.Location = new System.Drawing.Point(849, 15);
      this.connectionStateLabel.Name = "connectionStateLabel";
      this.connectionStateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.connectionStateLabel.Size = new System.Drawing.Size(115, 17);
      this.connectionStateLabel.TabIndex = 9;
      this.connectionStateLabel.Text = "Not Connected";
      // 
      // deviceStatusComboBox
      // 
      this.deviceStatusComboBox.FormattingEnabled = true;
      this.deviceStatusComboBox.Items.AddRange(new object[] {
            "2. Users Registered",
            "6. Attendance Records"});
      this.deviceStatusComboBox.Location = new System.Drawing.Point(518, 648);
      this.deviceStatusComboBox.Name = "deviceStatusComboBox";
      this.deviceStatusComboBox.Size = new System.Drawing.Size(154, 21);
      this.deviceStatusComboBox.TabIndex = 10;
      // 
      // getDeviceStatusBtn
      // 
      this.getDeviceStatusBtn.Location = new System.Drawing.Point(678, 646);
      this.getDeviceStatusBtn.Name = "getDeviceStatusBtn";
      this.getDeviceStatusBtn.Size = new System.Drawing.Size(102, 23);
      this.getDeviceStatusBtn.TabIndex = 11;
      this.getDeviceStatusBtn.Text = "Get Device Status";
      this.getDeviceStatusBtn.UseVisualStyleBackColor = true;
      this.getDeviceStatusBtn.Click += new System.EventHandler(this.getDeviceStatusBtn_Click);
      // 
      // connectToDeviceLabel
      // 
      this.connectToDeviceLabel.AutoSize = true;
      this.connectToDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectToDeviceLabel.Location = new System.Drawing.Point(11, 12);
      this.connectToDeviceLabel.Name = "connectToDeviceLabel";
      this.connectToDeviceLabel.Size = new System.Drawing.Size(139, 20);
      this.connectToDeviceLabel.TabIndex = 12;
      this.connectToDeviceLabel.Text = "Connect to Device";
      // 
      // AttendanceLogForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(976, 681);
      this.Controls.Add(this.connectToDeviceLabel);
      this.Controls.Add(this.IpAddressLabel);
      this.Controls.Add(this.PortLabel);
      this.Controls.Add(this.getDeviceStatusBtn);
      this.Controls.Add(this.ipAddressTextBox);
      this.Controls.Add(this.deviceStatusComboBox);
      this.Controls.Add(this.portTextBox);
      this.Controls.Add(this.connectToMachineBtn);
      this.Controls.Add(this.connectionStateLabel);
      this.Controls.Add(this.AttLogLabel);
      this.Controls.Add(this.attLogsTextBox);
      this.Controls.Add(this.findAllLogsBtn);
      this.Controls.Add(this.saveToDatatpBtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "AttendanceLogForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Attendance Log";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label PortLabel;
    private System.Windows.Forms.TextBox ipAddressTextBox;
    private System.Windows.Forms.TextBox portTextBox;
    private System.Windows.Forms.Button saveToDatatpBtn;
    private System.Windows.Forms.Button findAllLogsBtn;
    private System.Windows.Forms.Label IpAddressLabel;
    private System.Windows.Forms.Button connectToMachineBtn;
    private System.Windows.Forms.RichTextBox attLogsTextBox;
    private System.Windows.Forms.Label AttLogLabel;
    private System.Windows.Forms.Label connectionStateLabel;
    private System.Windows.Forms.ComboBox deviceStatusComboBox;
    private System.Windows.Forms.Button getDeviceStatusBtn;
    private System.Windows.Forms.Label connectToDeviceLabel;
  }
}

