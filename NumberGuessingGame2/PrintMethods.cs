using System;
using System.Drawing;

namespace NumberGuessingGame2
{
    public class PrintMethods
    {
        public static void PrintTitle()
        {
            Console.Clear();
            Console.WriteLine(@" +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ +-+-+-+-+
 |N|u|m|b|e|r| |G|u|e|s|s|i|n|g| |G|a|m|e|
 +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ +-+-+-+-+");
            Console.WriteLine();

        }

        public static void PrintCoins(double coins)
        {
            Console.WriteLine($"> You have {coins} coins ");
            Console.WriteLine();
            Console.Write("> Please Enter a Coin! ");
            Console.ReadLine();
            Console.WriteLine();
        }

        public static void YouWon(int guesses, double coins)
        {
            PrintMethods.PrintTitle();
            Console.WriteLine($"> YOU WON THE GAME! Number of Guesses: {guesses} ");
            Console.WriteLine();
            Console.WriteLine($"> You have {coins} coins left! ");
            Console.WriteLine();
        }

        public static void High()
        {
            PrintTitle();
            Console.WriteLine("> Too low, try again. ");
            Console.WriteLine();
        }

        public static void Low()
        {
            PrintTitle();
            Console.WriteLine("> Too high, try again. ");
            Console.WriteLine();
        }

        public static void PrintGameOver()
        {
            Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
            Console.WriteLine();
        }

        public static void GameOver(string response, double coins)
        {
            if (response == "N")
            {
                PrintGameOver();
                Console.Write("> Sounds Good! See you next time!");
                Console.ReadKey();
            }
            else if (coins == 0)
            {
                PrintGameOver();
                Console.Write("> OH NO! You are out of coins! ");
                Console.ReadKey();
            }
        }

        public static void Error()
        {
            PrintTitle();
            Console.WriteLine("> Please Enter a Valid Choice");
            Console.WriteLine();
        }


    }
}

