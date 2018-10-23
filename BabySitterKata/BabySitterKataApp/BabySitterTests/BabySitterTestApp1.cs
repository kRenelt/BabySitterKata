using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BabySitterKataApp.BabySitterTests
{
    [TestFixture]
    public class BabySitterTestApp1
    {
        [Test]
        public void checkStartTime()
        {
            int input = 1;
            //act
            string output = BabySitterTimeChecker.checkHours(input);
            //assert
            Assert.AreEqual("1", output);
        }

        [Test]
        public void checkEndTime()
        {
            //arrange
            int input = 1;
            //act
            string output = BabySitterTimeChecker.checkHours(input);
            //assert
            Assert.AreEqual("1", output);
        }
    }
}
