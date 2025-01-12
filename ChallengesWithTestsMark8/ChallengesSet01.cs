using System;
using System.ComponentModel;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
       

        public static bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      

        public static double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }
        

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
      

        public static int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1; 
            }
            else
            {
                return number2;
            }
        }


        public static long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }
       

        public static string GetGreeting(string nameOfPerson)
        { 
            return $"Hello, {nameOfPerson}";
        }
       

        public static string GetHey()
        {
            return "hey";
        }


        public static void Main(string[] args)
        {
            //week 1

            int a = 23;
            int b = 29;
            double c = 23.5;
            double d = 12.4;
            string e = "Brett";

            Add(a, b);

            Subtract(c, d);

            Multiply(a, b);

            GetGreeting(e);

            GetHey();

            GetSmallestNumber(a, b);

            AreTwoNumbersTheSame(a, b);

        }






    }
}