using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatypes are declared here, hit = correct range, rangeset = range set by user, input = user input in console.
            int hit = 6;
            int rangeset = 0;

            //Initial information about what the user should do.
            Console.WriteLine("Ship Sinking Time!\nThere is an enemy ship approaching in the far distance, guess the range and see if you can make a hit!");
            Console.WriteLine("We know that range is longer than 0 (we are at 0) but may only extend to 10\nYour best bet is to aim somewhere between 1-10!");

            //While loop that checks if the value of rangeset isn't hit, if rangeset isn't the hit value, the program will make the user type a value that rangeset will assume.
            while (rangeset != hit)
            {
                String input = Console.ReadLine();
                int.TryParse(input, out rangeset);

                if (rangeset <= 4 || rangeset >= 8)
                {
                    System.Console.WriteLine("Miss!");
                    System.Console.WriteLine("Try again!");
                }
                if (rangeset == 5 || rangeset == 7)
                {
                    System.Console.WriteLine("Near miss!\nYou're not far off now!");
                }
                else if (rangeset == 0)
                {
                    System.Console.WriteLine("Please enter a valid range value between 1-10 to see if you can hit");
                }
            }

            //When while loop ends, message below is displayed.
            System.Console.WriteLine("You did it! You've sunk the enemy ship!\nPress ENTER to exit.");

            Console.ReadLine();
        }
    }
}
