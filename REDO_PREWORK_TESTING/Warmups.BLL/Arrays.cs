using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Arrays
    {
        /* Given an array of ints, return true if 6 appears 
           as either the first or last element in the array. 
           The array will be length 1 or more. 
        */
        public bool FirstLast6(int[] numbers)
        {
            // 0 is always the first index and 
            // Length - 1 of an array is always the last index
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }

        //SameFirstLast 
        public bool SameFirstLast(int[] numbers)
        {
            if (numbers.Length > 1 && numbers[numbers.Length - 1] == numbers[0])
            {
                return true; 
            }
            return false; 
        }

        //MakePi 
        public int[] MakePi(int n)
        {
            string pi = Math.PI.ToString();
            pi = pi.Replace(".", "");
            Console.WriteLine(pi);
            pi = pi.Substring(0, n);
            Console.WriteLine(pi);
            int[] pi_array = new int[n];
            for (int i = 0; i < n; i++)
            {
                pi_array[i] = int.Parse(pi[i].ToString());
            }
            return pi_array;
        }

        //CommonEnd
        public bool CommonEnd(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length-1])
            {
                return true; 
            }
            return false; 
        }

        //Sum
        public int sum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number; 
            }
            return sum; 
        }

        //RotateLeft
        public int[] RotateLeft(int[] numbers)
        {
            int[] result = new int[3];
            for (int i = 1; i < numbers.Length; i++)
            {
                result[i - 1] = numbers[i];
            }
            result[result.Length - 1] = numbers[0];
            return result; 
        }

        //Reverse 
        public int[] Reverse(int[] numbers)
        {
            int[] reverse_numbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                reverse_numbers[i] = numbers[numbers.Length - 1 - i];
            }
            return reverse_numbers; 
        }

        //HigherWins 
        public int[] HigherWins(int[] numbers)
        {
            int bigger_number = 0;
            int i = 0; 
            int[] result = new int[numbers.Length];
            if (numbers[0] > numbers[numbers.Length - 1])
            {
                bigger_number = numbers[0];
            }
            else
            {
                bigger_number = numbers[numbers.Length - 1];
            }
            foreach (var num in numbers)
            {
                result[i] = bigger_number;
                i++; 
            }
            return result; 
        }

        public int[] GetMiddle(int[] a, int[] b)
        {
            int[] new_array = new int[2];
            new_array[0] = a[1];
            new_array[1] = b[1];
            return new_array;
        }

        public bool HasEven(int[] numbers)
        {
            foreach(var x in numbers)
            {
                if (x%2 == 0)
                    return true; 
            }
            return false; 
        }

        public int[] KeepLast(int[] numbers)
        {
            int[] new_array = new int[numbers.Length*2];
            new_array[new_array.Length - 1] = numbers[numbers.Length-1];
            return new_array;
        }

        public bool Double23(int[] numbers)
        {
            int count_2 = 0;
            int count_3 = 0;

            foreach (var x in numbers)
            {
                if (x == 2)
                    count_2 ++;
                if (x == 3)
                    count_3 ++; 
            }

            if (count_2 == 2 || count_3 == 2)
            {
                return true; 
            }
            return false; 
        }

        public int[] Fix23(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == 2 && numbers[i] == 3)
                    numbers[i] = 0; 
            }
            return numbers;
        }

        public bool Unlucky1(int[] numbers)
        {
            Console.WriteLine("1st {0} and 2nd {1}", numbers[numbers.Length - 2], numbers[numbers.Length - 1]);
            for (int i = 0; i <= 1; i++)
            {
                if (numbers[0 + i] == 1 && numbers[1 + i] == 3)
                    return true;
                else if (numbers[numbers.Length - 2 - i] == 1 && numbers[numbers.Length - 1 - i] == 3)
                {
                    return true;
                }
            }
            return false; 
        }

        public int[] make2(int[] a, int[] b)
        {
            int[] result = new int[2];
            int remain = 0;

            if (a.Length < 2)
            {
                remain = 2 - a.Length;

                for (int i = 0; i < a.Length; i++)
                {
                    result[i] = a[i];
                }
                for (int i = 0; i < remain; i++)
                {
                    result[2 - remain + i] = b[i];
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    result[i] = a[i];
                }
            }
            return result;
        }

    }
}
