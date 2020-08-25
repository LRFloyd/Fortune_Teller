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
            
            

        }
    }
}
        