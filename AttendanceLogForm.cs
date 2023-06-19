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
      main.TestGetFromDatatp();
    }

    private void FindAllLogs_Click(object sender, EventArgs e) {
      attLogsTextBox.Text = 
        "Index\t" +
        "Enroll Number\t\t" +
        "TMachineNumber\t" +
        "EMachineNumber\t" +
        "Verify Mode\t" +
        "In Out Mode\t" +
        "Date Time";
      List<string> records = main.DownloadDataFromDevice();
      foreach (string record in records) {
        attLogsTextBox.Text += "\n" + record;
      }
    }

    private void ConnectToMachineBtn_Click(object sender, EventArgs e) {
      if (connectToMachineBtn.Text=="Disconnect") {
        main.DisconnectDevice();
        connectToMachineBtn.Text="Connect";
        connectionStateLabel.Text="Not Connected";
        connectionStateLabel.BackColor=Color.Red;
        return;
      }
      bool isConnected;
      string ipAddress = ipAddressTextBox.Text;
      string port = portTextBox.Text;
      isConnected = main.ConnectToDeviceViaIPAndPort(ipAddress, port);
      if (isConnected) {
        connectToMachineBtn.Text="Disconnect";
        connectionStateLabel.Text="Connected";
        connectionStateLabel.BackColor=Color.LightGreen;
        return;
      } 
    }

    private void getDeviceStatusBtn_Click(object sender, EventArgs e) {
      string requestStatus = deviceStatusComboBox.Text;
      string resultFromDevice = main.GetDeviceStatus(requestStatus);
      if (!"0".Equals(resultFromDevice)) {
        MessageBox.Show(resultFromDevice, requestStatus);
      }
    }
  }
}                                           