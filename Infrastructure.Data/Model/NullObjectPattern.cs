using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        bool IThreadOperation.executeMethod(LinkedList<string> Ip, IPortRange portRange, Ilogger logger, int threadIndex, ref int threadCount, ref bool isAnyChange,ref CountdownEvent threadSignal )
        {
            
            return false;
        }
    }

}
