using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infrastructure.Data.Model
{

   public class NullobjectLogger : Ilogger
    {

        void Ilogger.SetTargetComp(RichTextBox richTextBox)
        {

        }

        void Ilogger.WriteLog(string message)
        {

          
        }
    }

  public  class NullObjectThreadExecute : IThreadOperation
    {
        bool IThreadOperation.executeMethod(string Ip, IPortRange portRange, Ilogger logger)
        {
            
            return false;
        }
    }

}
