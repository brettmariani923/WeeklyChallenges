using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word == null)
            {
                return false; 
            }

            foreach (string testWord in words)
            {
                if (testWord == null)
                {
                    continue; 
                }
                
                if (ignoreCase)
                {
                    if (testWord.ToLower() == word.ToLower())
                    {
                        return true;
                    }
                }
                else
                {
                    if (testWord == word)
                    {
                        return true;
                    }
                }
            }
            
            return false; 
        }
        
    public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; 
                }
            }
            return true; 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            
            foreach (char c in str)
            {
                if (letterCount.ContainsKey(c))
                {
                    letterCount[c]++;
                }
                else
                {
                    letterCount[c] = 1;
                }
            }
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (letterCount[str[i]] == 1) 
                {
                    return i;
                }
            }
            
            return -1; 
            }
        

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;  
            int currentCount = 1; 

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1]) 
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);  
                    currentCount = 1; 
                }
            }
            
            maxCount = Math.Max(maxCount, currentCount);

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return Array.Empty<double>(); 
            }
            
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
            
        }
    }
}
