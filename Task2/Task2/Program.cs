using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            long TotalBudce = 20000000000;
            float Mudafie = 0.2f;
            float YTN = 0.1f;
            float Qaliq = 0.7f;



            string name = "Azerbaycan Budce ";
            Console.WriteLine(name);
            Console.WriteLine(TotalBudce);


            Console.WriteLine("");



            string name2 = "Mudafie Nazirliyine xerclenen";
            Console.WriteLine(name2);
            float MNxerclenen = TotalBudce * Mudafie;
            Console.WriteLine(MNxerclenen);


            Console.WriteLine("");



            string name3 = "Yuksek Texnologiyalar Nazirliyine xerclenen";
            Console.WriteLine(name3);
            float YTNxerclenen = TotalBudce * YTN;
            Console.WriteLine(YTNxerclenen);


            Console.WriteLine("");



            string name4 = "Yerde qalan budce";
            Console.WriteLine(name4);
            float Yerdeqalan = TotalBudce * Qaliq;
            Console.WriteLine(Yerdeqalan);





                     

            

        }
    }
}
