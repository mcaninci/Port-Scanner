using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreadOperation;

namespace Port_Scanner_Test
{
    class ThreadOperation
    {
        Create threadcreate;
        [SetUp]
        public void Setup()
        {
             threadcreate = new Create("127.0.0.1",10,null,null);
        }

        [Test]
        public void ThreadPortRange()
        {

         var a=   threadcreate.SetThreadPortRange(0);

         var b = threadcreate.SetThreadPortRange(1);
          int asd =  b.NextPort();

        }
    }
}
