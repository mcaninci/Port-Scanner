using Infrastructure.Data.Interface;
using Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TCPOperation
{
    public class PortRange : IPortRange
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

        public void UpdatePortRange(int threadCount, int threadIndex)
        {


            int range = TCPConst.maxPortNum / threadCount;
            if (threadIndex == 0)
            {
                start = TCPConst.minPortNum;
                stop = threadIndex + 1 * range;
                ports = start;
            }
            else if (threadIndex == threadCount)
            {
                start = ((threadIndex) * range) + 1;
                stop = TCPConst.maxPortNum;
                ports = start;

            }
            else
            {
                start = ((threadIndex) * range) + 1;
                stop = (threadIndex + 1) * range;
                ports = start;
            }

        }
    }
}
