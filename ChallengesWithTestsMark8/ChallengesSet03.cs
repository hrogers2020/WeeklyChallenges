using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool i in vals)
            {
                if (i is false)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int A in numbers)
            {
                if (A % 2 != 0)
                {
                    sum = A + sum;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //created a bool variable for upper case, lower case, and digit.
            bool containsUpper = password.Any(char.IsUpper);
            bool containsLower = password.Any(char.IsLower);
            bool containsNumber = password.Any(char.IsDigit);

            //if statement that if you wanted true, then include all variable above
            if (containsUpper && containsLower && containsNumber)
            {
                return true;
            }
            return false;
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
            if (divisor is 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            var first = nums[0];
            var last = nums[nums.Length - 1];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var Odds = new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
            foreach (var number in Odds)
            {
                if (number % 2 != 0)
                {
                    return Odds; 
                }
            }
            return Odds;





            //var tempNums = new List<int> ();

            //for (int i = 1; i < 100;)
            //{
            //    tempNums.Add(i);
            //}
            //int[] nums = tempNums.ToArray();
            //return nums;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //foreach (var word in words)
            //{
            //    word.ToUpper();
            //}
        }
    }
}
