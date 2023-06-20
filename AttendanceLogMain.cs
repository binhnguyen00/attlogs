using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datatp;

namespace AttendanceLog {
  internal class AttendanceLogMain {
    private readonly Utils utils = new Utils();
    private bool isConnected;
    private bool isLogin;
    private string accessToken = "";

    // Attendance log Device
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

    // Datatp
    private bool checkLoginToDatatp() {
      if (isLogin) {
        return true;
      } else {
        MessageBox.Show("You are not Authorized", "Warning");
        return false;
      }
    }

    public bool LoginToDatatp(string loginId, string password, string company = "", string baseRestUrl = null) {
      DatatpHttpClient client;
      if (baseRestUrl != null) {
        client = new DatatpHttpClient(baseRestUrl);
      } else {
        client = new DatatpHttpClient("http://localhost:7080/");
      }
      string accessToken = utils.LoginToDatatp(client, loginId, password, company);
      if (accessToken.ToString() != "Null" || accessToken.ToString() != null) {
        isLogin = true;
        this.accessToken = accessToken;
      } else isLogin = false;
      return isLogin;
    }

    public bool LogoutFromDatatp() {
      isLogin = false;
      return true;
    }

    public void SaveAttLogsToDatatpTimeTrackings(string baseRestUrl = null) {
      if (!checkConnection()) {
        return;
      }
      if (checkLoginToDatatp()) {
        DatatpHttpClient client;
        if (baseRestUrl != null) {
          client = new DatatpHttpClient(baseRestUrl);
          client.accessToken = this.accessToken;
        } else {
          client = new DatatpHttpClient("http://localhost:7080/");
          client.accessToken = this.accessToken;
        }
        utils.SaveAttLogsToDatatpTimeTrackings(client);
      }
    }
  }
}
