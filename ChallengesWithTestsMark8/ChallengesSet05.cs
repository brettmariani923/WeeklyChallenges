using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            
            if (startNumber == 1)
            {
                startNumber += n - 1;
            }
           
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

       
        
        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return false;
            }

            if (numbers.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return 0;
            }
            
            int y = 0;
            for (int i = 0; i < numbers.Length -1; i++)
                if (numbers[i] % 2 == 0)
                {
                    y += numbers[i + 1];
                }

            return y;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            List<string> sentences = new List<string>();

            if (words == null || words.Length < 1)
            {
                return string.Empty;
            }

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    sentences.Add(word.Trim());
                }
            }

            if (sentences.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(" ", sentences) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var holder = new List<double>();

            if (elements == null || elements.Count < 4)
            {
                return Array.Empty<double>();
            }

            for (int i = 3; i < elements.Count; i += 4)
            {
                holder.Add(elements[i]);
            }

            return holder.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int value = 0;

            if (nums == null || nums.Length <= 1)
            {
                return false;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                value = targetNumber - nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[j] == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
