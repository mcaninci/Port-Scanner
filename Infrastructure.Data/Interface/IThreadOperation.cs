using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interface
{
  public  interface IThreadOperation
    {
        bool executeMethod(LinkedList<string> Ip, IPortRange portRange, Ilogger logger, EventWaitHandle threadSignal=null);
    }
}
