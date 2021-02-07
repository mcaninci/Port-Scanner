using Infrastructure.Data.Interface;
using System.Collections.Generic;
using System.Linq;
using ThreadOp= ThreadOperation.ThreadOperation;

namespace Port_Scanner_UI
{
    public class ScanOperation
    {
        Ilogger logger;
      

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
            ThreadMethod executionMethod = new ThreadMethod();
            ThreadOp threadOperation = new ThreadOp(ips, threadCount, logger, executionMethod);

            threadOperation.GenerateThread();
            threadOperation.ThreadRun();

        }

        public void ScanStop()
        {


        }

        public void ThreadCountUpdate(int threadCount)
        {


        }

    }
}
