using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using datatp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/* Function usages
  1. ReadGeneralLogData: Read Attendance records and Write them into the internal buffer of the PC. return true | false
  2. SSR_GetGeneralLogData: Read Attendance records one by one from the internal buffer.
*/

/* iMachineNumber 
  In fact, when you are using the tcp/ip communication, this parameter will be ignored, 
  that is any integer will all right. Here we use 1 
*/

namespace AttendanceLog {
  public class Utils {
    private zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

    private bool CheckValidUserInput(string ipAddress, string port) {
      if ("".Equals(ipAddress.Trim()) || "".Equals(port.Trim())) {
        MessageBox.Show("IP or Port must be filled", "Warning");
        return false;
      }
      return true;
    }

    public bool Connect(string ipAddress, string port) {
      bool isValidInPut = CheckValidUserInput(ipAddress, port);
      bool isConnected = false;
      if (isValidInPut) {
        isConnected = axCZKEM1.Connect_Net(ipAddress, Convert.ToInt32(port));
        if (isConnected) {
          int iMachineNumber = 1;
          axCZKEM1.RegEvent(iMachineNumber, 65535); // 65535 means registering all 
        }
      }
      return isConnected;
    }

    public bool Disconnect() {
      axCZKEM1.Disconnect();
      return true;
    }

    public List<string> DownloadDataFromDevice() {
      string sdwEnrollNumber = "";
      int idwVerifyMode = 0;
      int idwInOutMode = 0;
      int idwYear = 0;
      int idwMonth = 0;
      int idwDay = 0;
      int idwHour = 0;
      int idwMinute = 0;
      int idwSecond = 0;
      int idwWorkcode = 0;

      int index = 0;
      int idwErrorCode = 0;

      List<string> records = new List<string>();
      int iMachineNumber = 1;
      //axCZKEM1.EnableDevice(iMachineNumber, false); // Disable the device

      bool readAble = axCZKEM1.ReadGeneralLogData(iMachineNumber);
      if (readAble) {
        while (axCZKEM1.SSR_GetGeneralLogData(
          iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
          out idwInOutMode, out idwYear, out idwMonth, out idwDay,
          out idwHour, out idwMinute, out idwSecond, ref idwWorkcode
        )) {
          index += 1;
          string date = idwDay + "/" + idwMonth + "/" + idwYear + "@" + idwHour + ":" + idwMinute + ":" + idwSecond;
          records.Add(
            index + "\t" + sdwEnrollNumber + "\t\t" + idwVerifyMode + "\t\t" + idwInOutMode +
            "\t\t" + idwWorkcode +
            "\t\t" + date
          );
        }
      } else {
        axCZKEM1.GetLastError(ref idwErrorCode);
        if (idwErrorCode != 0) {
          MessageBox.Show("Can't Read data from Device\n ErrorCode: " + idwErrorCode.ToString(), "Error");
        } else {
          MessageBox.Show("The Machine return 0 Log\n ErrorCode: " + idwErrorCode.ToString(), "Error");
        }
      }

      //axCZKEM1.EnableDevice(iMachineNumber, true); // Enable the device
      return records;
    }

    public string DownloadDataFromDeviceAsJson() {
      string sdwEnrollNumber = "";
      int idwVerifyMode = 0;
      int idwInOutMode = 0;
      int idwYear = 0;
      int idwMonth = 0;
      int idwDay = 0;
      int idwHour = 0;
      int idwMinute = 0;
      int idwSecond = 0;
      int idwWorkcode = 0;
      int index = 0;
      int iMachineNumber = 1;

      Dictionary<int, Dictionary<string, string>> resultMap = new Dictionary<int, Dictionary<string, string>>();
      bool readAble = axCZKEM1.ReadGeneralLogData(iMachineNumber);

      if (readAble) {
        while (axCZKEM1.SSR_GetGeneralLogData(
          iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
          out idwInOutMode, out idwYear, out idwMonth, out idwDay,
          out idwHour, out idwMinute, out idwSecond, ref idwWorkcode
        )) {
          index += 1;
          string date = idwDay + "/" + idwMonth + "/" + idwYear + "@" + idwHour + ":" + idwMinute + ":" + idwSecond;
          Dictionary<string, string> responseMap = new Dictionary<string, string> {
            { "time", date },
            { "employeeCardId", sdwEnrollNumber },
            { "scannerMachineId", "" + iMachineNumber },
          };
          resultMap.Add(index, responseMap);
        }
      } else {
        int idwErrorCode = 0;
        axCZKEM1.GetLastError(ref idwErrorCode);
        if (idwErrorCode != 0) {
          MessageBox.Show("Can't Read data from Device\n ErrorCode: " + idwErrorCode.ToString(), "Error");
        } else {
          MessageBox.Show("The Machine return 0 Log\n ErrorCode: " + idwErrorCode.ToString(), "Error");
        }
      }

      string result = JsonConvert.SerializeObject(resultMap);
      return result;
    }

    public string GetDeviceStatus(string requestStatus) {
      int iValue = 0;
      List<int> availableStatusCode = new List<int>() { 2, 6 };

      if ("".Equals(requestStatus)) {
        MessageBox.Show("Select Status to Get from Device", "Warning");
      } else {
        int statusCode = int.Parse(requestStatus[0].ToString());
        if (availableStatusCode.Contains(statusCode)) {
          int iMachineNumber = 1;
          bool operation = axCZKEM1.GetDeviceStatus(iMachineNumber, statusCode, ref iValue);
          if (!operation) {
            MessageBox.Show("Get Status Fail", "Warning");
          }
        } else
          MessageBox.Show(statusCode.ToString() + "\n" + availableStatusCode.Contains(statusCode).ToString());
      }
      return iValue.ToString();
    }

    public string LoginToDatatp(DatatpHttpClient client, string loginId, string password, string company = "") {
      DatatpAuthorization datatpAuthorization = new DatatpAuthorization();
      string loginModel = datatpAuthorization.CreateLoginModel(loginId, password, company);
      HttpResponseMessage response = client.Post("rest/v1.0.0/company/acl/authenticate", loginModel);
      Task<string> task = response.Content.ReadAsStringAsync();
      JObject resultObject = client.GetResponseResultAsObject(task);
      string data = resultObject["data"].ToString();
      JObject dataObject = JsonConvert.DeserializeObject<JObject>(data);
      string authorization = dataObject["authorization"].ToString();
      JObject authorizationObject = JsonConvert.DeserializeObject<JObject>(authorization);
      string accessToken = authorizationObject["authorization"].ToString();
      return accessToken;
    }

    public void SaveAttLogsToDatatpTimeTrackings(DatatpHttpClient client) {
      string attLogs = DownloadDataFromDeviceAsJson();
      HttpResponseMessage response = client.Put("rest/v1.0.0/company/hr/timesheet/attlogs", attLogs);
    }
  }
}
