using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Function usages
  1. ReadGeneralLogData: Read Attendance records and Write them into the internal buffer of the PC. return true | false
  2. SSR_GetGeneralLogData: Read Attendance records one by one from the internal buffer.
*/

/* iMachineNumber 
  In fact,when you are using the tcp/ip communication,this parameter will be ignored, 
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
      int idwTMachineNumber = 0;
      int idwEMachineNumber = 0;
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
      // axCZKEM1.EnableDevice(iMachineNumber, false); // Disable the device

      bool readAble = axCZKEM1.ReadGeneralLogData(iMachineNumber);
      if (readAble) {
        bool isReadingData = axCZKEM1.SSR_GetGeneralLogData(
          iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
          out idwInOutMode, out idwYear, out idwMonth, out idwDay,
          out idwHour, out idwMinute, out idwSecond, ref idwWorkcode
        );
        while (axCZKEM1.SSR_GetGeneralLogData(
          iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
          out idwInOutMode, out idwYear, out idwMonth, out idwDay,
          out idwHour, out idwMinute, out idwSecond, ref idwWorkcode
        )) {
          index += 1;
          records.Add(
            index+"\t"+sdwEnrollNumber+"\t\t"+idwTMachineNumber+"\t\t"+idwEMachineNumber+"\t\t"+idwVerifyMode+"\t\t"+idwInOutMode+
            "\t\t"+idwYear+"/"+idwMonth+"/"+idwDay+" "+idwHour+":"+idwMinute+":"+idwSecond
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

      // axCZKEM1.EnableDevice(iMachineNumber, true); // Enable the device
      return records;
    }

    public string GetDeviceStatus(string requestStatus) {
      int iValue = 0;
      List<int> availableStatusCode = new List<int>() { 2, 6 };

      if ("".Equals(requestStatus)) {
        MessageBox.Show("Select Status to Get from Device", "Warning");
      }
      int statusCode = int.Parse(requestStatus[0].ToString());
      if (availableStatusCode.Contains(statusCode)) {
        int iMachineNumber = 1;
        bool operation = axCZKEM1.GetDeviceStatus(iMachineNumber, statusCode, ref iValue);
        if (!operation) {
          MessageBox.Show("Get Status Fail", "Warning");
        }
      } else MessageBox.Show(statusCode.ToString() + "\n" + availableStatusCode.Contains(statusCode).ToString());

      return iValue.ToString();
    }
  }
}
