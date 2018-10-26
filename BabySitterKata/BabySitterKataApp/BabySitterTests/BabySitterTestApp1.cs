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
        public void CheckStartTime()
        {
            int input = 5;// this will come from outside
            //act
            bool output = BabySitterTimeChecker.CheckStartTime(input);
            //assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void CheckEndTime()
        {
            //arrange
            int startTime = 5;// this will come from outside
            int endTime = 2;
            //act
            bool output = BabySitterTimeChecker.CheckEndTime(startTime, endTime);
            //assert
            Assert.AreEqual(true, output);
        }

        [Test]
        public void FamilyAPayTest()
        {
            int startTime = 5;
            int endTime = 2;

            FamilyA familyA = new FamilyA();
            int output = familyA.MoneyEarned(startTime, endTime);
            //assert
            Assert.AreEqual(150, output);
        }

        [Test]
        public void FamilyBPayTest()
        {
            int startTime = 5;
            int endTime = 2;
            FamilyB familyB = new FamilyB();
            int output = familyB.MoneyEarned(startTime, endTime);
            //assert
            Assert.AreEqual(108, output);
        }

        [Test]
        public void FamilyCPayTest()
        {
            int startTime = 5;
            int endTime = 2;
            FamilyC familyC = new FamilyC();
            int output = familyC.MoneyEarned(startTime, endTime);
            //assert
            Assert.AreEqual(159, output);
        }
    }
}
