using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int azn = 100;
            float euro = 0.547f;
            float usd = 0.5882f;
            float rub = 37.7359f;

            string Test1 = "100 azn neche eurodur";
            Console.WriteLine(Test1);
            float multiplication = azn * euro;
            Console.WriteLine(multiplication);

            Console.WriteLine();

            string Test2 = "100 azn neche usddir";
            Console.WriteLine(Test2);
            float multiplication2 = azn * usd;
            Console.WriteLine(multiplication2);

            Console.WriteLine();

            string Test3 = "100 azn neche rubldur";
            Console.WriteLine(Test3);
            float multiplication3 = azn * usd;
            Console.WriteLine(multiplication3);

















        }
    }
}
