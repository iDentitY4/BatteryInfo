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

            while (true)
            {
                // battery percent (batChargePercent & batChargeLabel)
                float batPercent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
                batChargePercent.Text = ((int)batPercent).ToString() + '%';
                batChargeBar.Value = (int)batPercent;

                // charging status (batChargingStatusInfo)
                PowerLineStatus chargingStatus = SystemInformation.PowerStatus.PowerLineStatus;
                if (chargingStatus.ToString() == "Online")
                {
                    batChargingStatusInfo.Text = "Charging";
                }
                else
                {
                    batChargingStatusInfo.Text = "Discharging";
                }

                Thread.Sleep(1000);
            }
            


        }
    }
}
