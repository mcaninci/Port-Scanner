using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logger
{
    public class Logger : Ilogger
    {
        RichTextBox uiConsole;
        private static readonly object lockObj = new object();
        public void SetTargetComp(RichTextBox richTextBox)
        {
            uiConsole = richTextBox;
        }

        public void WriteLog(string message)
        {
            lock (lockObj)
            {
                uiConsole.AppendText(message + "\r\n");

            }


        }
    }
}
