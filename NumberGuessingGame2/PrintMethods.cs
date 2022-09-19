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

        public static void GameOver(string response, double coins)
        {
            if (response == "N")
            {
                Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
                Console.WriteLine();
                Console.Write("> Sounds Good! See you next time!");
                Console.ReadKey();
            }
            else if (coins == 0)
            {

                Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
                Console.WriteLine();
                Console.Write("> OH NO! You are out of coins! ");
                Console.ReadKey();

            }



        }
    }
}

