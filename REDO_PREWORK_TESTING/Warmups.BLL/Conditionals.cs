using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }

        public bool CanSleepIn(bool isWeekDay, bool isVacation)
        {
            if(isWeekDay==false || isVacation==true)
            {
                return true;
            }
            return false;
        }

        public int SumDouble(int a, int b)
        {
            if (a == b)
                return (a + b)*2;
            else
                return a + b; 
        }

        public int Diff21(int n)
        {
            if (n > 21)
                return Math.Abs(n - 21)*2;
            else
            {
                return Math.Abs(n - 21);
            }
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            if(isTalking)
                if (hour < 7 || hour > 20)
                {
                    return true; 
                }
            return false;
        }

        //Makes10
        public bool Makes10(int a, int b)
        {
            if ( (a == 10  && b!= a) || (b == 10 && b != a) || (b + a == 10))
            {
                return true; 
            }
            return false; 
        }

        //Near Hundred 
        public bool NearHundred(int n)
        {
            if (Math.Abs(n - 100) <= 10 || Math.Abs(n - 200) <= 10)
            {
                return true; 
            }
            return false; 
        }

        //NotString
        public string NotString(string s)
        {
            string s_copy = "";
            if (s.Length < 3 || s.Substring(0, 3) != "not")
            {
                s_copy += "not ";
            }
            s_copy += s; 
            return s_copy;
        }

        //Missing Char 
        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //FrontBack
        public string FrontBack(string str)
        {
            if (str.Length <= 1)
                return str;
            else
            {
                string str_copy = "";
                str_copy += str[str.Length - 1].ToString();
                for (int i = 1; i < str.Length - 1; i++)
                {
                    str_copy += str[i].ToString();
                }
                return str_copy + str[0];
            }
        }

        //Front3
        public string Front3(string str)
        {
            if (str.Length < 3)
                return str + str + str;
            else
            {
                string str_copy = str.Substring(0, 3);
                return str_copy + str_copy + str_copy; 
            }
        }

        //BackAround
        public string BackAround(string str)
        {
            string lastchar = str[str.Length - 1].ToString();

            return lastchar + str + lastchar;
        }

        //Multiple3or5
        public bool Multiple3or5(int number)
        {
            if (number%3 == 0 || number%5 == 0)
            {
                return true;
            }
            return false; 
        }

        //StartHi
        public bool StartHi(string str)
        {
            if (str.Substring(0, 2) == "hi")
                return true;
            return false; 
        }

        //IcyHot
        public bool IcyHot(int temp1, int temp2)
        {
            if ((temp1 < 0 && temp2 > 100 ) || (temp2 < 0 && temp1 > 100))
                return true;
            return false; 
        }

        //Between10and20
        public bool Between10and20(int a, int b)
        {
            if ((a <= 20 && a >= 10) || (b <= 20 && b >= 10))
            {
                return true; 
            }
            return false; 
        }

        //HasTeen 13 to 19
        public bool HasTeen(int a, int b, int c)
        {
            List<int> test_array = new List<int>() {a, b, c};
            foreach (var number in test_array)
            {
                if (number >= 13 && number <= 19)
                {
                    return true;
                }
            }
            return false; 
        }

        //SoAlone
        public bool SoAlone(int a, int b)
        {
            bool a_result = false;
            bool b_result = false; 

            if (a >= 13 && a <= 19)
            {
                a_result = true; 
            }
            if (b >= 13 && b <= 19)
            {
                b_result = true; 
            }
            if((a_result == true && b_result != true) || (a_result != true && b_result == true))
            {
                return true; 
            }
            return false; 
        }

        //RemoveDel
        public string RemoveDel(string str)
        {
            str = str.Replace("del", "");
            return str; 
        }

        //lxStart
        public bool IxStart(string str)
        {
            if (str.Substring(1, 2) == "ix")
            {
                return true;
            }
            return false; 
        }

        //StartOz
        public string StartOz(string str)
        {
            if (str[0] == 'o' && str[1] == 'z')
                return "oz";
            else if (str[0] == 'o' && str[1] != 'z')
                return "o";
            else if (str[0] != 'o' && str[1] == 'z')
                return "z";
            else
                return ""; 
        }

        //Max
        public int Max(int a, int b, int c)
        {
            int[] integers = new int[] {a,b,c};
            return integers.Max();
        }

        //Closer
        public int Closer(int a, int b)
        {
            if (Math.Abs(a - 10) > Math.Abs(b - 10))
                return b;
            else if (Math.Abs(a - 10) < Math.Abs(b - 10))
                return a;
            else
                return 0; 
        }
        
        //EEEEEEE
        public bool GotE(string str)
        {
            int e_count = 0; 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    e_count++; 
                }
            }
            if (e_count > 0 && e_count < 4)
                return true;
            else
                return false; 
        }    

        //EndUp 
        public string EndUp(string str)
        {
            if (str.Length < 3)
                return str.ToUpper();
            else
            {
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3, 3).ToUpper();
            }
        }

        //EveryNth 
        public string EveryNth(string str, int n)
        {
            string str_copy = "";
            for (int i = 0; i < str.Length; i += n)
            {
                str_copy += str[i].ToString();
            }
            return str_copy; 
        }





    }
}
