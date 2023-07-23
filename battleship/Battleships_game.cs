using System;
using System.Data;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

namespace Battleships_game
{
    class Game
    {
        public static void Main()
        {
            bool gameOver = false;
            // Player player = new Player();
            // Board enemyBoard = new Board();
            // enemyBoard.PlaceRandomShips();
            while (!gameOver)
            {
                // stworzyc logike petli gry
                Display.PrintMenu();
                gameOver = Player.AllShipsSunk(); ;
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
   