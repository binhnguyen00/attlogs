using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendanceLog {
  public partial class AttendanceLogForm : Form {
    private readonly AttendanceLogMain main = new AttendanceLogMain();

    public AttendanceLogForm() {
      InitializeComponent();
      attLogsTextBox.Text = 
        "Index\t" +
        "Enroll Number\t\t" +
        "TMachineNumber\t" +
        "EMachineNumber\t" +
        "Verify Mode\t" +
        "In Out Mode\t" +
        "Date Time";
    }

    private void SaveToDatatp_Click(object sender, EventArgs e) {
      main.SaveAttLogsToDatatpTimeTrackings();
    }

    private void FindAllLogs_Click(object sender, EventArgs e) {
      attLogsTextBox.Text = 
        "Index\t" +
        "Enroll Number\t\t" +
        "Verify Mode\t" +
        "In Out Mode\t" +
        "Work Code\t" +
        "Date Time";
      List<string> records = main.DownloadDataFromDevice();
      foreach (string record in records) {
        attLogsTextBox.Text += "\n" + record;
      }
    }

    private void ConnectToDeviceBtn_Click(object sender, EventArgs e) {
      if (connectToDeviceBtn.Text == "Disconnect") {
        main.DisconnectDevice();
        connectToDeviceBtn.Text = "Connect";
        connectionStateLabel.Text = "Not Connected";
        connectionStateLabel.BackColor=Color.Red;
        return;
      }
      bool isConnected;
      string ipAddress = ipAddressTextBox.Text;
      string port = portTextBox.Text;
      isConnected = main.ConnectToDeviceViaIPAndPort(ipAddress, port);
      if (isConnected) {
        connectToDeviceBtn.Text = "Disconnect";
        connectionStateLabel.Text = "Connected";
        connectionStateLabel.BackColor = Color.LightGreen;
        return;
      } 
    }

    private void GetDeviceStatusBtn_Click(object sender, EventArgs e) {
      string requestStatus = deviceStatusComboBox.Text;
      string resultFromDevice = main.GetDeviceStatus(requestStatus);
      if (!"0".Equals(resultFromDevice)) {
        MessageBox.Show(resultFromDevice, requestStatus);
      }
    }

    private void ConnectToDatatpBtn_Click(object sender, EventArgs e) {
      if (connectToDatatpBtn.Text == "Sign Out") {
        main.LogoutFromDatatp();
        connectToDatatpBtn.Text = "Sign In";
        connectionStateToDatatpLabel.Text = "Signed Out";
        connectionStateToDatatpLabel.BackColor = Color.Red;
        return;
      }
      bool isLogin;
      string loginId = datatpLoginIdTextBox.Text;
      string password = datatpPasswordTextBox.Text;
      isLogin = main.LoginToDatatp(loginId, password);
      if (isLogin) {
        connectToDatatpBtn.Text = "Sign Out";
        connectionStateToDatatpLabel.Text = "Signed In";
        connectionStateToDatatpLabel.BackColor = Color.LightGreen;
      }
    }
  }
}                                           