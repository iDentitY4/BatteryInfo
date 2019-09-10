namespace BatteryInfo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.batChargeLabel = new System.Windows.Forms.Label();
            this.batChargeBar = new System.Windows.Forms.ProgressBar();
            this.batChargePercent = new System.Windows.Forms.Label();
            this.batChargingStatusLabel = new System.Windows.Forms.Label();
            this.batChargingStatusInfo = new System.Windows.Forms.Label();
            this.timeSinceLastFullLabel = new System.Windows.Forms.Label();
            this.timeSinceLastFullInfo = new System.Windows.Forms.Label();
            this.batInfoIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // batChargeLabel
            // 
            this.batChargeLabel.AutoSize = true;
            this.batChargeLabel.Location = new System.Drawing.Point(14, 20);
            this.batChargeLabel.Name = "batChargeLabel";
            this.batChargeLabel.Size = new System.Drawing.Size(120, 20);
            this.batChargeLabel.TabIndex = 0;
            this.batChargeLabel.Text = "Battery Charge:";
            // 
            // batChargeBar
            // 
            this.batChargeBar.Location = new System.Drawing.Point(281, 15);
            this.batChargeBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.batChargeBar.Name = "batChargeBar";
            this.batChargeBar.Size = new System.Drawing.Size(112, 29);
            this.batChargeBar.TabIndex = 1;
            // 
            // batChargePercent
            // 
            this.batChargePercent.AutoSize = true;
            this.batChargePercent.Location = new System.Drawing.Point(232, 19);
            this.batChargePercent.Name = "batChargePercent";
            this.batChargePercent.Size = new System.Drawing.Size(50, 20);
            this.batChargePercent.TabIndex = 2;
            this.batChargePercent.Text = "100%";
            // 
            // batChargingStatusLabel
            // 
            this.batChargingStatusLabel.AutoSize = true;
            this.batChargingStatusLabel.Location = new System.Drawing.Point(14, 75);
            this.batChargingStatusLabel.Name = "batChargingStatusLabel";
            this.batChargingStatusLabel.Size = new System.Drawing.Size(128, 20);
            this.batChargingStatusLabel.TabIndex = 3;
            this.batChargingStatusLabel.Text = "Charging Status:";
            // 
            // batChargingStatusInfo
            // 
            this.batChargingStatusInfo.AutoSize = true;
            this.batChargingStatusInfo.Location = new System.Drawing.Point(300, 75);
            this.batChargingStatusInfo.Name = "batChargingStatusInfo";
            this.batChargingStatusInfo.Size = new System.Drawing.Size(93, 20);
            this.batChargingStatusInfo.TabIndex = 4;
            this.batChargingStatusInfo.Text = "Discharging";
            // 
            // timeSinceLastFullLabel
            // 
            this.timeSinceLastFullLabel.AutoSize = true;
            this.timeSinceLastFullLabel.Location = new System.Drawing.Point(14, 134);
            this.timeSinceLastFullLabel.Name = "timeSinceLastFullLabel";
            this.timeSinceLastFullLabel.Size = new System.Drawing.Size(194, 20);
            this.timeSinceLastFullLabel.TabIndex = 5;
            this.timeSinceLastFullLabel.Text = "Time since last full charge:";
            // 
            // timeSinceLastFullInfo
            // 
            this.timeSinceLastFullInfo.Location = new System.Drawing.Point(232, 134);
            this.timeSinceLastFullInfo.Name = "timeSinceLastFullInfo";
            this.timeSinceLastFullInfo.Size = new System.Drawing.Size(161, 20);
            this.timeSinceLastFullInfo.TabIndex = 6;
            this.timeSinceLastFullInfo.Text = "100h";
            this.timeSinceLastFullInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // batInfoIcon
            // 
            this.batInfoIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("batInfoIcon.Icon")));
            this.batInfoIcon.Text = "Battery Info";
            this.batInfoIcon.Visible = true;
            this.batInfoIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BatInfoIcon_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 168);
            this.Controls.Add(this.timeSinceLastFullInfo);
            this.Controls.Add(this.timeSinceLastFullLabel);
            this.Controls.Add(this.batChargingStatusInfo);
            this.Controls.Add(this.batChargingStatusLabel);
            this.Controls.Add(this.batChargePercent);
            this.Controls.Add(this.batChargeBar);
            this.Controls.Add(this.batChargeLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(425, 224);
            this.MinimumSize = new System.Drawing.Size(425, 224);
            this.Name = "Form1";
            this.Text = "Battery Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label batChargeLabel;
        private System.Windows.Forms.ProgressBar batChargeBar;
        private System.Windows.Forms.Label batChargePercent;
        private System.Windows.Forms.Label batChargingStatusLabel;
        private System.Windows.Forms.Label batChargingStatusInfo;
        private System.Windows.Forms.Label timeSinceLastFullLabel;
        private System.Windows.Forms.Label timeSinceLastFullInfo;
        private System.Windows.Forms.NotifyIcon batInfoIcon;
    }
}

