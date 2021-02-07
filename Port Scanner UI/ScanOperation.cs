using Infrastructure.Data.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ThreadOp= ThreadOperation.ThreadOperation;

namespace Port_Scanner_UI
{
    public class ScanOperation
    {

        Ilogger logger;
         static int currentThreadCount=0;

        ThreadMethod executionMethod = new ThreadMethod();
        ThreadOp threadOperation = null;
        public ScanOperation(Logger.Logger logger)
        {
            this.logger = logger;
         
        }

        ScanOperation(Ilogger logger)
        {

            this.logger = logger;

        }

  

        public void ScanStart(int threadCount,LinkedList<string> ips)
        {
            currentThreadCount = threadCount;
            threadOperation =  new ThreadOp(ips, threadCount, logger, executionMethod);
            threadOperation.GenerateThread();
            threadOperation.ThreadRun();

        }

        public void ScanStop()
        {
            if (threadOperation != null)
            {
                threadOperation.TerminateAllThread();
            }

        }

        public void ThreadCountUpdate(int threadCount)
        {

            if (threadOperation!=null && currentThreadCount!=threadCount)
            {
                threadOperation.UpdateThreadCount(threadCount);
            }


        }

    }
}
