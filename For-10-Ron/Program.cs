using System;

namespace For_10_Ron
{
    class Program
    {
        const int GAMES = 5;

        static void Main(string[] args)
        {
            int i = 0, p1Sum = 0, p2Sum = 0, p1Wins = 0, p2Wins = 0, draws = 0, currP1 = 0, currP2 = 0;

            Console.WriteLine("*****Welcome to Basketball calculator 9000*****\n");

            for (i=0; i < GAMES; i++)
            {
                Console.Write($"How much did player 1 score in game {i + 1}? ");
                currP1 = int.Parse(Console.ReadLine());
                p1Sum += currP1;

                Console.Write($"How much did player 2 score in game {i + 1}? ");
                currP2 = int.Parse(Console.ReadLine());
                p2Sum += currP2;
                Console.WriteLine();

                if (currP1 > currP2)
                {
                    Console.WriteLine($"Game {i + 1}: Player 1 won!\n");
                    p1Wins++;
                }
                else if (currP2 > currP1)
                {
                    Console.WriteLine($"Game {i + 1}: Player 2 won!\n");
                    p2Wins++;
                }
                else
                {
                    Console.WriteLine($"Game {i + 1}: Draw.\n");
                    draws++;
                }
            }
            if (p1Sum > p2Sum)
            {
                Console.WriteLine($"Games total: Player 1 got the most points!");
            }
            else if (p2Sum > p1Sum)
            {
                Console.WriteLine($"Games total: Player 2 got the most points!");
            }
            else
            {
                Console.WriteLine($"Games total: Draw in points");
            }

            // printing wins for each 
            Console.WriteLine($"Player 1 won {p1Wins} games\nPlayer 2 won {p2Wins} games\n{draws} Draws");
            Console.ReadLine();
        }
    }
}
