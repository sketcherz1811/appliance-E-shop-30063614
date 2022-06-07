using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_shop_30063614
{
    internal class Program
    {
        public static string UserName;

        static void MainMenu()
        {
            Console.WriteLine("welcome to Appliance Plus,please enter your name");
            UserName = Console.ReadLine();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("welcome " + UserName + " please select an option from the menu");
            Console.WriteLine("(1) check balance /n (2) televisions /n (3) Washing machines /n (4) fridges /n");
                }
        static void Main(string[] args)
        {//start of main input
            MainMenu();
        }//end of main input
    }
}
