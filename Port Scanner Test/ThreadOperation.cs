using Infrastructure.Data.Interface;
using Infrastructure.Data.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadOperation;

namespace Port_Scanner_Test
{
    
    class ThreadOperation
    {
        global::ThreadOperation.ThreadOperation threadcreate;
        [SetUp]
        public void Setup()
        {
            NullobjectLogger logger = new();
            NullObjectThreadExecute threadExecute = new();
            LinkedList <string> ips= new LinkedList<string>();
            ips.AddLast("127.0.0.1");
            threadcreate = new global::ThreadOperation.ThreadOperation(ips, 10, logger: logger, threadOperation: threadExecute);
          //  threadcreate = new Create("127.0.0.1", 10, null,null);
        }

        [Test]
        public void ThreadPortRange()
        {

         var first=   threadcreate.SetThreadPortRange(0);

         var second = threadcreate.SetThreadPortRange(1);
          
            if (second.NextPort()== 6554 && first.NextPort()==1)
            {
                Assert.Pass();
            }
            Assert.Fail("ThreadPortRange  method not working right");
        }

        [Test]
        public void ThreadCreate()
        {

         var threadList =threadcreate.GenerateThread();
            if (threadList.Count==10 && threadList.FirstOrDefault().GetType().ToString()== "System.Threading.Thread")
            {
                Assert.Pass();
            }
            Assert.Fail("ThreadPortRange  method not working right");
        }

        [Test]
        public void ThreadRun()
        {
            _ = threadcreate.GenerateThread();
            threadcreate.ThreadRun();
            
        }
    }

}
