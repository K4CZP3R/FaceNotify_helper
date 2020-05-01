using FaceNotify_Helper.Services;
using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FaceNotify_Helper
{
    public partial class Main : Form
    {
        private readonly IntegrityChecker integrityChecker;
        private readonly AdbService adbService;

        private readonly string[] AppFiles = { "platform-tools.zip" };
        private readonly string[] ZipFiles = { "platform-tools.zip" };
        private readonly string UnpackTo = "unpacked";
        private readonly string PackageName = "k4czp3r.facenotify";
        private readonly string[] PermissionsToGrant = { "android.permission.READ_LOGS", "android.permission.WRITE_SECURE_SETTINGS", "android.permission.WRITE_SECURE_SETTINGS",
              "android.permission.PACKAGE_USAGE_STATS" };

        private List<DeviceData> ConnectedDevices;
        private DeviceData SelectedDevice = null;

        private readonly string AdbExecutablePath = Path.Combine(Directory.GetCurrentDirectory(), "platform-tools", "adb.exe");
        public Main()
        {
            InitializeComponent();
            integrityChecker = new IntegrityChecker(AppFiles, ZipFiles, UnpackTo);
            adbService = new AdbService(AdbExecutablePath);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("App will check if all files are there and will start an ADB server.\n\nPlease wait.", "Startup checks");
            var integrityResult = integrityChecker.IntegrityCheck();
            if (!integrityResult.Success)
            {
                MessageBox.Show(integrityResult.Data, "Integrity check failed!");
                System.Environment.Exit(1);
            }

            var adbServerResult = adbService.StartServer();
            if (!adbServerResult.Success)
            {
                MessageBox.Show(adbServerResult.Data, "Starting adb server failed!");
                System.Environment.Exit(2);
            }
        }

        private void button_refreshDevices_Click(object sender, EventArgs e) => RefreshDevices();

        private void RefreshDevices()
        {
            ConnectedDevices = adbService.GetDevices();
            listBox_deviceSelect.Items.Clear();

            foreach (var device in ConnectedDevices)
            {
                if (device.State == DeviceState.Unauthorized)
                {
                    MessageBox.Show($"Device {device.Serial} did not authorize this computer to access ADB.\nAccept popup on your phone and try again!", "Unauthorized");
                }
                else
                {
                    listBox_deviceSelect.Items.Add($"{device.Name} - {device.State}");

                }
            }
        }

        private void listBox_deviceSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_deviceSelect.SelectedIndex == -1) return;
            var device = ConnectedDevices[listBox_deviceSelect.SelectedIndex];
            string infoTemplate = $"Name: {device.Name}\nState: {device.State}\nSerial: {device.Serial}";
            label_selectedDeviceInfo.Text = infoTemplate;
            button_grantPermissions.Enabled = true;
            SelectedDevice = device;
        }

        private void button_grantPermissions_Click(object sender, EventArgs e)
        {
            if (SelectedDevice == null)
            {
                MessageBox.Show("Please select a device from the list", "No device selected!"); return;
            }

            string messageTemplate = $"The following permissions will be granted for '{PackageName}'";
            foreach (string permission in PermissionsToGrant)
            {
                messageTemplate += $"\n{permission}";
            }
            messageTemplate += "\nAre OK with that?";
            var diagResult = MessageBox.Show(messageTemplate, "Confirmation", MessageBoxButtons.OKCancel);
            if (diagResult != DialogResult.OK)
            {
                MessageBox.Show("Aborted.", "Granting permissions");
                return;
            }

            foreach (string permission in PermissionsToGrant)
            {
                var res = adbService.GrantPermission(SelectedDevice, PackageName, permission);
                if (!res.Success)
                {
                    MessageBox.Show(res.Data, "Something went wrong!");
                    return;
                }
            }

            MessageBox.Show("Permissions granted!", "Success");





        }
    }
}
