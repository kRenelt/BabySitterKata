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
            Console.WriteLine("Please Enter Start Time");
            string startTimeString = Console.ReadLine();
            int startTime = Int32.Parse(startTimeString);
            Console.WriteLine("Please enter an end time");
            string endTimeString = Console.ReadLine();
            int endTime = Int32.Parse(endTimeString);
            FamilyA familyA = new FamilyA();
            FamilyB familyB = new FamilyB();

            // int totalEarned = familyA.moneyEarned(startTime, endTime);
            int totalEarned = familyB.moneyEarned(startTime, endTime);
            Console.WriteLine("you earned = " + totalEarned);

            Console.ReadLine();
        }
    }
}
