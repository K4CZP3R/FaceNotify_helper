namespace FaceNotify_Helper
{
    partial class Main
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
            this.label_selectedDeviceInfo = new System.Windows.Forms.Label();
            this.label_device_value = new System.Windows.Forms.Label();
            this.button_grantPermissions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_deviceSelect = new System.Windows.Forms.ListBox();
            this.label_deviceSelect = new System.Windows.Forms.Label();
            this.button_refreshDevices = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_selectedDeviceInfo
            // 
            this.label_selectedDeviceInfo.AutoSize = true;
            this.label_selectedDeviceInfo.Location = new System.Drawing.Point(6, 16);
            this.label_selectedDeviceInfo.Name = "label_selectedDeviceInfo";
            this.label_selectedDeviceInfo.Size = new System.Drawing.Size(0, 13);
            this.label_selectedDeviceInfo.TabIndex = 0;
            // 
            // label_device_value
            // 
            this.label_device_value.AutoSize = true;
            this.label_device_value.Location = new System.Drawing.Point(140, 184);
            this.label_device_value.Name = "label_device_value";
            this.label_device_value.Size = new System.Drawing.Size(0, 13);
            this.label_device_value.TabIndex = 1;
            // 
            // button_grantPermissions
            // 
            this.button_grantPermissions.Enabled = false;
            this.button_grantPermissions.Location = new System.Drawing.Point(96, 118);
            this.button_grantPermissions.Name = "button_grantPermissions";
            this.button_grantPermissions.Size = new System.Drawing.Size(98, 23);
            this.button_grantPermissions.TabIndex = 2;
            this.button_grantPermissions.Text = "Grant permissions";
            this.button_grantPermissions.UseVisualStyleBackColor = true;
            this.button_grantPermissions.Click += new System.EventHandler(this.button_grantPermissions_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FaceNotify by K4CZP3R";
            // 
            // listBox_deviceSelect
            // 
            this.listBox_deviceSelect.FormattingEnabled = true;
            this.listBox_deviceSelect.Location = new System.Drawing.Point(15, 41);
            this.listBox_deviceSelect.Name = "listBox_deviceSelect";
            this.listBox_deviceSelect.Size = new System.Drawing.Size(279, 147);
            this.listBox_deviceSelect.TabIndex = 6;
            this.listBox_deviceSelect.SelectedIndexChanged += new System.EventHandler(this.listBox_deviceSelect_SelectedIndexChanged);
            // 
            // label_deviceSelect
            // 
            this.label_deviceSelect.AutoSize = true;
            this.label_deviceSelect.Location = new System.Drawing.Point(12, 17);
            this.label_deviceSelect.Name = "label_deviceSelect";
            this.label_deviceSelect.Size = new System.Drawing.Size(102, 13);
            this.label_deviceSelect.TabIndex = 7;
            this.label_deviceSelect.Text = "Connected devices:";
            // 
            // button_refreshDevices
            // 
            this.button_refreshDevices.Location = new System.Drawing.Point(219, 12);
            this.button_refreshDevices.Name = "button_refreshDevices";
            this.button_refreshDevices.Size = new System.Drawing.Size(75, 23);
            this.button_refreshDevices.TabIndex = 8;
            this.button_refreshDevices.Text = "Refresh";
            this.button_refreshDevices.UseVisualStyleBackColor = true;
            this.button_refreshDevices.Click += new System.EventHandler(this.button_refreshDevices_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_selectedDeviceInfo);
            this.groupBox1.Controls.Add(this.button_grantPermissions);
            this.groupBox1.Location = new System.Drawing.Point(300, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device info";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_refreshDevices);
            this.Controls.Add(this.label_deviceSelect);
            this.Controls.Add(this.listBox_deviceSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_device_value);
            this.Name = "Main";
            this.Text = "FaceNotify - Helper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selectedDeviceInfo;
        private System.Windows.Forms.Label label_device_value;
        private System.Windows.Forms.Button button_grantPermissions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_deviceSelect;
        private System.Windows.Forms.Label label_deviceSelect;
        private System.Windows.Forms.Button button_refreshDevices;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}