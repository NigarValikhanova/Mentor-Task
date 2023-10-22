namespace _02._09._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region New Task
            //while (true)
            //{
            //Console.WriteLine("We can show you new calculate method which is equal x*x+ 2*x - 1");
            //Console.Write("Enter a numbers:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Calculate(x));

            //}
            #endregion

            #region Previous Task 3
            //List<int> Numbers = new List<int>();

            //for (int i = 0; i < 8; i++)
            //{
            //    Console.Write($"Enter a number{i +1}: ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    Numbers.Add(number);
            //}
            //if (Numbers.Count >= 8)
            //{
            //    for (int i = 0; i < 4; i++)
            //    {
            //        int again = Numbers[i];
            //        Numbers[i] = Numbers[Numbers.Count - 4 + i];
            //        Numbers[Numbers.Count - 4 + i] = again;
            //    }

            //    Console.WriteLine("List after swapping:");
            //    foreach (int num in Numbers)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}
            #endregion

            #region Previous Task4

            //SortedSet<int> uniqueSortedNumbers = new SortedSet<int>();

            //// Step b: Fill the collection with different numbers
            //Console.WriteLine("Enter unique numbers (sorted) to fill the collection:");
            //for (int i = 0; i < 10; i++)
            //{
            //    int number;
            //    while (true)
            //    {
            //        Console.Write($"Enter number {i + 1}: ");
            //        if (int.TryParse(Console.ReadLine(), out number))
            //        {
            //            if (!uniqueSortedNumbers.Contains(number))
            //            {
            //                uniqueSortedNumbers.Add(number);
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Number already exists in the collection. Please enter a different number.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //        }
            //    }
            //}

            //// Step c: Print the result to the screen
            //Console.WriteLine("Collection contents:");
            //foreach (int num in uniqueSortedNumbers)
            //{
            //    Console.Write(num + " ");
            //}

            #endregion

        }

        //public static double Calculate(int x)
        //{
        //    int y = 0; ;
        //    y = x*x + 2 * x - 1;
        //    return y;
        //}
    }
}