using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPOperation;
using Log= Logger.Logger;

namespace Port_Scanner_UI
{
    public partial class Form1 : Form
    {
        Log logger = new Log();
        ScanOperation scanOperation;
        bool isRunning = false;
        bool user_done_updating = false;
        bool isIprange = true;
        public Form1()
        {
            InitializeComponent();
            logger.SetTargetComp(rtxtConsole);
            scanOperation = new ScanOperation(logger);
        }

        private void trckBarThreadCount_EditValueChanged(object sender, EventArgs e)
        {
            TrackBarControl trackBarControl = sender as TrackBarControl;
           lblThreadCounter.Text = trackBarControl.EditValue.ToString();
            user_done_updating = true; 
           
           
        }

  
        private void trckBarThreadCount_MouseUp(object sender, EventArgs e)
        {
            TrackBarControl trackBarControl = sender as TrackBarControl;
            if (isRunning && user_done_updating  )
            {
                trackBarControl.Enabled = false;
                Task.Run(() =>
                {
                    scanOperation.ThreadCountUpdate(trackBarControl.Value, trackBarControl);
                });
                user_done_updating = false;
            }

        }

        private void rtxtConsole_TextChanged(object sender, EventArgs e)
        {
         
                // set the current caret position to the end
             rtxtConsole.SelectionStart = rtxtConsole.Text.Length;
            // scroll it automatically
            rtxtConsole.ScrollToCaret();
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            rtxtConsole.Text = "";
            int threadCount = trckBarThreadCount.Value;
            LinkedList<string> ipList=null;
            if (isIprange)
            {
                string minIp = txtIprangeMin.Text;
                string maxIp = txtIprangeMax.Text;
                bool validationIp = IpOperation.IpValidation.IsRangeValid(minIp, maxIp);
                if (validationIp)
                {
                    ipList = IpOperation.Convert.RangeToIpList(minIp, maxIp);

                }
                else
                {
                    MessageBox.Show("Ip range is not valid. Please check min- max Ip");
                    return;
                }

            }
            else
            {
                ipList = IpOperation.Convert.IpNotitaionToIpList(txtIpNotation.Text);

            }
            if (ipList==null)
            {
                MessageBox.Show("Something's wrong.Please check ips");
                return;
            }
            scanOperation.ScanStart(threadCount, ipList);
            isRunning = true;


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            scanOperation.ScanStop();
            trckBarThreadCount.Enabled = true;
        }

        private void radioRange_CheckedChanged(object sender, EventArgs e)
        {
            isIprange = true;
            txtIpNotation.Visible = false;
            txtIprangeMin.Visible=true;
            txtIprangeMax.Visible=true;
            labelControl1.Visible = true;
        }

        private void radioNotation_CheckedChanged(object sender, EventArgs e)
        {
            isIprange = false;
            txtIprangeMin.Visible = false;
            txtIprangeMax.Visible = false;
            labelControl1.Visible = false;
            txtIpNotation.Visible = true;
        }
    }
}
