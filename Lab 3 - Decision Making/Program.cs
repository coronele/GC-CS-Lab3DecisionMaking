using System;

namespace Lab_3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string userName, userContinue="y";

            // Tell user what this is
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Number evaluator");

            // User provided input
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\nHello! Please enter your name");
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            userName = Console.ReadLine();

            while (userContinue == "y") // program will run until user replies "n" to the repeat prompt.
            {
                // Use provided name.  It's good customer service!  Now politely ask them for their number.
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n\nHello {userName}! Please enter an integer between 1 and 100 to evaluate: \n");
            
                Console.ForegroundColor = ConsoleColor.DarkGray;
                userInput = int.Parse(Console.ReadLine());

                while ((userInput < 1) || (userInput > 100))
                {
                    // check for invalid integer values
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Value must be between 1 and 100. Please try again: ");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    userInput = int.Parse(Console.ReadLine());
                }

                Console.ForegroundColor = ConsoleColor.White;

                // Evaluate and output to console
                if (IsOdd(userInput))
                {
                    if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}  Odd [60 and up]\n");
                    }
                    else
                    {
                        Console.WriteLine($"{userInput}  Odd\n");
                    }
                }
                else
                {
                    if ((userInput >= 2) && (userInput <= 25))
                    {
                        Console.WriteLine($"{userInput}  Even and less than 25\n");
                    }
                    else if ((userInput >= 26) && (userInput <= 60))
                    {
                        Console.WriteLine($"{userInput}  Even [26 thru 60]\n");
                    }
                    else if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}  Even [60 and up]\n");
                    }
                }

                // That was fun. Would you like to play again?
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write($"\nWould you like to analyze another number, {userName} [y/n]? ");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Black;
                userContinue = Console.ReadLine().ToLower();
                
                // Mildly inform user of their "user error"
                while ((userContinue!="y") && (userContinue!="n"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"I'm SO sorry {userName}, you did NOT provide a valid response.");
                    Console.Write($"Let's try this again. Would you like to check another number? [y/n] ");

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.BackgroundColor = ConsoleColor.Black;
                    userContinue = Console.ReadLine().ToLower();
                }
            }
            Console.WriteLine("\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Thank you {userName}, See you again soon!");
        }

        /*******************************

        IsOdd - method that takes an integer (x) and uses mod to see if the number is divided
        evenly by 2 (or is even).

        Returns false if integer mod 2 is 0 (even)
        Returns true if integer mod 2 is 1 (odd)

        ********************************/
        public static bool IsOdd(int x)
        {
            if (x % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
