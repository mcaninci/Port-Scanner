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
            scanOperation.ThreadCountUpdate(trackBarControl.Value);
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
            string minIp = txtIprangeMin.Text;
            string maxIp = txtIprangeMax.Text;

            bool validationIp = IpOperation.IpValidation.IsRangeValid(minIp, maxIp);
            int threadCount = trckBarThreadCount.Value;
            if (validationIp)
            {
                LinkedList<string> ipList = IpOperation.Convert.RangeToIpList(minIp, maxIp);

                scanOperation.ScanStart(threadCount, ipList);

            }
            else
            {
                MessageBox.Show("Ip range is not valid. Please check min- max Ip");
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            scanOperation.ScanStop();
        }
    }
}
