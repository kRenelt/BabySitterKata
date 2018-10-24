using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKataApp.BabySitterTests
{
    class FamilyA
    {
        public int moneyEarned(int startTime, int endTime)
        {
            int totalPay = 0;
            int payForTimeBetween5And11 = 15;
            int payForTimeAfter11 = 20;

            int startingHour = startTime;
            int endingHour = endTime;

            int totalHoursWorked = 0;
            if (endingHour < startingHour)
                endingHour +=  12;

            totalHoursWorked = endingHour - startingHour;

            if (endingHour > 11)
            {
                int hoursWorkedBetweenStartAnd11 = 11 - startingHour;
                int hoursWorkedAfter11 = endingHour - 11;
                totalPay += (hoursWorkedBetweenStartAnd11 * payForTimeBetween5And11) + (hoursWorkedAfter11 * payForTimeAfter11);
            }
            else
            {
                int hoursWorkedBetweenStartAnd11 = 11 - startingHour;

                totalPay = hoursWorkedBetweenStartAnd11 * payForTimeBetween5And11;
            }

            return totalPay;
        }
    }
}
