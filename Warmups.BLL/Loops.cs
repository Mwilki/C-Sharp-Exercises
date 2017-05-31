using System;

namespace Warmups.BLL
{
    public class Loops
    {

        public string StringTimes(string str, int n)
        {
            string repeat = "";
            for (int i = 0; i < n; i++)
            {
                repeat += str;
            }
            return repeat;
        }

        public string FrontTimes(string str, int n)
        {
            string result = "";
            if (str.Length <= 3)
                for (int i = 0; i < n; i++)
                    result += str;
            else
                for (int i = 0; i < n; i++)
                    result += str.Substring(0, 3);
            return result;
        }

        public int CountXX(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length -1; i++)
            {
                if (str[i] == 'x')
                {
                    count++;
                }
            }
            return count;
        }

        public bool DoubleX(string str)
        {
            int i = str.IndexOf("x");
            if (i == -1) return false;
            string x = str.Substring(i);
            return x.StartsWith("xx");
        }

        public string EveryOther(string str)
        {
            string everyOther = "";
            for (int i = 0; i < str.Length; i+=2)
            {
                everyOther += str[i];
            }
            return everyOther;
        }

        public string StringSplosion(string str)
        {
            string repeat = "";
            for (int i = 0; i < str.Length + 1; i++)
            {
                repeat += str.Substring(0, i);
            }
            return repeat;
        }

        public int CountLast2(string str)
        {
            int count = 0;
            string lastTwo = str.Substring(str.Length-2);
            for (int i = str.Length - 2; i > 0; i--)
            {
               if (str.Substring(i - 1, 2) == lastTwo)
                {
                    count++;
                }
            }
            return count;
        }

        public int Count9(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 9)
                    count++;
            }
            return count;
        }

        public bool ArrayFront9(int[] numbers)
        {
            for (int i = 0; i < 4 && i < numbers.Length; ++i)
            {
                if (numbers[i] == 9)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Array123(int[] numbers)
        {
            bool oneTwoThree = false;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 1 && numbers[i+1] == 2 && numbers[i+2] == 3)
                    oneTwoThree = true;
            }
            return oneTwoThree;
        }

        public int SubStringMatch(string a, string b)
        {
            int count = 0;
            if (a.Length > 3)
            {
                for (int i = 0; i < a.Length - 2; i++)
                {
                    if (a.Substring(i, 2) == b.Substring(i, 2))
                    {
                        count++;
                    }
                }
            } else
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a.Substring(i, 2) == b.Substring(i, 2))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public string StringX(string str)
        {

            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] == 'x')
                {
                    str = str.Remove(i, 1);
                    i = i - 1;
                }
            }
            return str;
        }

        public string AltPairs(string str)
        {
            
            string shortened = "";
           for (int i = 0; i < str.Length; i += 4)
            {
                shortened += str[i];
                 if (i + 1 < str.Length)
                {
                    shortened += str[i + 1];
                }
              
            }
            return shortened;
        }

        public string DoNotYak(string str)
        {
            string noYak = "";
            for (int i = 0; i <= str.Length; i++)
            {
                if (i + 2 < str.Length && (str[i] == 'y' && str[i+1] == 'a' && str[i+2] == 'k'))
                {
                    noYak += str.Remove(i, 3);
                } 
            }
            return noYak;
        }

        public int Array667(int[] numbers)
        {
            int count = 0;
           for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] == 6 && numbers[i+1] == 6 || numbers[i+1] == 7)
                {
                    count++;
                }
            }
            return count;
        }

        public bool NoTriples(int[] numbers)
        {
            // instead of two returns just assign a boolean to true or false and return that boolean
            bool noTripples = true;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (i+2 < numbers.Length && numbers[i] == numbers[i + 1] && numbers[i] == numbers[i + 2])
                    noTripples = false;
            }
            return noTripples;
        }

        /*         

        [TestCase(new[] { 6, 4, 9, 3, 2 }, true)]

        */

        public bool Pattern51(int[] numbers)
        {
            bool hasPattern = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {

                if (numbers[i + 1] == numbers[i] + 5 && numbers[i + 2] == numbers[i] - 1)
                {
                    hasPattern = true;
                }

            }
            return hasPattern;
        }

    }
}
