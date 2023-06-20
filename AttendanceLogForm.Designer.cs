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
      this.connectToDeviceBtn = new System.Windows.Forms.Button();
      this.attLogsTextBox = new System.Windows.Forms.RichTextBox();
      this.AttLogLabel = new System.Windows.Forms.Label();
      this.connectionStateLabel = new System.Windows.Forms.Label();
      this.deviceStatusComboBox = new System.Windows.Forms.ComboBox();
      this.getDeviceStatusBtn = new System.Windows.Forms.Button();
      this.connectToDeviceLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.datatpLoginIdLabel = new System.Windows.Forms.Label();
      this.datatpPasswordLabel = new System.Windows.Forms.Label();
      this.datatpLoginIdTextBox = new System.Windows.Forms.TextBox();
      this.datatpPasswordTextBox = new System.Windows.Forms.TextBox();
      this.connectToDatatpBtn = new System.Windows.Forms.Button();
      this.connectionStateToDatatpLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // PortLabel
      // 
      this.PortLabel.AutoSize = true;
      this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.PortLabel.Location = new System.Drawing.Point(6, 67);
      this.PortLabel.Name = "PortLabel";
      this.PortLabel.Size = new System.Drawing.Size(26, 13);
      this.PortLabel.TabIndex = 4;
      this.PortLabel.Text = "Port";
      // 
      // ipAddressTextBox
      // 
      this.ipAddressTextBox.Location = new System.Drawing.Point(74, 38);
      this.ipAddressTextBox.Name = "ipAddressTextBox";
      this.ipAddressTextBox.Size = new System.Drawing.Size(116, 20);
      this.ipAddressTextBox.TabIndex = 2;
      this.ipAddressTextBox.Text = "27.72.244.199";
      // 
      // portTextBox
      // 
      this.portTextBox.Location = new System.Drawing.Point(74, 64);
      this.portTextBox.Name = "portTextBox";
      this.portTextBox.Size = new System.Drawing.Size(116, 20);
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
      this.IpAddressLabel.Location = new System.Drawing.Point(6, 41);
      this.IpAddressLabel.Name = "IpAddressLabel";
      this.IpAddressLabel.Size = new System.Drawing.Size(58, 13);
      this.IpAddressLabel.TabIndex = 3;
      this.IpAddressLabel.Text = "IP Address";
      // 
      // connectToDeviceBtn
      // 
      this.connectToDeviceBtn.Location = new System.Drawing.Point(117, 90);
      this.connectToDeviceBtn.Name = "connectToDeviceBtn";
      this.connectToDeviceBtn.Size = new System.Drawing.Size(75, 23);
      this.connectToDeviceBtn.TabIndex = 6;
      this.connectToDeviceBtn.Text = "Connect";
      this.connectToDeviceBtn.UseVisualStyleBackColor = true;
      this.connectToDeviceBtn.Click += new System.EventHandler(this.ConnectToDeviceBtn_Click);
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
      this.connectionStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectionStateLabel.Location = new System.Drawing.Point(8, 93);
      this.connectionStateLabel.Name = "connectionStateLabel";
      this.connectionStateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.connectionStateLabel.Size = new System.Drawing.Size(101, 15);
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
      this.getDeviceStatusBtn.Click += new System.EventHandler(this.GetDeviceStatusBtn_Click);
      // 
      // connectToDeviceLabel
      // 
      this.connectToDeviceLabel.AutoSize = true;
      this.connectToDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectToDeviceLabel.Location = new System.Drawing.Point(5, 12);
      this.connectToDeviceLabel.Name = "connectToDeviceLabel";
      this.connectToDeviceLabel.Size = new System.Drawing.Size(139, 20);
      this.connectToDeviceLabel.TabIndex = 12;
      this.connectToDeviceLabel.Text = "Connect to Device";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(4, 127);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 20);
      this.label1.TabIndex = 13;
      this.label1.Text = "Connect to Datatp";
      // 
      // datatpLoginIdLabel
      // 
      this.datatpLoginIdLabel.AutoSize = true;
      this.datatpLoginIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.datatpLoginIdLabel.Location = new System.Drawing.Point(5, 160);
      this.datatpLoginIdLabel.Name = "datatpLoginIdLabel";
      this.datatpLoginIdLabel.Size = new System.Drawing.Size(45, 13);
      this.datatpLoginIdLabel.TabIndex = 14;
      this.datatpLoginIdLabel.Text = "Login Id";
      // 
      // datatpPasswordLabel
      // 
      this.datatpPasswordLabel.AutoSize = true;
      this.datatpPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.datatpPasswordLabel.Location = new System.Drawing.Point(5, 186);
      this.datatpPasswordLabel.Name = "datatpPasswordLabel";
      this.datatpPasswordLabel.Size = new System.Drawing.Size(53, 13);
      this.datatpPasswordLabel.TabIndex = 15;
      this.datatpPasswordLabel.Text = "Password";
      // 
      // datatpLoginIdTextBox
      // 
      this.datatpLoginIdTextBox.Location = new System.Drawing.Point(72, 160);
      this.datatpLoginIdTextBox.Name = "datatpLoginIdTextBox";
      this.datatpLoginIdTextBox.Size = new System.Drawing.Size(118, 20);
      this.datatpLoginIdTextBox.TabIndex = 16;
      this.datatpLoginIdTextBox.Text = "admin";
      // 
      // datatpPasswordTextBox
      // 
      this.datatpPasswordTextBox.Location = new System.Drawing.Point(72, 186);
      this.datatpPasswordTextBox.Name = "datatpPasswordTextBox";
      this.datatpPasswordTextBox.Size = new System.Drawing.Size(118, 20);
      this.datatpPasswordTextBox.TabIndex = 17;
      this.datatpPasswordTextBox.Text = "admin";
      this.datatpPasswordTextBox.UseSystemPasswordChar = true;
      // 
      // connectToDatatpBtn
      // 
      this.connectToDatatpBtn.Location = new System.Drawing.Point(115, 214);
      this.connectToDatatpBtn.Name = "connectToDatatpBtn";
      this.connectToDatatpBtn.Size = new System.Drawing.Size(75, 23);
      this.connectToDatatpBtn.TabIndex = 18;
      this.connectToDatatpBtn.Text = "Login";
      this.connectToDatatpBtn.UseVisualStyleBackColor = true;
      this.connectToDatatpBtn.Click += new System.EventHandler(this.ConnectToDatatpBtn_Click);
      // 
      // connectionStateToDatatpLabel
      // 
      this.connectionStateToDatatpLabel.AutoSize = true;
      this.connectionStateToDatatpLabel.BackColor = System.Drawing.Color.Red;
      this.connectionStateToDatatpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectionStateToDatatpLabel.Location = new System.Drawing.Point(8, 217);
      this.connectionStateToDatatpLabel.Name = "connectionStateToDatatpLabel";
      this.connectionStateToDatatpLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.connectionStateToDatatpLabel.Size = new System.Drawing.Size(69, 15);
      this.connectionStateToDatatpLabel.TabIndex = 19;
      this.connectionStateToDatatpLabel.Text = "Not Login";
      // 
      // AttendanceLogForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(976, 681);
      this.Controls.Add(this.connectionStateToDatatpLabel);
      this.Controls.Add(this.datatpLoginIdTextBox);
      this.Controls.Add(this.datatpPasswordTextBox);
      this.Controls.Add(this.connectToDatatpBtn);
      this.Controls.Add(this.datatpLoginIdLabel);
      this.Controls.Add(this.datatpPasswordLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.connectToDeviceLabel);
      this.Controls.Add(this.IpAddressLabel);
      this.Controls.Add(this.PortLabel);
      this.Controls.Add(this.getDeviceStatusBtn);
      this.Controls.Add(this.ipAddressTextBox);
      this.Controls.Add(this.deviceStatusComboBox);
      this.Controls.Add(this.portTextBox);
      this.Controls.Add(this.connectToDeviceBtn);
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
    private System.Windows.Forms.Button connectToDeviceBtn;
    private System.Windows.Forms.RichTextBox attLogsTextBox;
    private System.Windows.Forms.Label AttLogLabel;
    private System.Windows.Forms.Label connectionStateLabel;
    private System.Windows.Forms.ComboBox deviceStatusComboBox;
    private System.Windows.Forms.Button getDeviceStatusBtn;
    private System.Windows.Forms.Label connectToDeviceLabel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label datatpLoginIdLabel;
    private System.Windows.Forms.Label datatpPasswordLabel;
    private System.Windows.Forms.TextBox datatpLoginIdTextBox;
    private System.Windows.Forms.TextBox datatpPasswordTextBox;
    private System.Windows.Forms.Button connectToDatatpBtn;
    private System.Windows.Forms.Label connectionStateToDatatpLabel;
  }
}

