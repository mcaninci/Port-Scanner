using Infrastructure.Data.Interface;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
            portRange = new PortRange(0, 2);
        }

        [Test]
        public void OpenPortTest()
        {
            bool connectionOpen= tcpR.Connect(5050);

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
           int first= portRange.NextPort();
           int second= portRange.NextPort();
           int last= portRange.NextPort();
            if (first==0 && second==1 && last==2)
            {
                Assert.Pass();
            }

            Assert.Fail("TCPRequest.Connect method not working right");
        }




    }
}
