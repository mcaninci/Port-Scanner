using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logger;

namespace Port_Scanner_Test
{
   public class LoggerTest
    {
        RichTextBox rchtxt;
        Logger.Logger logger;
     [SetUp]
        public void Setup()
        {
             rchtxt = new RichTextBox();
            rchtxt.Text = "Logger starting";
            logger = new();
            logger.SetTargetComp(rchtxt);
        }


        /// <summary>
        /// Test project is .net 5 because of that this case get error
        /// </summary>
        [Test]
        public void LoggerAppend()
        {
            int initialLength=rchtxt.Text.Length;
            logger.WriteLog("test test");
            int testLenght= rchtxt.Text.Length;
            string lastText = rchtxt.Text;

            if (testLenght > initialLength)
            {
                Assert.Pass();
            }

            Assert.Fail("Logger WriteLog method not working right");
        }


    }
}
