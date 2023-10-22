
namespace _07._10._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Dictionary<string, int> wordToNumber = new Dictionary<string, int>()
            {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3},
            {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7},
            {"eight", 8}, {"nine", 9}
            };
            Console.Write("Enter a number with words: ");
            string userInput = Console.ReadLine().ToLower();

            string[] words = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int result = 0;
            foreach (string word in words)
            {
                if (wordToNumber.ContainsKey(word))
                {
                    result = result * 10 + wordToNumber[word];
                }
                else
                {
                    Console.WriteLine($"Invalid word: {word}");
                    return;
                }
            }
            Console.WriteLine("Integer value: " + result);

            #endregion

            #region Task 2
            // Given string, s
            string s = "fviefuro";
            // Function Call
            Console.WriteLine(construct_digits(s));

            #endregion
        }
        static string construct_digits(string s)
        {
            // Store the unique characters
            // corresponding to word and number
            char[] k = { 'z', 'w', 'u', 'x', 'g', 'h', 'o', 'f', 'v', 'i' };
            string[] l = { "zero", "two", "four", "six", "eight", "three", "one", "five", "seven", "nine" };
            int[] c = { 0, 2, 4, 6, 8, 3, 1, 5, 7, 9 };
            // Store the required result
            List<string> ans = new List<string>();
            // Store the frequency of
            // each character of S
            Dictionary<char, int> d = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!d.ContainsKey(s[i]))
                    d[s[i]] = 0;
                d[s[i]] += 1;
            }
            // Traverse the unique characters

            for (int i = 0; i < k.Length; i++)
            {
                // Store the count of k[i] in S
                int x = 0;
                if (d.ContainsKey(k[i]))
                    x = d[k[i]];
                // Traverse the corresponding word
                for (int j = 0; j < l[i].Length; j++)
                {
                    // Decrement the frequency
                    // of characters by x
                    if (d.ContainsKey(l[i][j]))
                        d[l[i][j]] -= x;
                }

                // Append the digit x times to ans
                ans.Add(((c[i]) * x).ToString());
            }
            // Sort the digits in ascending order
            ans.Sort();
            string str = (String.Join("", ans.ToArray()));
            return str.Replace("0", "");
        }
    }
}
