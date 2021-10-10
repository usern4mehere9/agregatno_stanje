using System;

namespace agregatno_stanje
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("cvrsto");
            }
            else if (a > 0 & a < 100)
            {
                Console.WriteLine("tecno");
            }
            else if (a > 100)
            {
                Console.WriteLine("gasovito");
            }
        }
    }
}
