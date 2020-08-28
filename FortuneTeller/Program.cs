using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Welcome Message
            Console.WriteLine("Welcome to Fortune Teller... a game where there is a 99.9% chance most of this fortune WONT come true.");
            Console.WriteLine("At any time you can type 'Help' for additional information, Lets BEGIN");
            Console.WriteLine("Please provide me some information about you.");



            string firstName, lastName, retire;
            string color = "";
            string check = "";
            string home = "";
            string money = "";
            string transport = "";
            int bMonth, siblings;
            int summ = 0;
            int age = 0;
            int remainingWork = 75;
            
            // User Input for User Info
            Console.WriteLine("What is your First Name ");
            firstName = Console.ReadLine().ToUpper();
            Console.Clear();
            
            //If you wants to end the program
            if ((firstName == "QUIT") || (firstName == "LEAVE") || (firstName == "EXIT"))
            {
                Console.WriteLine(" Nobody likes a quitter...");
                return;
            }
            
            Console.WriteLine("What is your Last Name");
            lastName = Console.ReadLine().ToUpper();
            Console.Clear();
            
            if ((lastName == "QUIT") || (lastName == "LEAVE") || (lastName == "EXIT"))
            {
                Console.WriteLine(" Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("Nice to mee you " + firstName + lastName);
            Console.Clear();
            
            //Retirement Check
            Console.WriteLine("What is your age");
            check = Console.ReadLine().ToUpper();
            if ((check == "QUIT") || (check == "LEAVE") || (check == "EXIT"))
            {
                Console.WriteLine(" Nobody likes a quitter...");
                return;
            }
            else 
            {
                age = int.Parse(check);
                Console.Clear();
            }
            
            summ = remainingWork - age;
            retire = summ.ToString(); 
            
            if (retire.EndsWith("1") || retire.EndsWith("3") || retire.EndsWith("5") || retire.EndsWith("7") || retire.EndsWith("9"))
            {
                summ = summ -10;
                retire = summ.ToString();
            }
            else
            {
                summ = summ +10;
                retire = summ.ToString(); 
            }
            
            //Birth Month and Bank Account Calculation 
            Console.WriteLine("What is your birth month, ex: 01 for January");
            bMonth = int.Parse(Console.ReadLine());
            Console.Clear();

            if ((bMonth < 1) && (bMonth > 12))
            {
                money = "$0.00";
            }
            else if ((bMonth >= 1) && (bMonth <= 4))
            {
                summ = 99*3;
                money = summ.ToString();
            }
            else if ((bMonth >= 5) && (bMonth <= 8))
            {
                summ = 1000 * 2;
                money = "$" + summ.ToString();
            }
            else if ((bMonth >= 9) && (bMonth <= 12))
            {
                summ = 1000000 * 2;
                money = "$" + summ.ToString();
            }

            //Color Selection and Transportation Determination
            Console.WriteLine("Please select your favorite color from ROYGBIV");
            color = Console.ReadLine().ToUpper();
            Console.Clear();

            if (color == "HELP")
            {
                Console.WriteLine("ROYGBIV is an acronym for the following colors");
                Console.WriteLine("R---ED");
                Console.WriteLine("O---RANGE");
                Console.WriteLine("Y---ELLOW");
                Console.WriteLine("G---REEN");
                Console.WriteLine("B---LUE");
                Console.WriteLine("I---NDIGO");
                Console.WriteLine("V---IOLET");
                Console.WriteLine("Please select one");
                Console.ReadLine();
                Console.Clear();
            }
            else if (color == "EXIT")
            {
                Console.WriteLine("No body likes a quitter...");
                return;
            }

            switch (color)
            {
                case "RED":
                    transport = "10 BMW's";
                    break;
            
                case "ORANGE":
                    transport = "RTA is your best friend";
                    break;
                
                case "YELLOW":
                    transport = "Scooter"; 
                    break;
            
                case "GREEN":
                    transport = "Chevy Impala";
                    break;
                
                case "BLUE":
                    transport = "fLYiNg nImBUs!?...better watch out for Goku...";
                    break;
                
                case "INDIGO":
                    transport = "Audi....the old 2000 one though"; 
                    break;
            
                case "VIOLET":
                    transport = "2025 Mustang";
                    break;
                
                default:
                    color = "you walking bruhhh";
                    break;
            }
            
            //Vaction Home via Siblings input
            Console.WriteLine("How many siblings do you have");
            siblings = int.Parse(Console.ReadLine());
            Console.Clear();
            summ = siblings; 

            if (summ < 1)
            {
                home = "Welp you live you in a cave, not like you need much";
            }
            else if (summ == 1)
            {
                home = "Moving up from the hood now we got an apartment";
            }
            else if (summ == 2)
            {
                home = "CLEVELAND HTS BRUGGGGGG";
            }
            else if (summ == 3)
            {
                home = "University HTS 5 bedroom";
            }
            else if (summ >= 4)
            {
                home = "Hollywood, Im talking 23 acres";
            }
            Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " years with " + money + " in the bank. A vacation home in " + home + " , and " + transport + " as transportation!" );

        }
    }
}
        