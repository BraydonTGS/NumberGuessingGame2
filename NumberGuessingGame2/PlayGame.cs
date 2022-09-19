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


        public PlayGame()
        {
            Min = 1;
            Max = 100;
            Coins = 4;
            RandomNumber = new Random();
            Guesses = 0;

        }

        public void Start()
        {
            PrintMethods.PrintTitle();
            Console.WriteLine($"> You have {Coins} coins ");
            Console.WriteLine();
            Console.Write("> Please Enter a Coin! ");
            Console.ReadLine();
            Console.WriteLine();
            PrintMethods.PrintTitle();
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
            PrintMethods.YouWon(Guesses, Coins);
            PlayAgain();

        }

        public void High(int rnd)
        {
            PrintMethods.High();
            Guesses++;
            PlayRound(rnd);
        }

        public void Low(int rnd)
        {
            PrintMethods.Low();
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
                PrintMethods.GameOver(userResponse, Coins);
            }

            else if (Coins == 0)
            {
                PrintMethods.GameOver(userResponse, Coins);
            }
            else
            {
                PrintMethods.Error();
                PlayAgain();
            }
        }

    }
}

