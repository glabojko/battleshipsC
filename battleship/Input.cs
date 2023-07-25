using battleship;

namespace Battleships_game
{
    // menu > rozpocznij gre > set nickname > new player > new game > new board > random placement > game
    class Input
    {
        public static int GetMenuChoice() {
            bool CorrectInput = false;
            int InputToReturn = 0;
            while (!CorrectInput) 
            {
                Console.Write("Podaj numerek: ");
                string UserInput = Console.ReadLine();
                if (int.TryParse(UserInput, out int ParsedInput) && ParsedInput == 1 || ParsedInput == 2) {
                    InputToReturn = ParsedInput;
                    CorrectInput = true;
                } 
                else { Display.IntroduceYourself(); }
            }
            return InputToReturn;
        }
        public static string GetPlayerName()
        {
            bool CorrectInput = false;
            string PlayerName = "Gracz1";
            while (!CorrectInput)
            {
                Display.IntroduceYourself();
                string UserInput = Console.ReadLine();
                if (string.IsNullOrEmpty(UserInput))
                {
                    Display.WrongName();
                }
                else { CorrectInput = true; }
            }
            return PlayerName;
        }

        public static (int row, int col) GetPieceOfShipPlacement(int row, int col)
        {   
            bool CorrectInput = false;
            string RowUserInput;
            string ColUserInput;
            while (!CorrectInput) {
                RowUserInput = Console.ReadLine();
                ColUserInput = Console.ReadLine();
                int RowUserInputInt = Convert.ToInt32(RowUserInput);
                int ColUserInputInt = Convert.ToInt32(ColUserInput); 
                    
                if (RowUserInputInt < Board.boardSize && ColUserInputInt < Board.boardSize) {
                    return (0, 0);
                } else {
                    return (0, 0);
                }
            

                    // for i in naszaPlansza:
                    //     [0,0] = [0=wartosc ze slownika dla klucza o numerze od 0 do 9 , 0=0+1]

                    // ✔︎ pobierz nowe wartosci dla  2 nowych zmiennych 
                    // ✔ przekonwertuj zmienne na inty 
                    // ✘ po przekonwertowaniu sprawdz warunki ktore maja byc (czzy jest w tablicy, czy dotyka tego statku ktoego ma, czy dotyka innego statku)
                    // jezeli wszytsko ok to zapisz zmienne do naszych zmiennyh row, col, wylacz petle i zwroc wynik
                    // jezeli cos sie nie zgadza wroc do inputów i popros o zmienne jeszcze raz
                }
                return (0,0);
            }
            //public static (int row, int col) GetShotCoordinates()
            //{
            //   return (0, 0);

            // dodac jakies ify zeby input byl na pewno poprawny a nie za granica boarda 
            // oraz wywolc sprawdzenie czy jest tam statek/jest zbity itp.
        }

        // funckje ( GetPieceOfShipPlacement ) i ( GetShotCoordinates ) mozna przerobic zeby pobieraly row jako string
        // wtedy podanie przez uzytkownika kordynatow bedzie wygladac mniej wiecej tak: A5 | G8 (moim zdaniem wyglada lepiej)
        // przyklad implementacji funkcji: 
        // public static (string row, int col) GetShotCoordinates(string row = "A", int col = 0) {
}