using IpOperation;
using NUnit.Framework;
using System.Collections.Generic;

namespace Port_Scanner_Test
{
    public class IpOpreation
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IpConvertMethods()
        {
            string strIp = "192.168.1.1";
            long lIp = IpOperation.Convert.ToIpInt(strIp);
            string responseIp = IpOperation.Convert.ToIpString(lIp);
           

            if (strIp == responseIp)
            {
                Assert.Pass();
            }

            Assert.Fail("Convert method not working right");
        }



        [Test]
        public void IpRangeValidation()
        {
            string ipMin = "192.168.1.1";

            string ipMax = "192.168.1.2";
         
            bool validation1 = IpValidation.IsRangeValid(ipMin, ipMax);

            bool validation2 = IpValidation.IsRangeValid(ipMax, ipMin);

            if (validation1 == true && validation2==false)
            {
                Assert.Pass();
            }
            Assert.Fail("IpRangeValidation method not working right");
        }

        [Test]
        public void RangeToIpList()
        {
            string ipMin = "192.168.1.1";

            string ipMax = "192.168.1.3";

            LinkedList<string> ipList= IpOperation.Convert.RangeToIpList(ipMin,  ipMax);

             ipMin = "0.0.0.0";
            ipMax = "0.0.1.0";
            LinkedList<string> ipList2 = IpOperation.Convert.RangeToIpList(ipMin, ipMax);
            if (ipList.Count==3 && ipList2.Count==257)
            {
                Assert.Pass();
            }
            Assert.Fail("RangeToIpList method not working right");
        }

        

    }
}