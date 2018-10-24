﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitterKataApp.BabySitterTests;

namespace BabySitterKataApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEarned = 0;
            bool keepPlaying = true;
            do
            {
                Console.WriteLine("Please Enter Start Time.. eg 5, 6, 7");
                string startTimeString = Console.ReadLine();

                int startTime = Int32.Parse(startTimeString);
                if (startTime < 5)
                {
                    Console.WriteLine("We are sorry our babysitters cannot start until after 5:00 PM");
                    continue;
                }
                Console.WriteLine("Please enter an end time");
                string endTimeString = Console.ReadLine();
                int endTime = Int32.Parse(endTimeString);

                if (endTime > 4)
                {
                    Console.WriteLine("We are sorry our babysitters cannot Work after 4:00 AM");
                    continue;
                }

                Console.WriteLine("Please enter your Family type, A, B or C");
                string tempFamilyType = Console.ReadLine();
                string familyType = tempFamilyType.ToUpper();
      
                FamilyA familyA = new FamilyA();
                FamilyB familyB = new FamilyB();
                FamilyC familyC = new FamilyC();
                if (familyType == "A")
                    totalEarned = familyA.moneyEarned(startTime, endTime);
                else if (familyType == "B")
                    totalEarned = familyB.moneyEarned(startTime, endTime);
                else if (familyType == "C")
                    totalEarned = familyC.moneyEarned(startTime, endTime);

                Console.WriteLine("Total amount earned = " + totalEarned);
                Console.WriteLine("would you like to schedule another Apt'");
                string playAgain = Console.ReadLine();
                playAgain = playAgain.ToUpper();
               
                if (playAgain == "N")
                    keepPlaying = false;
            }
            while (keepPlaying);
        }
    }
}
