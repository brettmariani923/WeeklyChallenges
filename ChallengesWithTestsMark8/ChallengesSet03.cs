using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Sockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (!val) 
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            
            if (numbers == null) return false;
            
            foreach (var number in numbers)
            {
                sum += number;
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            
            bool containsUpper = false;
            bool containsLower = false;
            bool containsDigit = false;

            foreach (char instance in password)
            {
                if (char.IsUpper(instance)) 
                {
                    containsUpper = true;
                }
                if (char.IsLower(instance))
                {
                    containsLower = true;
                }

                if (char.IsDigit(instance))
                {
                    containsDigit = true;
                }
            }
            return containsUpper && containsLower && containsDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            {
                int[] odds = new int[50]; 
                int num = 0;

                for (int i = 1; i < 100; i += 2)
                {
                    odds[num] = i; 
                    num++; 
                }

                return odds;
            }
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != null)
                {
                    words[i] = words[i].ToUpper();
                }
            }
        }
    }
}
