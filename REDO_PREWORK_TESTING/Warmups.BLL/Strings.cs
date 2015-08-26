using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Warmups.BLL
{
    public class Strings
    {
        // Given a string name, e.g. "Bob", return a greeting of the form "Hello Bob!". 
        public string SayHi(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        //Abba 
        public string Abba(string a, string b)
        {
            return a + b + b + a; 
        }

        //MakeTags 
        public string MakeTags(string tag, string content)
        {
            return "<"+tag+">"+content+"</"+tag+">";
        }

        public string InsertWord(string container, string word)
        {
            return char.ToString(container[0]) + char.ToString(container[1]) + word + char.ToString(container[2]) + char.ToString(container[3]);
        }


        //multiple endings 
        public string MultipleEndings(string str)
        {
            return string.Format("{0}{0}{0}", str.Substring(str.Length - 2, 2));
        }

        //FirstHalf
        public string FirstHalf(string str)
        {
            int str_length = str.Length/2;
            return str.Substring(0, str_length); 
        }

        //TrimOne
        public string TrimOne(string str)
        {
            return str.Substring(1, str.Length - 2);
        }

        //LongInMiddle
        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return b + a + b; 
            }
            return a + b + a;
        }

        //RotateLeft2
        public string Rotateleft2(string str)
        {
            return str.Substring(2, str.Length - 2) + str.Substring(0, 2); 
        }
        
        //RotateRight2
        public string RotateRight2(string str)
        {
            return str.Substring(str.Length - 2, 2) + str.Substring(0, str.Length - 2);
        }

        //TakeOne 
        public string TakeOne(string str, bool fromFront)
        {
            if (str.Length > 1)
            {
                if (fromFront == true)
                {
                    //return str.Substring(0);
                    return str[0].ToString();
                }

                else
                {
                    return str[str.Length - 1].ToString();
                }
            }
            return "";
        }

        //MiddleTwo 
        public string MiddleTwo(string str)
        {
            if (str.Length > 1)
            {
                int middle = str.Length/2 - 1;
                return str.Substring(middle, 2);
            }
            else if (str.Length == 1)
            {
                return str;
            }
            else
            {
                return "";
            }
        }

        //EndsWithLy
        public bool EndsWithLy(string str)
        {
            if (str.Length > 2)
            {
                if (str[str.Length - 2] == 'l' && str[str.Length-1] == 'y')
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        //Front&Back -- return front and back 
        public string FrontAndBack(string str, int n)
        {
            Console.WriteLine(str.Length);
            return str.Substring(0, n) + str.Substring(str.Length - n, n); 
        }

        //Take 2 From Position 
        public string TakeTwoFromPosition(string str, int n)
        {
            if (n + 2 > str.Length)
            {
                return str.Substring(0, 2); 
            }
            else
            {
                return str.Substring(n, 2);
            }
        }

        //HasBad 
        public bool HasBad(string str)
        {
            if (str.Substring(0, 3) == "bad" || str.Substring(1, 3) == "bad")
            {
                return true; 
            }
            return false; 
        }

        //AtFirst 
        public string AtFirst(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            }
            else if (str.Length == 1)
            {
                return str + "@";
            }
            else
            {
                return "@@";
            }
        }

        //Concat
        public string Concat(string a, string b)
        {
            if (a == "" || b == "")
            {
                return a + b; 
            }
            else if (a[a.Length - 1] == b[0])
            {
                return a.Substring(0, a.Length - 1) + b;
            }
            else
            {
                return a + b;
            }
        }

        //Swaplast
        public string SwapLast(string str)
        {
            return str.Substring(0, str.Length - 2) + 
                   str.Substring(str.Length - 1, 1) +
                   str.Substring(str.Length - 2, 1);
        }

        //FrontAgain
        public bool FrontAgain(string str)
        {
            if (str.Substring(0, 2) == str.Substring(str.Length - 2, 2))
            {
                return true; 
            }
            return false; 
        }

        //MinChat 
        public string MinCat(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return a.Substring(a.Length - b.Length, b.Length) + b; 
            } 
            else if (a.Length < b.Length)
            {
                return a + b.Substring(b.Length-a.Length,a.Length);
            }
            else
                return a + b;
        }

        //TweakFront
        /*Given a string, return a version without the first 2 chars. 
        Except keep the first char if it is 'a' and keep the second char if it is 'b'. 
        The string may be any length.*/ 
        public string TweakFront(string str)
        {
            if (str[0] == 'a' && str[1] != 'b')
            {
                return str.Substring(0,1) + str.Substring(2, str.Length - 2);
            }
            else if (str[0] != 'a' && str[1] == 'b')
            {
                return str[1] + str.Substring(2, str.Length - 2);
            }
            else if (str[0] == 'a' && str[1] == 'b')
            {
                return str[0].ToString() + str[1].ToString() + str.Substring(2, str.Length - 2);
            }
            else 
                return str.Substring(2, str.Length-2);
        }

        //StripX 
        public string StripX(string str)
        {
            string answer = "";

            if (str[0] != 'x')
            {
                answer += str.Substring(0,str.Length-1);
            }
            else
            {
                answer += str.Substring(1, str.Length - 2);
            }

            if (str[str.Length-1]!='x')
            {
                answer += str[str.Length-1].ToString();
            }
            return answer;
        }

    }
}
