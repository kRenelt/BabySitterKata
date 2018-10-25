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
            int input = 5;// this will come from outside
            //act
            bool output = BabySitterTimeChecker.CheckStartTime(input);
            //assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void checkEndTime()
        {
            //arrange
            int input = 1;// this will come from outside
            //act
            bool output = BabySitterTimeChecker.CheckEndTime(input);
            //assert
            Assert.AreEqual(true, output);
        }
    }
}
