using Infrastructure.Data.Interface;
using Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TCPOperation;

namespace ThreadOperation
{
    public class Create
    {
        Ilogger logger;
        IThreadOperation threadOperation;
        List<Thread> threadList;
        string Ip;
        int threadCount;
       public Create(string Ip,int threadCount, Ilogger logger =null, IThreadOperation threadOperation = null )
        {
            this.threadOperation = threadOperation;
            this.logger = logger;
            this.threadCount = threadCount;
            threadList = new List<Thread>(threadCount);
            this.Ip = Ip;

        }     

        private void GenerateThread()
        {
          

            for (int i = 0; i < threadCount; i++)
            {
               
                Thread tmpThread = new Thread(() => ThreadStart(SetThreadPortRange(i)));
                tmpThread.Name = "Thread " + i;
                threadList.Add(tmpThread);
            }
           
            

        }

        public PortRange SetThreadPortRange( int threadIndex)
        {
            var minPort = 0;
            var maxPort = 0;
            int mode = TCPConst.maxPortNum % threadCount;
            int range = TCPConst.maxPortNum / threadCount;
            if (threadIndex==0)
            {
                minPort = 0;
                maxPort = threadIndex+1 * range;
            }
            else if (threadIndex== threadCount)
            {
                minPort = ((threadIndex ) * range)+1;
                maxPort = TCPConst.maxPortNum;
            }
            else
            {
                minPort = ((threadIndex) * range)+1;
                maxPort = (threadIndex+1) * range;
            }
            PortRange portRange = new PortRange(minPort, maxPort);
            return portRange;
        }

        private void ThreadStart(IPortRange portRange)
        {

            threadOperation.executeMethod(Ip, null, logger);
        }

        public void ThreadRun()
        {
            foreach (var thread in threadList)
            {
                logger.WriteLog(thread.Name + " is running");
                thread.Start();
            }


        }
        



    }
}
