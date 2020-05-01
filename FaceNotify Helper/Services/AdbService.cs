using FaceNotify_Helper.Models;
using SharpAdbClient;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceNotify_Helper.Services
{
    public class AdbService
    {
        private AdbServer adbServer { get; set; }
        private string AdbExecutablePath { get; set; }
        public AdbService(string adbExecutablePath)
        {
            AdbExecutablePath = adbExecutablePath;
        }

        public LogicReturn StartServer()
        {
            adbServer = new AdbServer();
            try
            {
                var result = adbServer.StartServer(AdbExecutablePath, false);
                return new LogicReturn { Success = true, Data = result.ToString() };
            }
            catch(Exception ex)
            {
                return new LogicReturn { Success = false, Data = ex.Message };
            }
            
        }

        public LogicReturn IsPackageInstalled(DeviceData device, string packageName) {
            PackageManager pm = new PackageManager(device);
            pm.RefreshPackages();

            if (!pm.Packages.ContainsKey(packageName)) return new LogicReturn { Success = false, Data = $"'{packageName}' is not installed!" };
            return new LogicReturn { Success = true };

                                                               
        }
        public LogicReturn GrantPermission(DeviceData device, string packageName, string permissionName)
        {
            var isPackageInstalled = IsPackageInstalled(device, packageName);
            if (!isPackageInstalled.Success) return isPackageInstalled;

            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand($"pm grant {packageName} {permissionName}", device, receiver);
            if (receiver.ToString().Length > 0) return new LogicReturn { Data = receiver.ParsesErrors.ToString(), Success = false };
            return new LogicReturn { Success = true };
        }
        public List<DeviceData> GetDevices()
        {
            var devices = AdbClient.Instance.GetDevices();
            List<DeviceData> toReturn = new List<DeviceData>();
            foreach(var device in devices)
            {
                toReturn.Add(device);
            }
            return toReturn;
        }

    }
}
