using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller___Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, userFavoriteColor, vacationHome, modeOfTransportation, yearsUntilRetirement, moneyInAccount;
            int userAge, userBirthMonth, numberOfSiblings;

            //Ask the user for the user’s first name,last name, user’s age and birth month.

            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your age.");
            userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter birth month as a number");
            userBirthMonth = int.Parse(Console.ReadLine());

            //Ask the user for the user’s favorite ROYGBIV color and number of siblings.

            Console.WriteLine("What is your favorite ROYGBIV color? If your not sure of what ROYGBIV, type \"help\"");
            userFavoriteColor = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            numberOfSiblings = int.Parse(Console.ReadLine());

            //establish if userAge is odd or even.
            if (userAge % 2 == 0)
            {
                yearsUntilRetirement = "35 exciting years";
            }
            else
            {
                yearsUntilRetirement = "7 lovely years";
            }
            //ask user for number of sibling 

            if (numberOfSiblings == 0)
            {
                vacationHome = "Los Angeles, CA";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "San Antonio, TX";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = " Myrtle Beach, SC";
            }
            else if (numberOfSiblings >= 3)
            {
                vacationHome = "Ontario CA";
            }
            else
            {
                vacationHome = "Milwaukee";
            }

            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
            if (userFavoriteColor.ToLower() == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, violet. So what is your favorite color?");
            }
            userFavoriteColor = Console.ReadLine();

            if (userFavoriteColor.ToLower() == "red")
            {
                modeOfTransportation = "jet ski";
            }
            else if (userFavoriteColor.ToLower() == "orange")
            {
                modeOfTransportation = " an airplane";
            }
            else if (userFavoriteColor.ToLower() == "yellow")
            {
                modeOfTransportation = "a train";
            }
            else if (userFavoriteColor.ToLower() == "green")
            {
                modeOfTransportation = " a snowmobile";
            }
            else if (userFavoriteColor.ToLower() == "blue")
            {
                modeOfTransportation = "a motorcycle";
            }
            else if (userFavoriteColor.ToLower() == "indigo")
            {
                modeOfTransportation = " an automobile";
            }
            else if (userFavoriteColor.ToLower() == "violet");
            {
                modeOfTransportation = " a scooter";
            }
            // If the user’s birth month is 1-4, they will have $____ in the bank; if the user's birth month is 5-8, they will have $____ in the bank; and if it is 9-12, then they will have $____ in the bank. If the user enters something other than 01-12 as their birth month, they will have $0.00 in the bank.

            if (userBirthMonth > 0 && userBirthMonth <= 4)
            {
                moneyInAccount = "sixty five dollars";
            }
            else if (userBirthMonth >= 5 && userBirthMonth <= 8)
            {
                moneyInAccount = "seven hundred dollars";
            }
            else if (userBirthMonth >= 9 && userBirthMonth <= 12)
            {


                moneyInAccount = "twenty dollars";
                //users fortune should be listed using replacement strings.

            }
            else
            {
                moneyInAccount = "zero dollars";

            }
            Console.WriteLine(firstName + " " + lastName + " will retire in " + yearsUntilRetirement + " with " + moneyInAccount + " in the bank, a vacation home in " + vacationHome + " and " + modeOfTransportation + ".");
            Console.ReadLine();

        }
    }

}
        
    