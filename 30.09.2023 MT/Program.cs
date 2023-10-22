namespace _30._09._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(NumbersReverse());
            //Console.WriteLine(ReturnDigit("682 apple"));
            //Console.WriteLine(exNum("623 Ammeziya"));
            #region Romans numbers
            //Console.Write("Enter a Roman numeral: ");
            //string romanNumeral = Console.ReadLine();

            //int num = RomanToInt(romanNumeral);

            //if (num != -1)
            //{
            //    Console.WriteLine($"Integer representation: {num}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Roman numeral.");
            //}
            #endregion
        }
        #region ReverseNumber
        public static string NumbersReverse()
        {
            while (true)
            {
                Console.WriteLine("Enter number");
                int test1 = Convert.ToInt32(Console.ReadLine());
                string test2 = Math.Abs(test1).ToString();
                string testOut = "";
                for (int i = test2.Length - 1; i >= 0; i--)
                {
                    var abs = Math.Abs(test2[i]);
                    testOut += test2[i];
                }
                Console.WriteLine(testOut);
            }
        }
        static int ReverseNumber(int num)
        {
            string conver = Math.Abs(num).ToString();
            char[] charArray = conver.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            int reversedNum = int.Parse(reversedStr);
            if (num < 0)
            {
                reversedNum *= -1;
            }
            return reversedNum;
        }
        #endregion

        #region Roman Numbers
        public static int RomanToInt(string s)
        {
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int currentVal = RomanCharToInt(s[i]);

                if (i < s.Length - 1)
                {
                    int nextVal = RomanCharToInt(s[i + 1]);

                    if (currentVal < nextVal)//IV
                    {
                        result -= currentVal;
                    }
                    else//VI=6
                    {
                        result += currentVal;
                    }
                }
                else
                {
                    result += currentVal;
                }
            }

            return result;
        }

        public static int RomanCharToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
            }

        }
        #endregion

        #region Return Digit
        public static bool ReturnDigit(string x)
        {
            string something = "";
            bool Digit = false;

            foreach (char item in x)
            {
                if ((int)item >= 48 && (int)item <= 57)
                {
                    Digit = true;
                    something = Convert.ToString(item);
                    return Digit;
                }
                return false;
            }
            return true;
        }

        public static int exNum(string x)
        {
            string num = "";
            bool numFound = false;
            foreach (char c in x)
            {
                if (char.IsDigit(c))
                {
                    num += c;
                    numFound = true;
                }
                //else if (numFound)
                //{
                //    break;
                //}
            }
            if (int.TryParse(num, out int result))
            {
                return result;
            }
            else { return 0; }
        }
        #endregion

    }
}
