using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {
        /* When squirrels get together for a party, they like to have cigars. 
           A squirrel party is successful when the number of cigars is between 
           40 and 60, inclusive. Unless it is the weekend, in which case there is 
           no upper bound on the number of cigars. Return true if the party with 
           the given values is successful, or false otherwise. 
        */

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
                return cigars > 40;
            else
                return (cigars >= 40 && cigars <= 60);
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            //8 or more, yes 2
            //if 2 or less 
            //mayabe
            if (yourStyle >= 8 || dateStyle >= 8)
            {
                return 2;
            }
            else if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else
                return 1;
        }

        //
        public bool PlayOutside(int temp, bool isSummer)
        {
            if (isSummer)
            {
                if (temp > 60 && temp < 100)
                {
                    return true;
                }
            }
            else
            {
                if (temp > 60 && temp < 90)
                {
                    return true;
                }
            }
            return false;
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday)
            {
                if (speed <= 60*5)
                {
                    return 0;
                }
                else if (speed > 60*5 && speed < 80*5)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (speed <= 60)
                {
                    return 0;
                }
                else if (speed > 60 && speed < 80)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public int skipSum(int a, int b)
        {
            int x = a + b;
            if (x >= 10 && x < 20)
            {
                x = 20;
            }
            return x;
        }

        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if (day < 6 && day != 0)
                {
                    return "10:00";
                }
                else
                {
                    return "off";
                }
            }
            else
            {
                if (day < 6 && day != 0)
                {
                    return "7:00";
                }
                else
                {
                    return "10:00";
                }
            }
        }

        public bool LoveSix(int a, int b)
        {
            if ((a == 6 || b == 6) || (a + b == 6 || Math.Abs(a - b) == 6))
            {
                return true;
            }
            return false;
        }

        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode == false)
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }
                return false; 
            }
        }

        //special eleven 
        public bool SpecialEleven(int n)
        {
            if (n%11 == 0 || n%11 == 1)
            {
                return true;
            }
            return false; 
        }

        //Mod20
        public bool Mod20(int n)
        {
            if (n%20 == 1 || n%20 == 2)
            {
                return true;
            }
            return false; 
        }

        //Mod35
        public bool Mod35(int n)
        {
            if ((n%3 == 0 && n%5 != 0) || (n%5 == 0 && n%3 != 0))
            {
                return true; 
            }
            return false; 
        }

        //AnswerCall
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (!isAsleep)
            {
                if (isMorning)
                {
                    if (isMom)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return true;
            }
            else
                return false;
        }

        //TwolsOne
        public bool TwoIsOne(int a, int b, int c)
        {
            if(a == b + c)
            {
                return true; 
            }
            else if (b == a + c)
            {
                return true; 
            }
            else if (c == b + a)
            {
                return true;
            }
            else
                return false; 
        }

        //AreInOrder 
        public bool AreInOrder(int a, int b, int c, bool bok)
        {
            if (bok)
            {
                if (c > a && c > b)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (c > b && b > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //In Order Equal 
        public bool InOrderEqual(int a, int b, int c, bool equalok)
        {
            if (!equalok)
            {
                if (a < b && b < c)
                {
                    return true;
                }
            }
            else
            {
                if (a <= b && b <= c)
                    return true; 
            }
            return false; 
        }

        //LastDigit
        public bool LastDigit(int a, int b, int c)
        {
            int a_re = a%10;
            int b_re = b%10;
            int c_re = c%10;

            if (a_re == b_re || b_re == a_re || c_re == a_re)
            {
                return true; 
            }
            return false; 
        }

        //Roll Dice
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    die1++;
                    if (die1 == 7)
                        die1 = 1;
                    return die1 + die2; 
                }
                return die1 + die2;
            }
            else
            {
                return die1 + die2; 
            }
        }

    }
}
