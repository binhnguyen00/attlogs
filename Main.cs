using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendanceLog {
  internal class Main {
    private readonly Utils utils = new Utils();
    private bool isConnected;

    private bool checkConnection() {
      if (isConnected) {
        return true;
      } else {
        MessageBox.Show("You are not Connected", "Warning");
        return false;
      }
    }

    public bool ConnectToDeviceViaIPAndPort(string ipAddress, string portNumber) {
      isConnected = utils.Connect(ipAddress, portNumber);
      if (isConnected) {
        return isConnected;
      } else {
        MessageBox.Show("Connection Fail", "Warning");
        return false;
      }
    }

    public bool DisconnectDevice() {
      bool isDisconnected = false;
      if (checkConnection()) {
        isDisconnected = utils.Disconnect();
      }
      if (isDisconnected) isConnected = false;
      return isDisconnected;
    }

    public List<string> DownloadDataFromDevice() {
      if (checkConnection()) {
        return utils.DownloadDataFromDevice();
      }
      return new List<string>();
    }

    public string GetDeviceStatus(string requestStatus) {
      if (checkConnection()) {
        return utils.GetDeviceStatus(requestStatus);
      }
      return "0";
    }
  }
}
