using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.VisualBasic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Count() % 2 == 0)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
        }
        
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
           double min = numbers.Min();
           double max = numbers.Max();
           Console.WriteLine(min + max);
           return min + max;
           
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine(sum);
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;
            foreach (int number in numbers) 
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    evenSum += 0;
                }
            }
            Console.WriteLine(evenSum);
            return evenSum;
        }
        
         public bool IsSumOdd(List<int> numbers)
    
        {
            int sum = 0;
            foreach (int number in numbers) 
            {
                sum += number;
            }

            if (sum % 2 == 1) return true;
            {
                Console.WriteLine("true");
                
            }
            if (sum % 2 == 0) return false;
             
            {
                Console.WriteLine("false");
                return false;
            }
        }
    
        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
           
            for (int i = 1; i < number; i += 2)
            {
                count++;
            }
            return count;
        }

        public void Main(string[] args)
        {
            Console.WriteLine(CountOfPositiveOddsBelowNumber(25));
            Console.WriteLine(GetLengthOfShortestString("puppy", "kitten"));
            Console.WriteLine(IsNumberEven(25));
            Console.WriteLine(IsNumberOdd(25));
            Console.WriteLine(CharacterIsALetter('a'));
            IsSumOdd(numbers: new List<int>());
            SumEvens(new int[23]);
        }
    }
}
