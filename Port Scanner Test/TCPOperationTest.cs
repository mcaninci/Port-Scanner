using Infrastructure.Data.Interface;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TCPOperation;


namespace Port_Scanner_Test
{
    public class TCPOperationTest
    {
        TCPRequest tcpR = null;
        IPortRange portRange;
        [SetUp]
        public void Setup()
        {
            tcpR = new TCPRequest("127.0.0.1");
            portRange = new PortRange(1, 100);
        }


        [Test]
        public void PerformanceTest()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (true)
            {
                if (!portRange.MorePorts())
                {
                    break;
                }


                int portNum = portRange.NextPort();
                tcpR.Connect(portNum);
            }
            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);
         
        }

        [Test]
        public void OpenPortTest()
        {
            bool connectionOpen = tcpR.Connect(5050);

            if (connectionOpen)
            {
                Assert.Pass();
            }

            Assert.Fail("TCPRequest.Connect method not working right");
        }

        [Test]
        public void ClosePortTest()
        {
            bool connectionOpen = tcpR.Connect(1);

            if (!connectionOpen)
            {
                Assert.Pass();
            }

            Assert.Fail("TCPRequest.Connect method not working right");
        }


        [Test]
        public void PortRangeTest()
        {
            int first = portRange.NextPort();
            int second = portRange.NextPort();
            int last = portRange.NextPort();
            if (first == 1 && second == 2 && last == 3)
            {
                Assert.Pass();
            }

            Assert.Fail("TCPRequest.Connect method not working right");
        }




    }
}
