using conceptsPOO;
using System;

namespace conceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("conceptsPOO");

            try
            {
                Console.WriteLine(new Date(2020, 2, 24));
                Console.WriteLine(new Date(1974, 2, 28));
                Console.WriteLine(new Date(2020, 12, 13));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }
        }
    }
}
