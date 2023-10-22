namespace _26._08._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //My version
            //Console.WriteLine("Input a word");
            //string word1 = Console.ReadLine(); 

            //char[] stringArray = word1.ToCharArray();

            //Array.Reverse(stringArray);

            //Console.WriteLine(stringArray);

            //Teacher method
            //string input, output = "";
            //Console.WriteLine("Input a word");
            //input = Console.ReadLine();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    output += input[i];
            //}
            //Console.WriteLine(output);
            #endregion

            #region Task2
            //string input1, reverse = String.Empty;
            //Console.Write("Write a word: ");
            //input1 = Console.ReadLine();
            //for (int i = input1.Length - 1; i >= 0; i--)
            //{
            //    reverse += input1[i].ToString();
            //}
            //if (reverse == input1)
            //{
            //    Console.WriteLine("Your word is palindrome: " + reverse);
            //}
            //else
            //{
            //    Console.WriteLine("Your word is not palindrome");
            //}

            ////Method version

            //Console.Write("Enter a word: ");
            //string word = Console.ReadLine();

            //if (IsPalindrome(word))
            //{
            //    Console.WriteLine($"'{word}' is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"'{word}' is not a palindrome.");
            //}

            #endregion

            #region Task3

            //Dictionary<string, string> CountryAndCapitals = new Dictionary<string, string>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write("Dear user, please input a country: ");
            //    string nameOfCountry = Console.ReadLine();
            //    Console.Write("Dear user, please input the capital of the country: ");
            //    string nameOfCapital = Console.ReadLine();
            //    CountryAndCapitals.Add(nameOfCountry, nameOfCapital);
            //    //we can do with this way, too
            //    //CountryAndCapitals[nameOfCountry] = nameOfCapital;
            //}
            //while (true)
            //{
            //    Console.Write("Enter the country you are looking for: ");
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "all")
            //    {
            //        foreach (var pair in CountryAndCapitals)
            //        {
            //            Console.WriteLine($"Country: {pair.Key}, Capital: {pair.Value} ");
            //        }

            //    }
            //    else if (CountryAndCapitals.ContainsKey(input))
            //    {
            //        Console.WriteLine($"Capital of {input}: {CountryAndCapitals[input]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Country not found in the dictionary");
            //    }
            //    Console.Write("Do you want to search for a new capital? (yes/no): ");
            //    string response = Console.ReadLine().ToLower();
            //    if (response != "yes")
            //    {
            //        break;
            //    }
            //}



            #endregion

            #region Task4

            //Queue<string> Words = new Queue<string>();


            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.Write("Enter a new item: ");
            //    string item = Console.ReadLine();
            //    Words.Enqueue(item);
            //}

            //    if (Words.Count >= 4)
            //    {
            //        Console.WriteLine("Enter another item");
            //        string removeItem = Console.ReadLine();
            //        Words.Dequeue();
            //        Words.Enqueue(removeItem);

            //    }
            //Console.WriteLine("Uptaded List below:");
            //foreach (string item in Words)
            //    {
            //        Console.WriteLine(item);
            //    }



            #endregion


        }
        //static bool IsPalindrome(string word)
        //    {
        //        word = word.ToLower(); // Convert to lowercase to handle case-insensitivity

        //        int left = 0;
        //        int right = word.Length - 1;

        //        while (left < right)
        //        {
        //            if (word[left] != word[right])
        //            {
        //                return false;
        //            }
        //            left++;
        //            right--;
        //        }

        //        return true;
        //    }
        //}
    }
}