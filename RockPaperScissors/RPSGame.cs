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
        string playerInput;


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
            Console.ResetColor();
        }


        public void PlayerMove()
        {
            playerInput = Console.ReadLine().ToUpper();



        }

        public void CpuMove()
        {
            Random random = new Random();
            cpuMove = random.Next(1, 3);
            Console.WriteLine(cpuMove);

        }


        public void winCondition()
        {

            if (playerInput == "PAPER")
            {
                if (cpuMove == 1)
                {
                   Console.WriteLine("Draw! Computer picked Paper");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
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

            else if (playerInput == "SCISSORS")
            {
                if (cpuMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Scissors");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
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

            else if (playerInput == "ROCK")
            {
                if (cpuMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Rock");
                }
                else if (cpuMove == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
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
            if (player1Score.Count < 5 || cpuScore.Count < 5)
            {
                Console.WriteLine("Rock, Paper or Scissors?");
            }
            else
            {
                Console.WriteLine("Thanks for playing. Game Over. Press any key to exit");
                Console.ReadKey();
                return;
            }


        }

        private void FirstToFive()
        {

                PlayerMove();
                CpuMove();
                winCondition();

        }

    }
}