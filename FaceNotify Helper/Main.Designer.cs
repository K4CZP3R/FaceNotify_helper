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
            this.label_device_key = new System.Windows.Forms.Label();
            this.label_device_value = new System.Windows.Forms.Label();
            this.button_grant = new System.Windows.Forms.Button();
            this.button_reboot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_fixadb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_device_key
            // 
            this.label_device_key.AutoSize = true;
            this.label_device_key.Location = new System.Drawing.Point(12, 9);
            this.label_device_key.Name = "label_device_key";
            this.label_device_key.Size = new System.Drawing.Size(98, 13);
            this.label_device_key.TabIndex = 0;
            this.label_device_key.Text = "Device connected:";
            // 
            // label_device_value
            // 
            this.label_device_value.AutoSize = true;
            this.label_device_value.Location = new System.Drawing.Point(116, 9);
            this.label_device_value.Name = "label_device_value";
            this.label_device_value.Size = new System.Drawing.Size(0, 13);
            this.label_device_value.TabIndex = 1;
            // 
            // button_grant
            // 
            this.button_grant.Location = new System.Drawing.Point(12, 72);
            this.button_grant.Name = "button_grant";
            this.button_grant.Size = new System.Drawing.Size(98, 23);
            this.button_grant.TabIndex = 2;
            this.button_grant.Text = "Grant permissions";
            this.button_grant.UseVisualStyleBackColor = true;
            this.button_grant.Click += new System.EventHandler(this.Button_grant_Click);
            // 
            // button_reboot
            // 
            this.button_reboot.Location = new System.Drawing.Point(12, 101);
            this.button_reboot.Name = "button_reboot";
            this.button_reboot.Size = new System.Drawing.Size(98, 23);
            this.button_reboot.TabIndex = 3;
            this.button_reboot.Text = "Reboot phone";
            this.button_reboot.UseVisualStyleBackColor = true;
            this.button_reboot.Click += new System.EventHandler(this.Button_reboot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FaceNotify by K4CZP3R";
            // 
            // button_fixadb
            // 
            this.button_fixadb.Location = new System.Drawing.Point(12, 43);
            this.button_fixadb.Name = "button_fixadb";
            this.button_fixadb.Size = new System.Drawing.Size(98, 23);
            this.button_fixadb.TabIndex = 5;
            this.button_fixadb.Text = "Fix adb";
            this.button_fixadb.UseVisualStyleBackColor = true;
            this.button_fixadb.Click += new System.EventHandler(this.Button_fixadb_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 137);
            this.Controls.Add(this.button_fixadb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reboot);
            this.Controls.Add(this.button_grant);
            this.Controls.Add(this.label_device_value);
            this.Controls.Add(this.label_device_key);
            this.Name = "Main";
            this.Text = "FaceNotify - Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_device_key;
        private System.Windows.Forms.Label label_device_value;
        private System.Windows.Forms.Button button_grant;
        private System.Windows.Forms.Button button_reboot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_fixadb;
    }
}