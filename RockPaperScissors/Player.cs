using System;
namespace RockPaperScissors
{
    public class Player
    {
        public string playerMove;
        public string playerInput;


        public Player()
        {
            PlayerInput();
        }

        public void PlayerInput()
        {
            playerInput = Console.ReadLine().ToUpper();
            playerMove = playerInput;
        }
    }
}
