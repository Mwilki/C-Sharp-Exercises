using System;

namespace Warmups.BLL
{
    public class Arrays
    {
        // Given an array of ints, return true if 6 appears as either the first or last element in the array. The array will be length 1 or more. 
        public bool FirstLast6(int[] numbers)
        {
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }
        // Given an array of ints, return true if the array is length 1 or more, and the first element and the last element are equal. 
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length >= 1)
            {
                return (numbers[0] == numbers[numbers.Length - 1]);
            }
            else return false;
        }
        // Return an int array length n containing the first n digits of pi.
        public int[] MakePi(int n)
        {
            double pi = Math.PI;
            var pied = pi.ToString().Remove(1, 1);
            var chararray = pied.ToCharArray();
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(chararray[i].ToString());
            }
            return numbers;
        }
        // Given 2 arrays of ints, a and b, return true if they have the same first element or they have the same last element. Both arrays will be length 1 or more.
        public bool CommonEnd(int[] a, int[] b)
        {
            return (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1]);
        }
        // Given an array of ints, return the sum of all the elements. 
        public int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        // Given an array of ints, return an array with the elements "rotated left" so {1, 2, 3} yields {2, 3, 1}.
        public int[] RotateLeft(int[] numbers)
        {
            int[] rotate = new int[numbers.Length];
            for (int i = 0; i < rotate.Length - 1; i++)
            {
                rotate[i] = numbers[i + 1];
            }
            rotate[numbers.Length - 1] = numbers[0];
            return rotate;
        }
        // Given an array of ints length 3, return a new array with the elements in reverse order, so for example {1, 2, 3} becomes {3, 2, 1}. 
        //         [TestCase(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        public int[] Reverse(int[] numbers)
        {
            int[] intR = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                intR[i] = numbers[numbers.Length - 1 - i];
            }
            return intR;

        }
        /*
         *    if (numbers[2] > numbers[0])
            {
                numbers[0] = numbers[2];
                numbers[1] = numbers[2];
            } else
            {
                numbers[1] = numbers[0];
                numbers[2] = numbers[0];
            }
         * 
         * */
        public int[] HigherWins(int[] numbers)
        {
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[0];
                }
            }
            else
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[numbers.Length - 1];
                }
            }
            return numbers;

        }
        // Given 2 int arrays, a and b, each length 3, return a new array length 2 containing their middle elements. 
        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] allMiddle = new int[2];
            allMiddle[0] = a[1];
            allMiddle[1] = b[1];
            return allMiddle;
        }

        // Given an int array, return true if it contains an even number(HINT: Use Mod (%)). 
        public bool HasEven(int[] numbers)
        {
            bool numberEvens = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numberEvens = true;
                }
            }
            return numberEvens;
        }
        // Given an int array, return a new array with double the length where its last element is the same as the original array, and all the other elements are 0. The original array will be length 1 or more. Note: by default, a new int array contains all 0's.
        public int[] KeepLast(int[] numbers)
        {
            int[] zeroButLast = new int[numbers.Length * 2];
            zeroButLast[zeroButLast.Length - 1] = numbers[numbers.Length - 1];
            return zeroButLast;
        }

        // Given an int array, return true if the array contains 2 twice, or 3 twice.
        public bool Double23(int[] numbers)
        {
            int twoCount = 0;
            int threeCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 2)
                {
                    twoCount += 1;
                }
                if (numbers[i] == 3)
                {
                    threeCount += 1;
                }
            }
            if (twoCount == 2 || threeCount == 2)
            {
                return true;
            }
            return false;
        }
        // Given an int array length 3, if there is a 2 in the array immediately followed by a 3, set the 3 element to 0. Return the changed array. 
        public int[] Fix23(int[] numbers)
        {

            if (numbers[0] == 2 && numbers[1] == 3)
                numbers[1] = 0;
            if (numbers[1] == 2 && numbers[2] == 3)
                numbers[2] = 0;
            return new int[] { numbers[0], numbers[1], numbers[2] };


        }
        // We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
        // Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.

        public bool Unlucky1(int[] numbers)
        {
            bool unlucky = false;
            if (numbers.Length == 0 || numbers.Length == 1)
                unlucky = false;
            else if ((numbers[0] == 1 && numbers[1] == 3) ||
                     (numbers[1] == 1 && numbers[2] == 3) ||
                     (numbers[numbers.Length - 1] == 3 &&
                      numbers[numbers.Length - 2] == 1))
                unlucky = true;

            return unlucky;
        }

        public int[] Make2(int[] a, int[] b)
        {
            int[] myArray = new int[2];
            if (a.Length == 0)
            {
                myArray[0] = b[0];
                myArray[1] = b[1];
            }
            else if (a.Length == 1 && b.Length == 1)
            {
                myArray[0] = a[0];
                myArray[1] = b[0];
            }
            else if (a.Length == 1)
            {
                myArray[0] = a[0];
                myArray[1] = b[0];
            }
            else
            {
                myArray[0] = a[0];
                myArray[1] = a[1];
            }
            return myArray;
        }
    }
}
