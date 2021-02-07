﻿using Infrastructure.Data.Interface;
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
    public class ThreadOperation
    {
        Ilogger logger;
        IThreadOperation threadOperation;
        List<Thread> threadList;
        LinkedList<string> Ip;
        int threadCount;
        bool isAnyChange = false;
      //  static EventWaitHandle threadSignal = new AutoResetEvent(false);
        static CountdownEvent threadCountEvent;
        public ThreadOperation(LinkedList<string> Ip,int threadCount, Ilogger logger =null, IThreadOperation threadOperation = null )
        {
            this.threadOperation = threadOperation==null?new NullObjectThreadExecute():threadOperation;
            this.logger = logger==null?new NullobjectLogger():logger;
            this.threadCount = threadCount;
            threadCountEvent = new CountdownEvent(threadCount);
            threadList = new List<Thread>(threadCount);
            this.Ip = Ip;

        }     

  
        public List<Thread> GenerateThread()
        {

            for (int i = 0; i < threadCount; i++)
            {
                PortRange portRange = SetThreadPortRange(i);
                int index = i;
                Thread tmpThread = new Thread(() => ThreadStart(portRange,index, threadCountEvent));
                tmpThread.Name = "Thread " + i;
                tmpThread.IsBackground = true;
                threadList.Add(tmpThread);
            }
            return threadList;

        }

        public PortRange SetThreadPortRange( int threadIndex)
        {
            var minPort = 0;
            var maxPort = 0;
            int mode = TCPConst.maxPortNum % threadCount;
            int range = TCPConst.maxPortNum / threadCount;
            if (threadIndex==0)
            {
                minPort = TCPConst.minPortNum;
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

        private void ThreadStart(IPortRange portRange,int threadIndex, CountdownEvent threadSignal)
        {

            _=threadOperation.executeMethod(Ip, portRange, logger, threadIndex, ref this.threadCount, ref isAnyChange, threadSignal);
            CheckProcessandsuspend(threadIndex);
        }

        public void ThreadRun()
        {
            foreach (var thread in threadList)
            {
                logger.WriteLog(thread.Name + " is running");
                thread.Start();
            }


        }

        public void UpdateThreadCount(int threadCount)
        {
            this.threadCount = threadCount;
            isAnyChange = true;
            threadCountEvent.Wait();
            isAnyChange = false;
            threadCountEvent = new CountdownEvent(threadCount);
            if (threadList.Count < threadCount)
            {

                for (int i = threadList.Count; i < (threadCount- threadList.Count)+1; i++)
                {
                    PortRange portRange = SetThreadPortRange(i);
                    int index = i;
                    Thread tmpThread = new Thread(() => ThreadStart(portRange, index, threadCountEvent));
                    tmpThread.Name = "Thread " + i;
                    tmpThread.IsBackground = true;
                    threadList.Add(tmpThread);
                    logger.WriteLog(tmpThread.Name + " is running");
                    tmpThread.Start();
                }
                
            }
        

        }
      private void CheckProcessandsuspend(int threadIndex)
        {
            var thread= threadList[threadIndex];
            thread.Abort();
        }  

        public void TerminateAllThread()
        {
            foreach (var item in threadList)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
                
            }
            logger.WriteLog("Log:All Thread stopped.");

        }



    }
}
