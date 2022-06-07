using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shop_30063614
{
    internal class Program
    {
        // aray of what the user is allowed too input 
        public static string[] menuOptions = { "1", "2", "3", "4", "5" };

        // ballace
        public static decimal balance = 20000;

        // option that the user has selected 
        public static string userOption = "";

        private static void CheckPin()
        {
            string Name = "";
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("\t            Welcome too Appliace plus\n");
            Console.WriteLine("                 \tPlease enter your name");
            Console.WriteLine("*****************************************************************************");
            // User input
            Name = Console.ReadLine();
            MainMenu();

        }

        static void MainMenu()
        {
            Console.WriteLine("****************************************\n");
            Console.WriteLine("\tPlease select an Option:\n");
            Console.WriteLine("\t [1] View Balance");
            Console.WriteLine("\t [2] TV's");
            Console.WriteLine("\t [3] Fridges");
            Console.WriteLine("\t [4] Dishwashers");
            Console.WriteLine("\t [5] Exit Application\n");
            Console.WriteLine("****************************************\n");
        }
    }
}

