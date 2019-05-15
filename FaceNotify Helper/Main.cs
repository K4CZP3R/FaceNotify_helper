using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoolADB;

namespace FaceNotify_Helper
{
    public partial class Main : Form
    {
        CoolADB.ADBClient client = new ADBClient();
        public Main()
        {
            InitializeComponent();
            MessageBox.Show("Please wait when app configures adb...", "FaceNotify - info");
            //Check if adb files are here
            string[] adb_files = new string[] { "adb.exe","AdbWinApi.dll", "AdbWinUsbApi.dll" };
            foreach(string file in adb_files)
            {
                if (!File.Exists(file))
                {
                    MessageBox.Show(String.Format("File '{0}' not found. Please redownload.", file), "FaceNotify - Error");
                    System.Environment.Exit(1);
                }
            }

            //Define adbclient
            
            client.AdbPath = Directory.GetCurrentDirectory();

            //Get connected devices
            List<string> adb_devices = client.Devices();
            bool one_good_device = false;
            foreach(string device in adb_devices)
            {
                if (device.Length > 1) one_good_device = true;
            }
            if (!one_good_device)
            {
                MessageBox.Show("Device not found! Did you enabled and granted ADB Debug?", "FaceNotify - Error");
                System.Environment.Exit(1);
            }

            label_device_value.Text = adb_devices[0];

        }

        private void Button_grant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This can take a while...", "FaceNotify - Info");
            string grant_prefix = "pm grant";
            string pkg_name = "k4czp3r.facenotify";

            string[] permissions = new string[]
            {
                "android.permission.READ_LOGS",
                "android.permission.DUMP",
                "android.permission.WRITE_SECURE_SETTINGS",
                "android.permission.PACKAGE_USAGE_STATS"
            };

            foreach(string permission in permissions)
            {
                client.Execute(String.Format("{0} {1} {2}", grant_prefix, pkg_name, permission),false);
            }
            MessageBox.Show("Permissions granted! You can reboot your phone now", "FaceNotify - info");
            

        }

        private void Button_reboot_Click(object sender, EventArgs e)
        {
            client.Reboot(ADBClient.BootState.System);
            MessageBox.Show("Ka-Ching!", "FaceNotify - info");
        }

        private void Button_fixadb_Click(object sender, EventArgs e)
        {
            client.KillServer();
            MessageBox.Show("Adb server stopped, please wait server starting...", "FaceNotify - info");
            client.StartServer();
            MessageBox.Show("Adb server started, you can try to grant permissions now", "FaceNotify - info");
        }
    }
}
