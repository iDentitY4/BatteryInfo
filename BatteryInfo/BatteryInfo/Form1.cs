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
            batInfoIcon.Visible = true; /// make notify icon visible 
            MenuItem trayItem = new System.Windows.Forms.MenuItem("Exit", trayItem_Click); /// new tray item object with (text, on click event handler)
            ContextMenu trayMenu = new System.Windows.Forms.ContextMenu(); /// create context menu object 
            trayMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { trayItem }); /// add list of items to context menu (currently only one)
            batInfoIcon.ContextMenu = trayMenu; /// assign created context menu to notify icon 
            
            

            // create 1s timer to update gui 
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); /// create new !Forms! timer object (do NOT use Thread.Timer)
            timer.Interval = (1000); /// set interval for 1s 
            timer.Tick += new EventHandler(updateWindow); /// add event handler on tick
            timer.Start(); 

        }

        private void updateWindow(object sender, EventArgs e) /// auto update gui on every timer call 
        {
            // hide taskbar icon if minimized (keep notify icon)
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide(); /// hide taskbar icon if window is minimized 
            }

            // battery percent (batChargePercent & batChargeLabel)
            float batPercent = SystemInformation.PowerStatus.BatteryLifePercent * 100; /// battery percent gets returned as decimal of 1
            batChargePercent.Text = ((int)batPercent).ToString() + '%'; 
            batChargeBar.Value = (int)batPercent; /// assign batPercent value to progress bar 

            // log full charge 
            if ((int)batPercent >= 90) 
            {
                System.IO.File.WriteAllText("log.txt", DateTime.Now.ToString()); /// write current time to file if charge >90%
            }
            // compare full charge to now 
            DateTime fullCharge = Convert.ToDateTime(System.IO.File.ReadAllText("log.txt")); /// get time of last full charge
            TimeSpan sinceCharge = DateTime.Now.Subtract(fullCharge); /// compare to current time for "time since last charge"

            // charging status (batChargingStatusInfo)
            PowerLineStatus chargingStatus = SystemInformation.PowerStatus.PowerLineStatus; /// get powerline status 
            if (chargingStatus.ToString() == "Online") /// if else statement is only useful to change the string that gets displayed 
            {
                string batChargingState = "Charging";
                // set gui text
                batChargingStatusInfo.Text = batChargingState;
                // set notify icon text 
                batInfoIcon.Text = "Charge: " + ((int)batPercent).ToString()
                + "%\n" + "Charging: " + batChargingState
                + "\n" + "Last charge: " + TimeUtil.ToHumanTimeString(sinceCharge);
            }
            else
            {
                // same as before
                string batChargingState = "Discharging";

                batChargingStatusInfo.Text = batChargingState;

                batInfoIcon.Text = "Charge: " + ((int)batPercent).ToString()
                + "%\n" + "Charging: " + batChargingState
                + "\n" + "Last charge: " + TimeUtil.ToHumanTimeString(sinceCharge);
            }

            timeSinceLastFullInfo.Text = TimeUtil.ToHumanTimeString(sinceCharge); /// put time since last charge on screen 

            ///// to-do:
            ///     run on startup and in notification area only

            

        }

        private void trayItem_Click(object sender, EventArgs e) /// on clicking "Exit", the app will ... exit... who would've thought
        {
            Application.Exit();
        }

        private void BatInfoIcon_MouseDoubleClick(object sender, MouseEventArgs e) /// on double clicking the icon, app will be put back to foreground 
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
