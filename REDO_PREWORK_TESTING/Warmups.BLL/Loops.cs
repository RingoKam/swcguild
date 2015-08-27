using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Loops
    {
        /* Given a string and a non-negative int n, return a 
           larger string that is n copies of the original string. 
        */

        public string StringTimes(string str, int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += str;
            }

            return result;
        }

        // string times 
        public string FrontTimes(string str, int n)
        {
            string answer = "";

            if (str.Length > 3)
            {
                for (int i = 0; i < n; i++)
                {
                    answer += str.Substring(0, 3);
                }
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    answer += str.Substring(0, str.Length);
                }
            }
            return answer;
        }

        //count XX
        public int countXX(string str)
        {
            int count = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == 'x' && str[i] == 'x')
                {
                    count++;
                }
            }
            return count;
        }

        //DoubleX
        public bool DoubleX(string str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == 'x') // find first element of x 
                {
                    if (str[i - 1] == 'x' && str[i] == 'x') // check if next element equal x, if not, return false
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        //EveryOther 
        public string EveryOther(string str)
        {
            string answer = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i%2 == 0)
                {
                    answer += str[i].ToString();
                }
            }
            return answer;
        }

        //String Splosion 
        public string StringSplosion(string str)
        {
            //return 1, return 2, return 3 
            string answer = "";

            for (int i = 0; i < str.Length; i++) //how many character it print 
            {
                for (int o = 0; o <= i; o++) //
                {
                    answer += str[o].ToString();
                }
            }
            return answer;
        }

        //Count Last 2: 
        public int CountLast2(string str)
        {
            int count = 0;

            if (str.Length <= 2)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < str.Length - 2; i++)
                {
                    if (str.Substring(i, 2) == str.Substring(str.Length - 2, 2))
                    {
                        count++;
                        // Console.WriteLine("{0} vs {1}", str.Substring(i, 2), str.Substring(str.Length - 2, 2));
                    }
                }
            }
            return count;
        }

        //count9 
        public int Count9(int[] numbers)
        {
            int count = 0;
            Console.WriteLine(numbers.Length);
            //for (int i = 0; i < numbers.Length; i++)
            foreach (int x in numbers)
            {
                if (x == 9)
                {
                    count++;
                }
            }
            return count;
        }

        //ArrayFront9
        public bool ArrayFront9(int[] numbers)
        {
            if (numbers.Length < 4)
            {
                foreach (int x in numbers)
                {
                    if (x == 9)
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (numbers[i] == 9)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Array123
        public bool Array123(int[] numbers)
        {
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i - 2] == 1 && numbers[i - 1] == 2 && numbers[i] == 3)
                {
                    return true;
                }
            }
            return false;
        }

        //SubStringMatch
        public int SubStringMatch(string a, string b)
        {
            int count = 0;

            for (int i = 1; i < compareLength(a, b); i++)
            {
                if (a[i] == b[i] && a[i - 1] == b[i - 1])
                {
                    count++;
                }
            }
            return count;
        }

        public int compareLength(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return a.Length;
            }
            else
            {
                return b.Length;
            }
        }

        //stringX 
        public string StringX(string str)
        {
            string string_copy = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (0 < i && i < str.Length - 1)
                {
                    if (str[i] != 'x')
                    {
                        string_copy += str[i];
                    }
                }
                else
                {
                    string_copy += str[i];
                }
            }
            str = string_copy;
            return str;
        }

        //AltPairs 
        public string AltPairs(string str)
        {
            string string_copy = "";
            for (int i = 0; i < str.Length; i += 4)
            {
                string_copy += str.Substring(i, testStringLimit(i, str));
            }
            str = string_copy;
            return str;
        }

        public int testStringLimit(int i, string str)
        {
            if (i + 1 > str.Length - 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        //DoNotYak 
        // if yak, move 3 position 
        public string DoNotYak(string str)
        {
            int count = 0;
            List<string> solution = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                if (i + 2 < str.Length)
                {
                    if (str[i] == 'y' && str[i + 2] == 'k')
                    {
                        string saved_variable = str.Substring(i, 3);
                        solution.Add(saved_variable);
                    }
                }
                foreach (var yak in solution)
                {
                    str = str.Replace(yak, "");
                }
            }
            return str;
        }

        //Array667
        public int Array667(int[] numbers)
        {
            int count = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1] && numbers[i - 1] == 6 || numbers[i - 1] == 6 && numbers[i] == 7)
                {
                    count++;
                }
            }
            return count;
        }

        //NoTriples
        public bool NoTriples(int[] numbers)
        {
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1] && numbers[i - 1] == numbers[i - 2])
                {
                    return false;
                }
            }
            return true;

        }

        //Pattern51 
        public bool Pattern51(int[] numbers)
        {
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i - 1] - numbers[i - 2] == 5 && numbers[i - 2] - numbers[i] == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

