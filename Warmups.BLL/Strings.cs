using System;

namespace Warmups.BLL
{
    public class Strings
    {

        public string SayHi(string name)
        {
            return "Hello " + name + "!";
        }

        public string Abba(string a, string b)
        {
            return a + b + b + a;
        }

        public string MakeTags(string tag, string content)
        {
            string grab = $"<{tag}>{content}</{tag}>";
            return grab;
        }

        public string InsertWord(string container, string word)
        {
            string front = container.Substring(0, 2);
            string back = container.Substring(container.Length - 2);
            return front + word + back;
        }

        public string MultipleEndings(string str)
        {
            string lastTwo = str.Substring(str.Length - 2);
            string repeat = "";
            for (int i = 0; i < 3; i++)
            {
                repeat += lastTwo;
            }
            return repeat;
        }

        public string FirstHalf(string str)
        {
            int size = ((str.Length) / 2);
            string spit = str.Substring(0, size);
            return spit;
        }

        public string TrimOne(string str)
        {
            string trimmed = str.Substring(1, str.Length - 2);
            return trimmed;
        }

        public string LongInMiddle(string a, string b)
        {
            if (a.Length > b.Length)
                return b + a + b;
            else return a + b + a;
        }

        public string RotateLeft2(string str)
        {
            string firstTwo = str.Substring(0, 2);
            string removed = str.Remove(0, 2);
            return removed + firstTwo;
        }

        public string RotateRight2(string str)
        {
            string lastTwo = str.Substring(str.Length - 2);
            string removed = str.Remove(str.Length - 2);
            return lastTwo + removed;
        }

        public string TakeOne(string str, bool fromFront)
        {
            string letter = "";  
            if (fromFront)
                letter = str.Substring(0, 1);
            else
                letter = str.Substring(str.Length - 1);
            return letter;
        }

        public string MiddleTwo(string str)
        {
            int len = str.Length - 1;
            return str.Substring(len / 2, 2);
        }
        
        // Given a string, return true if it ends in "ly"
        public bool EndsWithLy(string str)
        {
            return str.EndsWith("ly");
        }

        // Given a string and an int n, return a string made of the first and last n chars from the string. The string length will be at least n
        public string FrontAndBack(string str, int n)
        {
            string front = str.Substring(0, n);
            string back = str.Substring(str.Length - n);
            return front + back;
        }
        // Given a string and an index, return a string length 2 starting at the given index. If the index is too big or too small to define a string length 2, use the first 2 chars. The string length will be at least 2. 
        public string TakeTwoFromPosition(string str, int n)
        {
            string twoFrom = "";
            if (n <= 2)
                twoFrom = str.Substring(n, 2);
            else
                twoFrom = str.Substring(0, 2);
            return twoFrom;
        }
        // Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0.
        public bool HasBad(string str)
        {
            if (str.Length == 3)
                return str.Substring(0, 3).Equals("bad");

            if (str.Length >= 4)
                return str.Substring(0, 3).Equals("bad") ||
                    str.Substring(1, 3).Equals("bad");

            return false;
        }
        // Given a string, return a string length 2 made of its first 2 chars. If the string length is less than 2, use '@' for the missing chars. 
        public string AtFirst(string str)
        {
            if (str.Length == 0) return "@@";
            if (str.Length == 1) return str + "@";
            return str.Substring(0, 2);
        }
        // Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, so "yo" and "java" yields "ya". If either string is length 0, use '@' for its missing char. 
        public string LastChars(string a, string b)
        {
            if (a.Length == 0)
                a = "@";
            if (b.Length == 0)
                b = "@";
            return a.Substring(0, 1) + b.Substring(b.Length - 1);

        }
        // Given two strings, append them together (known as "concatenation") and return the result. However, if the concatenation creates a double-char, then omit one of the chars, so "abc" and "cat" yields "abcat
        public string ConCat(string a, string b)
        {
            if (!(a.Length == 0 || b.Length == 0) && a.Substring(a.Length - 1).Equals(b.Substring(0, 1)))
            {
                return a + b.Substring(1);
            }
            else return a + b;
        }
        // Given a string of any length, return a new string where the last 2 chars, if present, are swapped, so "coding" yields "codign". 
        public string SwapLast(string str)
        {
            if (str.Length > 1)
            {
                string secondToLast = str.Substring(str.Length - 2, 1);
                string last = str.Substring(str.Length - 1, 1);
                string cut = str.Remove(str.Length - 2);
                return cut + last + secondToLast;
            } else
            {
                return str;
            }
        }

       // Given a string, return true if the first 2 chars in the string also appear at the end of the string, such as with "edited". 
        public bool FrontAgain(string str)
        {
            return str.Substring(0, 2).Equals(str.Substring(str.Length - 2));
        }

        public string MinCat(string a, string b)
        {
            if (a.Length == b.Length) return a + b;
            int len = Math.Min(a.Length, b.Length);
            return a.Substring(a.Length - len) + b.Substring(b.Length - len);

        }
        // Given a string, return a version without the first 2 chars.Except keep the first char if it is 'a' and keep the second char if it is 'b'. The string may be any length.

        public string TweakFront(string str)
        {
            string newFront = "";
            if (str == "")
            {
                return str;
            }
            if (str[0] == 'a' && str[1] == 'b')
            {
                return str;
            }
            else if (str[0] == 'a')
            {
                newFront = 'a' + str.Substring(2, str.Length - 2);
            }
            else if (str[1] == 'b')
            {
                newFront = 'b' + str.Substring(2, str.Length - 2);
            }
            else
            {
                newFront = str.Substring(2, str.Length - 2);
            }
            return newFront;

        }
        // Given a string, if the first or last chars are 'x', return the string without those 'x' chars, and otherwise return the string unchanged. 
        public string StripX(string str)
        {
           string noEx = "";
           if(str == "")
           {
               return str;
           }
           else if (str.Length < 3)
           {
               return "";
           }
           else if (str[0] == 'x' && str[str.Length-1] == 'x')
           {
               noEx = str.Remove(0, 1);
               noEx = noEx.Remove(noEx.Length - 1, 1);
           }
           else if(str[0] == 'x' && str[str.Length - 1] != 'x')
           {
               noEx = str.Remove(0, 1);
           }
           else if (str[0] != 'x' && str[str.Length - 1] == 'x')
           {
               noEx = str.Remove(str.Length - 1, 1);
           }
           return noEx;
        }
    }
}
