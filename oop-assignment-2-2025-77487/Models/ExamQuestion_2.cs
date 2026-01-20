using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_000000.Models
{
    public static class ExamQuestion_2
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 2 executed.");
            //run DivideIntegers sample
            Console.WriteLine(DivideIntegers(10, 2)); // Should print 5
            Console.WriteLine(DivideIntegers(10, 0)); // Should print "Cannot divide by zero"
        }
        public static void SampleQuestionMethod()
        {
            // Sample method implementation
            Console.WriteLine("SampleMethod");
        }


        //  Question 2A — Write a method with supporting unit tests that divides two integers if the user tries to divide by zero, catch the exception and return the message "Cannot divide by zero".
        public static string DivideIntegers(int numerator, int denominator)
        {
            try
            {
                int result = numerator / denominator;
                return result.ToString();



            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero";
            }
        }
    }
}
