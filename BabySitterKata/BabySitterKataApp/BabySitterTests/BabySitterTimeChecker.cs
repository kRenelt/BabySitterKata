using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BabySitterKataApp.BabySitterTests
{
    class BabySitterTimeChecker
    {
        internal static bool checkStartTime(int startTime)
        {
            if (startTime >= 5)
                return true;
            else
                return false;
        }

        internal static bool checkEndTime(int endTime)
        {
            if (endTime <= 4)
                return true;
            else
                return false;
        }
    }
}
