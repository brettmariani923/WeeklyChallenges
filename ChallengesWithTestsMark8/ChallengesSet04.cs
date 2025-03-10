using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            int difference = 0;

            foreach (int number in numbers)
                if (number % 2 == 0)
                { sum += number; }
                else
                { difference -= number; }

            return sum + difference;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int answer = 0;

            foreach (char letter in str1)
            { val1++; }

            foreach (char letter in str2)
            { val2++; }

            foreach (char letter in str3)
            { val3++; }

            if (val1 > val2 && val1 > val3)
            { answer += val1; }
            else if (val2 > val1 && val2 > val3)
            { answer += val2; }
            else
            { answer += val3; }

            return answer;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNumber = 0;
            if (number1 < number2 && number1 < number3 && number1 < number4)
            { smallestNumber += number1; }
            else if (number2 < number1 && number2 < number3 && number2 < number4)
            { smallestNumber += number2; }
            else if (number3 < number1 && number3 < number2 && number3 < number4)
            { smallestNumber += number3; }
            else if (number4 < number1 && number4 < number2 && number4 < number3)
            { smallestNumber += number4; }


            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            double result = 0;
            return double.TryParse(input, out result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            int duds = 0;
            int good = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                { duds++; }
                else
                { good++; }
            }
            return duds > good;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double count = 0;
            foreach (int number in numbers)
                if (number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
            return sum / count;
        }

        public int Factorial(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            { result *= i; }

            return result;
        }
    }
}
