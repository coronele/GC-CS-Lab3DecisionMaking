using System;

namespace Lab_3___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string userName, userContinue="y";

            /* 
            
            IsOdd - method that takes an integer (x) and uses mod to see if the number is divided
            evenly by 2 (or is even).

            Returns false if integer mod 2 is 0 (even)
            Returns true if integer mod 2 is 1 (odd)

            */
            
            static bool IsOdd(int x)
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

            while (userContinue == "y")
            {
                // Use provided name.  It's good customer service!  Now politely ask them for their number.
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n\nHello {userName}! Please enter an integer to evaluate: ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                userInput = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;


                // Evaluate and output to console
                if (IsOdd(userInput))
                {
                    if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}  Odd [60 and up]");
                    }
                    else
                    {
                        Console.WriteLine($"{userInput}  Odd");
                    }
                }
                else
                {
                    if ((userInput >= 2) && (userInput <= 25))
                    {
                        Console.WriteLine($"{userInput}  Even and less than 25");
                    }
                    else if ((userInput >= 26) && (userInput <= 60))
                    {
                        Console.WriteLine($"{userInput}  Even [26 thru 60]");
                    }
                    else if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput}  Even [60 and up]");
                    }
                }

                // That was fun. Would you like to play again?
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Would you like to analyze another number, {userName}?");
                userContinue = Console.ReadLine().ToLower();
                
                // Mildly inform user of his "user error"
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Thank you {userName}, See you again soon!");
        }
    }
}
