using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }

            return false;

           //bool answer = false;
           // if (vals is null)
           // {
           //     return answer;
           // }
           // if (vals.Length % 2 == 0)
           // {
           //     return true;
           // }
           // return answer;
        }

        public bool IsNumberEven(int number)
        {
            //hit a wall or cant figure it out
            //break it down as small as possible
            //Do I know what this is asking me?....no?
                //return type:
                    // I know I need to return a T or F answer
                //parameter:
                    //I know they are giving me a number
                //method name:
                    //Is that number even?
                //odd return false

            //how do I determine if number is odd or even?


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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //double Max = 0;
            if ( numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();



            

            //if (numbers.Count is null)
            //{
            //    return 0;
            //}
            //if (numbers.Count() == 0 || numbers is null)
            //{
            //    return 0;
            //}
            //foreach (var number in numbers)
            //{
            //    if (number > Max)
            //    {
            //        Max = number;
            //    }
            //    if (number < Min)
            //    {
            //        Min = number;
            //    }
            //}
            //return Max + Min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
           else
            {
                return str2.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            //Linq
            //return numbers.Sum();                          
            int answer = 0;
            if (numbers is null)
            {
                return 0;
            }
            foreach (var number in numbers)
            {
                answer += number;
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers is null)
            {
                return 0;
            }
            //int answer = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        answer += number;
            //    }
            //}
            //return answer;
            //Linq
            return numbers.Where(number => number % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers is null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);

            //int sum = 0;
            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}
            //if (sum % 2 == 0)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
