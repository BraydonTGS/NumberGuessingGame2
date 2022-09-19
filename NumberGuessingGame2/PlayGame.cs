using System;
using System.Drawing;


namespace NumberGuessingGame2
{
    public class PlayGame
    {
        private int Min;
        private int Max;
        private double Coins;
        private Random RandomNumber;
        private int UserGuess;
        private int Guesses;
        private bool KeepPlaying;

        public PlayGame()
        {
            Min = 1;
            Max = 100;
            Coins = 4;
            RandomNumber = new Random();
            Guesses = 0;
            KeepPlaying = true;
        }

        public void Start()
        {
            PrintMethods.PrintTitle();
            Console.WriteLine($"> You have {Coins} coins ");
            Console.WriteLine();
            Console.Write("> Please Enter a Coin! ");
            Console.ReadLine();
            Console.WriteLine();

            int random = RandomNumber.Next(Min, Max);
            Coins -= 1;
            PlayRound(random);
        }

        public void PlayRound(int rnd)
        {
            Console.WriteLine($"> Number of Guesses: > {Guesses} <");
            Console.WriteLine();
            Console.Write($"> Please Enter a Number between {Min} and {Max}: ");
            UserGuess = int.Parse(Console.ReadLine());

            if (rnd > UserGuess)
            {

                High(rnd);

            }
            else if (rnd < UserGuess)
            {
                Low(rnd);
            }

            else
            {
                Win();
            }
        }

        public void Win()
        {
            PrintMethods.PrintTitle();
            Console.WriteLine($"> YOU WON THE GAME! Number of Guesses: {Guesses}");
            Console.WriteLine();
            Console.WriteLine($"> You have {Coins} coins left! ");
            Console.WriteLine();
            PlayAgain();

        }

        public void High(int rnd)
        {
            PrintMethods.PrintTitle();
            Console.WriteLine("> Too low, try again. ");
            Console.WriteLine();
            Guesses++;
            PlayRound(rnd);
        }

        public void Low(int rnd)
        {
            PrintMethods.PrintTitle();
            Console.WriteLine("> Too high, try again. ");
            Console.WriteLine();
            Guesses++;
            PlayRound(rnd);

        }

        public void PlayAgain()
        {
            Guesses = 0;
            Console.Write("> Would You Like to Play Again? (Y/N) ");
            string userResponse = Console.ReadLine().ToUpper();
            Console.Clear();

            if (userResponse == "Y" && Coins > 0)
            {
                Start();
            }
            else if (userResponse == "N")
            {

                Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
                Console.WriteLine();
                Console.Write("> Sounds Good! See you next time!");
                Console.ReadKey();
            }

            else if (Coins == 0)
            {

                Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
                Console.WriteLine();
                Console.Write("> OH NO! You are out of coins! ");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("> Please Enter a Valid Choice");
                PlayAgain();
            }
        }

    }
}

