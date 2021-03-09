using System;

namespace GymApp
{
    class Program
    {

        static void Main(string[] args)
        {

            // I am currently
            Console.WriteLine("Hello here is gym membership");

            string s = Console.ReadLine();
            while(s != null)
            {
                Client.CallClient();
                Console.WriteLine("Insert data againt");
                s = Console.ReadLine();

            }

           
            Console.ReadKey();
        }
    }
}
