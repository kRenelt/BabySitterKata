using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitterKataApp.BabySitterTests
{
    class FamilyB
    {
        public int MoneyEarned(int startTime, int endTime)
        {
            int totalPay = 0;
            int payForTimeBetween5And10 = 12;
            int payForTimeBetween10and12 = 8;
            int payForTimeAfter12 = 16;

            int startingHour = startTime;
            int endingHour = endTime;

            int totalHoursWorked = 0;
            if (endingHour < startingHour)
                endingHour += 12;

            totalHoursWorked = endingHour - startingHour;
            Console.WriteLine("total hours worked = " + totalHoursWorked);

            if (endingHour <= 10)
            {
                totalPay = totalHoursWorked * payForTimeBetween5And10;
            }
            else if (endingHour <= 12)
            {
                int hoursWorkedBetweenStartAnd10 = 10 - startingHour;
                int tempHoursWorkedAfter10Before12 = 12 - hoursWorkedBetweenStartAnd10 - startingHour;
                totalPay += (hoursWorkedBetweenStartAnd10 * payForTimeBetween5And10) + (tempHoursWorkedAfter10Before12 * payForTimeBetween10and12);
            }
            else
            {
                int hoursWorkedBetweenStartAnd10 = 10 - startingHour;
                int tempHoursWorkedAfter10Before12 = 12 - hoursWorkedBetweenStartAnd10 - startingHour;
      
                totalPay += (hoursWorkedBetweenStartAnd10 * payForTimeBetween5And10) + (tempHoursWorkedAfter10Before12 * payForTimeBetween10and12) + (endTime * payForTimeAfter12);
            }

            return totalPay;
        }
    }
}
