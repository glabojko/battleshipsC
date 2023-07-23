namespace Battleships_game
{
    class Player
    {
        public Player(string InputtedNickname = "adam") {
            string Nickname = InputtedNickname;
            char[,] PlayerBoard = new char[10, 10];
        }
        public static void HandleShot()
        {
                Console.WriteLine("Tu siec cos da ale nwm co");
        }
        public static bool AllShipsSunk(bool isAlive = true)
        {
            return isAlive;

                // sprawdzanie czy wszytskie statki sa zatopione
                // zwraca ( bool ) czyli true lub false
        }
        public static (int wynik1, int wynik2, int wynik3) GetHighestScores() {
            return (0, 0, 0);
        }
    }
}