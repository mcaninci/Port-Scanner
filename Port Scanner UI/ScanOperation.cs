using DevExpress.XtraEditors;
using Infrastructure.Data.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ThreadOp = ThreadOperation.ThreadOperation;

namespace Port_Scanner_UI
{
    public class ScanOperation
    {

        Ilogger logger;
        static int currentThreadCount = 0;
        bool isRunning = false;

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



        public void ScanStart(int threadCount, LinkedList<string> ips)
        {
            isRunning = true;
            currentThreadCount = threadCount;
            threadOperation = new ThreadOp(ips, threadCount, logger, executionMethod);
            threadOperation.GenerateThread();
            threadOperation.ThreadRun();

        }

        public void ScanStop()
        {
            isRunning = false;
            if (threadOperation != null)
            {

                threadOperation.TerminateAllThread();
            }

        }

        public void ThreadCountUpdate(int threadCount, TrackBarControl trcbar)
        {

            if (threadOperation != null && currentThreadCount != threadCount && isRunning)
            {
                logger.WriteLog("Thread count is changing.Please wait.");
            
                    isRunning = false;
                    threadOperation.UpdateThreadCount(threadCount);
                    isRunning = true;
                    trcbar.Enabled = true;
              
            }


        }

    }
}
