using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TCPOperation
{
   public class PortRange: IPortRange
    {
        private int start;
        private int stop;
        private int ports;

        public PortRange(int startPort, int stopPort)
        {
      
            start = startPort;
            stop = stopPort;
            ports = start;
        }
        public int GetStartPort()
        {
           return start;
        }
        public int GetEndPort()
        {
            return stop;
        }
        public void ResetPorts()
        {
            ports = start;
        }
        public bool MorePorts()
        {
            return (stop - ports) >= 0;
        }
        public int NextPort()
        {
            if (MorePorts())
            {
                return ports++;
            }
            return -1;
        }
    }
}
