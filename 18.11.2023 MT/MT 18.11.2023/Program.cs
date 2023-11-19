

using System.Globalization;

namespace _18._11._2023_MT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Bir soz yazin");
            //string newString = Console.ReadLine();

            //for(var i = 0; i  < newString.Length; i++) 
            //{ 
            //    for(var j = 0; j <= i; j++)
            //    {
            //        Console.Write(newString[j]);
            //    }
            //    Console.WriteLine();
            //}

            //int sayi;
            //Console.Write("Bir sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    for (int y = 1; y <= sayi; y++)
            //    {

            //        if ((i == 1) || (i == sayi))
            //            Console.Write("x");
            //        else
            //        {
            //            if ((y == 1) || (y == sayi))
            //                Console.Write("x");
            //            else
            //                Console.Write("");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();


            int count = 0;
            int cem = 0;
            Console.WriteLine("Birinci ededi daxil edin:");
            int birinci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin:");
            int ikinci = Convert.ToInt32(Console.ReadLine());
            for (int i = birinci; i <= ikinci; i++)
            {
                if (i%2== 0)
                {
                    count++;
                    cem += i;
                }
            }
            Console.WriteLine("Ededlerin cemi: " + cem);
            Console.WriteLine("Ededlerin sayi: " + count);


        }
        
    }
}


