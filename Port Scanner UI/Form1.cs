﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port_Scanner_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trckBarThreadCount_EditValueChanged(object sender, EventArgs e)
        {
            TrackBarControl trackBarControl = sender as TrackBarControl;
           lblThreadCounter.Text = trackBarControl.EditValue.ToString();
        }

        private void rtxtConsole_TextChanged(object sender, EventArgs e)
        {
         
                // set the current caret position to the end
             rtxtConsole.SelectionStart = rtxtConsole.Text.Length;
            // scroll it automatically
            rtxtConsole.ScrollToCaret();
           
        }
    }
}
