using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BatteryInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // notify icon 
            batInfoIcon.Visible = true;
            

            // create 1s timer to update gui 
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(updateWindow);
            timer.Start();

        }

        private void updateWindow(object sender, EventArgs e)
        {
            // battery percent (batChargePercent & batChargeLabel)
            float batPercent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            batChargePercent.Text = ((int)batPercent).ToString() + '%';
            batChargeBar.Value = (int)batPercent;

            // charging status (batChargingStatusInfo)
            PowerLineStatus chargingStatus = SystemInformation.PowerStatus.PowerLineStatus;
            if (chargingStatus.ToString() == "Online")
            {
                string batChargingState = "Charging";
                // set gui text
                batChargingStatusInfo.Text = batChargingState;
                // set notify icon text 
                batInfoIcon.Text = "Charge: " + ((int)batPercent).ToString()
                + "%\n" + "Charging: " + batChargingState
                + "\n" + "Time since last charge: ";
            }
            else
            {
                string batChargingState = "Discharging";
                batChargingStatusInfo.Text = batChargingState;

                batInfoIcon.Text = "Charge: " + ((int)batPercent).ToString()
                + "%\n" + "Charging: " + batChargingState
                + "\n" + "Time since last charge: ";
            }

            

        }

        private void BatInfoIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
