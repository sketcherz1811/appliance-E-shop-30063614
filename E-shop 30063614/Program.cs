using System;
// testing commit june 9
namespace E_shop_30063614
{
    internal class program
    {
        // allowed user inputs
        public static string[] menuOptions = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "y", "n" };

        // starting balance 
        public static decimal balance = 100;
        public static decimal price = 0;

        // stores where the user is on the main menu 
        public static string userOption = "";


        static void checkout()
        {
            Console.WriteLine("would you like too purchase this item?");
            Console.WriteLine("\t[y] Yes");
            Console.WriteLine("\t[n] No");
            if (userOption != "y")
            {


            }
            else _ = (userOption != "n");
            {

            }
        }
        private static void Start()
        {
            string name = "";
            name = Console.ReadLine();
            Console.WriteLine("*******************************************************");
            Console.WriteLine("\t      Welcome to Appliace Plus\n");
            Console.WriteLine("\t   Please enter your name to continue");
            Console.WriteLine("*******************************************************");




            MainMenu();

        }

        static void MainMenu()
        {
            string name = "";
            Console.WriteLine("*******************************************************\n");
            Console.WriteLine("\t Welcome " + name + "\tfeel free to browse around the shop\n");
            Console.WriteLine("\t [1] Add to ballance");
            Console.WriteLine("\t [2] TV's");
            Console.WriteLine("\t [3] Fridges");
            Console.WriteLine("\t [4] Dishwashers");
            Console.WriteLine("\t [5] Exit Appliace Plus\n");
            Console.WriteLine("*******************************************************\n");
            // ckeckinput running 
            CheckInput();

            if (userOption == "2")
            {
                opt2();
            }
            if (userOption == "3")
            {
                opt3();
            }
            if (userOption == "4")
            {
                opt4();
            }
            if (userOption == "5")
            {
                opt5();
            }
        }
        public static void CheckInput()
        {
            bool check = false;

            while (check == false)
            {
                Console.WriteLine("\tPlease choose an option ([1], [2], [3], [4], [5])");
                string userInput = Console.ReadLine();

                foreach (string temp in menuOptions)
                {
                    check = userInput.Equals(temp);

                    if (check)
                    {
                        break;
                    }

                }

                if (check)
                {
                    Console.WriteLine("\tinput " + userInput + " is valid, you may proceed with your action\n");
                }
                else
                {
                    Console.WriteLine("\tinput " + userInput + " is not valid, please enter a correct input \n");
                }

                userOption = userInput;
                Menus();
            }

        }

        public static void Menus()
        {
            decimal amount;


            if (userOption == "1")
            {
                Console.WriteLine("\n*******************************************************");
                Console.WriteLine("\t \n        Your balance is " + "$" + balance);
                Console.WriteLine("\n\n");
                Console.WriteLine("\t How much would you like to add to your balance?\n\n");
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    balance += amount;
                    Console.WriteLine("\tYou have added $" + amount + " Your avlable balance is now $" + balance + "\n\n");
                }
                else
                {
                    Console.WriteLine("\tWARNING! invalid, please try again.\n\n");
                }
                MainMenu();
            }
        }
        public static void opt2()
        {

            if (userOption == "2")
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("\tWelcome to the TV section of Appliace Plus \n");
                Console.WriteLine("\tPlease select a TV that Peaks your Interest\n");
                Console.WriteLine("\t [6] TCL 32 INCH ANDROID TV\n");
                Console.WriteLine("\t [7] PANASONIC 48 INCH SMART TV\n ");
                Console.WriteLine("\t [8] SAMSUNG 50 INCH NANOCELL SMART TV\n");
                Console.WriteLine("\t [9] LG 55 INCH SMART TV\n");
                Console.WriteLine("\t [10] KONKA 25 INCH ANDRIOD TV\n");
                Console.WriteLine("*******************************************************");


                //userOption = Console.ReadLine();
                string userOption = Console.ReadLine();
                if (userOption == "6")
                {
                    Console.WriteLine("\tThe TCL 32S615 HD Android TV is a brand new 2020 model that comes equipped with AI integration \n\tand a TCL entertainment hub that gives the user access to Netflix, Youtube, and Amazon prime.");
                    Console.WriteLine("\t\n The price of the TV you have chosen is $479");
                    price = 479;




                }
                if (userOption == "7")
                {
                    Console.WriteLine("\t\ntest");
                    Console.WriteLine("\t\n ");




                }
            }


        }
        public static void opt3()
        {
            if (userOption == "3")

                Console.WriteLine("\t*******************************************************");
            Console.WriteLine("\tWelcome to the Fridge section of Appliace Plus\n");
            Console.WriteLine("\tPlease select a Fridge that looks apealing to you\n");
            Console.WriteLine("\t [1] HAIR 320L TOP FOUNT F/F\n");
            Console.WriteLine("\t [2] ROBINHOOD 221L BOTTOM MOUNT F/F \n");
            Console.WriteLine("\t [3] SAMSUNNG 360L TOP MOUNT FRIDGE \n");
            Console.WriteLine("\t [4] FISHER&PAYKEAL DOUBLE DOOR F/F 645L\n");
            Console.WriteLine("\t [5] PANASONIC DOUBLE DOOR 550L F/F\n");
            Console.WriteLine("*******************************************************");

            CheckInput();
        }
        public static void opt4()
        {
            if (userOption == "4")
            {
                Console.WriteLine("\t*******************************************************");
                Console.WriteLine("\tWelcome to the dishwasher section of Appliace Plus\n");
                Console.WriteLine("\tPlease select a dishwasher that fits your energy reqirements\n");
                Console.WriteLine("\t [1] WESTINGHOUSE 60CM /W FREESTANDING DISHWASHER \n");
                Console.WriteLine("\t [2] SAMSUNG 60CM S/S FREESTANDING DISHWASHER \n");
                Console.WriteLine("\t [3] BEKO 30CM S/S FREEESTANDING DISHWASHER \n");
                Console.WriteLine("\t [4] PARMCO 60VM /B FREESTANDING DISHWASHER\n");
                Console.WriteLine("\t [5] FISHER&PAYKEL 60CM S/S FRESTANDING DISHWASHER \n");
                Console.WriteLine("*******************************************************");

                CheckInput();
            }
        }
        public static void opt5()
        {
            if (userOption == "5")
            {
                Environment.Exit(0);
            }
        }
            static void Main(string[] args)
            {
                Start();
            }
        }
    }


