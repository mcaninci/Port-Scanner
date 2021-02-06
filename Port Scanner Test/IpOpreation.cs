using IpOperation;
using NUnit.Framework;

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
            long lIp = IpOperation.Convert.ToInt(strIp);
            string responseIp = IpOperation.Convert.ToString(lIp);
           

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
            IpValidation validetion = new ();

            bool validation1 = validetion.isRangeValid(ipMin, ipMax);

            bool validation2 = validetion.isRangeValid(ipMax, ipMin);

            if (validation1 == true && validation2==false)
            {
                Assert.Pass();
            }
            Assert.Fail("IpRangeValidation method not working right");
        }



    }
}