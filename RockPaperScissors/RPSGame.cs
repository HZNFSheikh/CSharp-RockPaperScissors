using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{

    class RPSGame
    {

        List<int> player1Score = new List<int>();
        List<int> cpuScore = new List<int>();

        int cpuMove;
        string playerMove;


        public RPSGame()
        {

            StartGame();
            FirstToFive();


        }



        public void StartGame()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is Rock Paper Scissors. To play a round pick from: Rock, Paper or Scissors");

        }


        public void PlayerMove()
        {
            playerMove = Console.ReadLine().ToUpper();



        }

        public void CpuMove()
        {
            Random random = new Random();
            cpuMove = random.Next(1, 3);
            Console.WriteLine(cpuMove);

        }


        public void winCondition()
        {

            if (playerMove == "PAPER")
            {
                if (cpuMove == 1)
                {
                   Console.WriteLine("Draw! Computer picked Paper");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Winner! Computer picked Rock");
                    player1Score.Add(1);
                    Console.WriteLine("Player 1 Wins!");

                }
                else if (cpuMove == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Loser! Computer picked Scissors");
                    cpuScore.Add(1);
                    Console.WriteLine("Unlucky, the CPU got the better of you");
                    Console.ResetColor();
                }

            }

            else if (playerMove == "SCISSORS")
            {
                if (cpuMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Scissors");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Winner! Computer picked Paper");
                    player1Score.Add(1);
                    Console.Write("Player 1 wins");
                    Console.ResetColor();

                }
                else if (cpuMove == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Loser! Computer picked Rock");
                    cpuScore.Add(1);
                    Console.WriteLine("Unlucky, the CPU got the better of you");
                    Console.ResetColor();

                }
            }

            else if (playerMove == "ROCK")
            {
                if (cpuMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Rock");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Winner! Computer picked Scissors");
                    player1Score.Add(1);
                    Console.WriteLine("Playerwins");
                    Console.ResetColor();
                }
                else if (cpuMove == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Loser! Computer picked Paper");
                    cpuScore.Add(1);
                    Console.WriteLine("Unlucky, the CPU got the better of you");
                    Console.ResetColor();

                }

            }

            else
            {
                Console.WriteLine("Not a valid move!");
            }
            Console.WriteLine("Press Enter for the next round");
            Console.ReadLine();
          


        }

        private void FirstToFive()
        {

                PlayerMove();
                CpuMove();
                winCondition();

        }

    }
}