using System; 

namespace Warmups.BLL
{
    public class Conditionals
    {
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            return aSmile == true && bSmile == true || aSmile == false && bSmile == false;
        }

        public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            return (!isWeekday && !isVacation || !isWeekday && isVacation);
        }
        
        public int SumDouble(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0)
                return (a + b) * 2;
            return a + b;
        }
        
        public int Diff21(int n)
        {
            if (n > 21)
                return (n - 21) * 2;
            else
                return 21 - n;
        }
        
        public bool ParrotTrouble(bool isTalking, int hour)
        {
            return isTalking == true && hour > 20 || isTalking == true && hour < 7;
        }
        
        public bool Makes10(int a, int b)
        {
            return (a == 10 || b == 10) || (a + b == 10);
        }

        public bool NearHundred(int n)
        {
            return Math.Abs(n - 100) <= 10;
        }

        // Given two int values, return true if one is negative and one is positive.Except if the parameter "negative" is true, then return true only if both are negative. 
        public bool PosNeg(int a, int b, bool negative)
        {
            return (a > 0 && b < 0 || a < 0 && b > 0) || (0 > a && b < 0 || negative == true);
        }
       
        public string NotString(string s)
        {
            return $"not {s}";
        }
        
        public string MissingChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
        
        public string FrontBack(string str)
        {
            int len = str.Length;
            if (str.Length == 1)
            {
                return str;
            }
                return str[len - 1] + str.Substring(1, len - 2) + str[0];
        }
        
        public string Front3(string str)
        {
            string output = "";
            if (str.Length >= 3)
            {
                for (int repeat = 0; repeat < 3; repeat++)
                {
                    output = str.Substring(0, 3) + output;
                }

            } 

            if (str.Length <= 2)
            {
                for (int repeat = 0; repeat < 3; repeat++)
                {
                    output = str.Substring(0, 2) + output;
                }
            }

            return output;


        }
        
        public string BackAround(string str)
        {
            string find = str.Substring(str.Length - 1, 1);
            return $"{find}{str}{find}";
        }
        
        public bool Multiple3or5(int number)
        {
            return number % 3 == 0 || number % 5 == 0;
        }

        public bool StartHi(string str)
        {
            return str.StartsWith("hi") && str.Length < 3 || str.StartsWith("hi") && !char.IsLetter(str[2]);
        }

        public bool IcyHot(int temp1, int temp2)
        {
            return temp1 > 100 && temp2 < 0 || temp1 < 0 && temp2 > 100;
        }
        

        public bool Between10and20(int a, int b)
        {
            return a >= 10 && a <= 20 || b >= 10 && b <= 20;
        }
        
        public bool HasTeen(int a, int b, int c)
        {
            return a > 12 && a < 20 || b > 12 && b < 20 || c > 12 && c < 20;
        }
        
        public bool SoAlone(int a, int b)
        {
            return (a >= 13 && a <= 19) && (b < 13 || b > 20) || (b >= 13 && b <= 19) && (a < 13 || a > 20);
        }
        
        public string RemoveDel(string str)
        {
            string find = str.Substring(1, 3);
            if (find == "del")
            {
                return str.Remove(1, 3);
            } else
            {
                return str;
            }
        }
        
        public bool IxStart(string str)
        {
            string find = str.Substring(1, 2);
            if (find == "ix")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string StartOz(string str)
        {
            string oz = "";
            if (str[0] == 'w')
            {
                return "";
            }
            if (str[0] == 'o')
            {
                oz += str[0];
            }
            if (str[1] == 'z')
            {
                oz += str[1];
            }

            return oz;
        }
        
        public int Max(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        
        public int Closer(int a, int b)
        {
            int closest = a;
            if (Math.Abs(10 - a) == Math.Abs(10 - b)) closest = 0;
            if (Math.Abs(10 - a) > Math.Abs(10 - b)) closest = b;
            return closest;
        }
        
        public bool GotE(string str)
        {
            int counter = 0;
            for (int e = 0; e < str.Length; e++)
            {
                if (str[e] == 'e')
                {
                    counter++;
                }
            }
            return counter <= 3 && counter != 0;
        }
        
        public string EndUp(string str)
        {
            if (str.Length > 3)
            {
                string beginning = str.Substring(0, str.Length - 3);
                string upper = str.Substring(str.Length-3);
                string single = upper.ToUpper();


                return beginning + single;
            } else
            {
                return str.ToUpper();
            }
        }
        
        public string EveryNth(string str, int n)
        {
            string s = "";
            for (int i = 0; i < str.Length; i += n)
            {
                s += str[i];
            }
            return s;
        }
    }
}
