using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKataApp.BabySitterTests
{
    class FamilyC
    {
        public int MoneyEarned(int startTime, int endTime)
        {
            int totalPay = 0;
            int payForTimeBefore9 = 21;
            int payForTimeAfter9 = 15;

            int startingHour = startTime;
            int endingHour = endTime;

            int totalHoursWorked = 0;
            if (endingHour < startingHour)
                endingHour += 12;

            totalHoursWorked = endingHour - startingHour;

            if (endingHour > 9)
            {
                int hoursWorkedBetweenStartAnd9 = 9 - startingHour;
                int hoursWorkedAfter9 = endingHour - 9;
                totalPay += (hoursWorkedBetweenStartAnd9 * payForTimeBefore9) + (hoursWorkedAfter9 * payForTimeAfter9);
            }
            else
            {
                int hoursWorkedBetweenStartAnd9 = 9 - startingHour;

                totalPay = hoursWorkedBetweenStartAnd9 * payForTimeBefore9;
            }

            return totalPay;
        }
    }
}
