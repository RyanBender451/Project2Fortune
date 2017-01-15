using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your First Name");
            string firstName = Console.ReadLine();

            RestartQuit(firstName);
            Console.WriteLine("Please Enter your Last Name");
            string lastName = Console.ReadLine();

            RestartQuit(lastName);
            string greetsYou = GreetSucker(firstName, lastName);
            Console.WriteLine(greetsYou);
           
            Console.WriteLine("How old are you?");
            string strAge = Console.ReadLine();
            RestartQuit(strAge);
            int age = int.Parse(strAge);
            int retireTime = AgeForRetire(age);
            
            Console.WriteLine("What is the number of the Month you were born in:");
            string monthStr = Console.ReadLine();
            RestartQuit(monthStr);
            int bMonth = int.Parse(monthStr);
            double bankCash = CashBank(bMonth);

            Console.WriteLine("Pick your favorite ROYGBIV.  If you don't know what ROYGBIV is type in Help");
            string cRainbow = Console.ReadLine();
            RestartQuit(cRainbow);
            if (cRainbow.ToUpper() == "HELP")
            {
                Console.WriteLine("ROYGBIV is the color rainbow");
                Console.WriteLine("R is Red \nO is Orange \nY is Yellow \nG is Green \nB is Blue \nI is Indigo \nV is Violet");
                Console.WriteLine("Please enter a ROYGBIV color");
                cRainbow = Console.ReadLine();
                RestartQuit(cRainbow);
            }
            string yourTransport = VehicleMode(cRainbow);
            
            //Number of Siblings
            Console.WriteLine("Please enter the number of Siblings you have");
            string siblingString = Console.ReadLine();

            RestartQuit(siblingString);
            int siblingsNum = int.Parse(siblingString);
            string vactionHome = FutureHome(siblingsNum);

            Console.WriteLine("Zoltar has read your Future!");
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retireTime + " years with $" + bankCash + " in the bank, a vaction home in " + vactionHome + " and a " + yourTransport);

            FortuneOpinion();

        }//------end main -----

        static string GreetSucker(string firstName, string lastName)
        {
            string greetingYou = "Greetings," + firstName + " " + lastName + ", I am the Great Zoltar.\nI, The Great Zoltar, will give you a fortune";
            return greetingYou;
        }//end GreetSucker
        static int AgeForRetire(int age)
        {
            int retireYears;
            if (age %2 == 0)
            {
                retireYears = 30;
            }
            else
            {
                retireYears = 45;
            }

            return retireYears;
        }//end AgeForRetire

        static double CashBank(int birthMonth)
        {
            double retireFund;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                retireFund = 400000001.40;
            }
            else if (birthMonth >= 5 && birthMonth <= 8 )
            {
                retireFund = 8100000005.80;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                retireFund = 120000009.12;
            }
            else
            {
                retireFund = 0.00;
            }
            return retireFund;
        }//end cashBank
        static string VehicleMode(string rcolor)
        {
            string transportColor;
            switch (rcolor.ToUpper())
            {
                case "RED":
                    transportColor = "Chevy Corevette";
                    break;

                case "ORANGE":
                    transportColor = "Ford Mustang";
                    break;

                case "YELLOW":
                    transportColor = "Cadillac";
                    break;

                case "GREEN":
                    transportColor = "Ford F-150";
                    break;
                    
                case "BLUE":
                    transportColor = "Dodge RAM";
                    break;

                case "INDIGO":
                    transportColor = "Jeep Wrangler";
                    break;
                case "VIOLET":
                    transportColor = "Volkswagon Beetle";
                    break;

                default:
                    transportColor = "squeaky shopping cart";
                    break;
            }

            return transportColor;
        }//vehicleMode
        static string FutureHome(int yourSibs)
        {
            string vacHome;
            if (yourSibs < 0)
            {
                vacHome = "Antarctica";
            }
            else if(yourSibs == 0)
            {
                vacHome = "Orlando Florida";
            }
            else if (yourSibs == 1)
            {
                vacHome = "Paris France";
            }
            else if (yourSibs == 2)
            {
                vacHome = "Rome Italy";
            }
            else if (yourSibs == 3)
            {
                vacHome = "New York";
            }
            else
            {
                vacHome = "Cancun Mexico";
            }
            return vacHome;
        }//end FutureHome
        static void FortuneOpinion()
        {
            //Instead of just doing one phrase I wanted a random generated one
            Random fortuneRandom = new Random();
            Console.WriteLine();
            int fortuneNumber = fortuneRandom.Next(1, 5);
            switch(fortuneNumber)
            {
                case 1:
                    Console.WriteLine("Not really the best fortune I have done.  But it's not bad");
                    break;
                case 2:
                    Console.WriteLine("Your fortune is about average now.  You'll be happy");
                    break;
                case 3:
                    Console.WriteLine("For you, this is a good fortune, better than the other possibilities I saw in your future");
                    break;
                default:
                    Console.WriteLine("This fortune is too good for you.  So I am going to change it");
                    Console.WriteLine("So now you are going to Australia and have a bad encounter with a Drop Bear.  Have a nice day");
                    break;

            }
        }//End fortune
         //Extra Credit stuff goes below
        static void RestartQuit(string cmdQuit)
        {
            if (cmdQuit.ToUpper() == "QUIT")
            {
                Environment.Exit(0);
            }
            else if (cmdQuit.ToUpper() == "RESTART")
            {
                Console.Clear();
                Main(Environment.GetCommandLineArgs());
                Environment.Exit(0);
            }

        }//end RestartQuit
    }
}
