using System;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_1
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 1 executed.\n");

            // Question 1A — Irish Mobile Validator
            Console.WriteLine(IrishMobileValidator("0831234567"));   // True
            Console.WriteLine(IrishMobileValidator("083 1234567"));  // False
            Console.WriteLine(IrishMobileValidator("0812345678"));   // False

            // Question 1B — Discount Calculator
            Console.WriteLine(Question1B("Gold"));    // 20
            Console.WriteLine(Question1B("Silver"));  // 10
            Console.WriteLine(Question1B("Bronze"));  // 5      
            Console.WriteLine(Question1B("None"));    // 0
        }

        //
        //  QUESTION 1A — Irish Mobile Validator
        //
        public static bool IrishMobileValidator(string number)
        {
            if (string.IsNullOrEmpty(number) || number.Length != 10)
                return false;

            string prefix = number.Substring(0, 3);

            switch (prefix)
            {
                case "083":
                case "085":
                case "089":
                    return Regex.IsMatch(number, @"^(083|085|089)\d{7}$");

                default:
                    return false;
            }
        }

        //
        //  QUESTION 1B — Discount Calculator
        //
        public static int Question1B(string membershipStatus)
        {
            switch (membershipStatus)
            {
                case "Gold":
                    return 20;

                case "Silver":
                    return 10;

                case "Bronze":
                    return 5;

                default:
                    return 0;  // None or unknown
            }
        }
    }
}
