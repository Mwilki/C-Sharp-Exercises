using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            return isWeekend && cigars > 39 || cigars < 61 && cigars > 39;
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2) return 0;
            return (yourStyle >= 8 && dateStyle >= 2 || dateStyle >= 8 && yourStyle >= 2) ? 2 : 1;
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            return temp <= 100 && temp >= 60 && isSummer == true || temp <= 90 && temp >= 60 && isSummer == false;
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday) speed -= 5;
            if (speed <= 60) return 0;
            return (speed > 60 && speed <= 80) ? 1 : 2;
        }

        public int SkipSum(int a, int b)
        {
            int sum = a + b;
            if (sum >= 10 && sum <= 19)
                sum = 20;
            return sum;
        }

        public string AlarmClock(int day, bool vacation)
        {
        if (vacation) return (day >= 1 && day <= 5) ? "10:00" : "off";
        return (day >= 1 && day <= 5) ? "7:00" : "10:00";
        }

        public bool LoveSix(int a, int b)
        {
            return a == 6 || b == 6 || a + b == 6 || Math.Abs(a - b) == 6;
        }
        
        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n < 1 || n > 10)
                {
                    return true;
                }
            }
            else
            {
                if (n > 1 && n < 11)
                {
                    return true;
                }

            }
            return false;
        }
        
        public bool SpecialEleven(int n)
        {
            return n % 11 == 0 || n % 11 == 1;
        }
        
        public bool Mod20(int n)
        {
            return n % 20 == 1 || n % 20 == 2;
        }
        
        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }
            else
            {
                if (n % 3 == 0)
                {
                    return true;
                }
                else if (n % 5 == 0)
                {
                    return true;
                }
                return false;
            }
        }
        
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep) return false;
            if (isMorning) return isMom;
            return true;

        }
        
        public bool TwoIsOne(int a, int b, int c)
        {
            return a + b == c || a + c == b || b + c == a;
        }
        
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk) return b < c;
            return a < b && b < c;
        }
        
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk) return a <= b && b <= c;
            return a < b && b < c;
        }
        
        public bool LastDigit(int a, int b, int c)
        {
            return a % 10 == b % 10 || a % 10 == c % 10 || b % 10 == c % 10;
        }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    if (die1 == 6)
                    {
                        die1 = 1;
                        return die1 + die2;
                    }
                    else
                    {
                        die1 += 1;
                        return die1 + die2;
                    }
                }
                else
                {
                    return die1 + die2;
                }
            }
            else
            {
                return die1 + die2;
            }
        }
    }
}
