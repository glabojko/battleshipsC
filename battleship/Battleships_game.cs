using System;
using System.Data;
using System.Dynamic;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Battleships_game
{
    class Game
    {
        public static void Main()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                Display.PrintMenu();
                int UserInput = (int)Input.GetMenuChoice();
                if (UserInput == 1) {
                    Input.GetPlayerName();
                }
                else if (UserInput == 2) {
                    gameOver = true;
                }
                gameOver = Player.AllShipsSunk();
            }
        }
        public static void RoundFlow()
        {
            Display.PrintMenu();
            Display.PrintGameplay();

            // var ShorCordinates = Input.GetShotCoordinates();
            // player.HandleShot()
        }

    }
}