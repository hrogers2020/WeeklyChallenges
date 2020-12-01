using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //Linq:
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
            //OR:
            //var sum = 0;

            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        sum += num;
            //    }

            //    if (num % 2 != 0)
            //    {
            //        sum -= num;
            //    }
            //}
            //return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (double.TryParse(input, out double value))
            {
                return true;
            }
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int itemCount = objs.Length;
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null) nullCount++;
            }
            return nullCount > itemCount / 2;
            //OR
            //if (nullCount > itemCount / 2)
            //{
            //    return true;
            //}
            //return false;

        }

        public double AverageEvens(int[] numbers)
        {
            if ( numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenSum = 0;
            int evenCount = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                    evenCount++;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)evenSum / evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
            //if (number < 0) throw new ArgumentOutOfRangeException();
            //if (number == 0) return 1;
            //if (number > 1)
            //{
            //    return number + Factorial(number - 1);
            //}
            //else
            //{
            //    return number;
            //}
        }
    }
}
