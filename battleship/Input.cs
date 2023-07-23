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
                else { Console.WriteLine("Weź się nie zgrywaj"); }
            }
            return InputToReturn;
        }
        public static string GetPlayerName() {
            bool CorrectInput = false;
            string PlayerName = "Gracz1";
            while (!CorrectInput) 
            {   Display.IntroduceYourself();
                string UserInput = Console.ReadLine();
                if (string.IsNullOrEmpty(UserInput)) {
                   Display.WrongName();
                    } 
                else { CorrectInput = true; }
            }
            return PlayerName;


        //public static (int row, int col) GetPieceOfShipPlacement()
        //{
          //  return (0, 0);


            // dodac jakies ify zeby input byl na pewno poprawny a nie za granica boarda
            // funckja pobiera kordynatu jednej kratki i stawia ja na mapie 
            // statki beda dodawane w kolejnosci i bedzie logika sprawdzajaca czy kratki sa dobrze rozmieszczone kolo siebie i wgl poprawnosc
            // wywolanie logiki postawienia statku jezeli wszytsko jest ok
        }
        public static (int row, int col) GetShotCoordinates()
        {
            return (0, 0);

            // dodac jakies ify zeby input byl na pewno poprawny a nie za granica boarda 
            // oraz wywolc sprawdzenie czy jest tam statek/jest zbity itp.
        }

        // funckje ( GetPieceOfShipPlacement ) i ( GetShotCoordinates ) mozna przerobic zeby pobieraly row jako string
        // wtedy podanie przez uzytkownika kordynatow bedzie wygladac mniej wiecej tak: A5 | G8 (moim zdaniem wyglada lepiej)
        // przyklad implementacji funkcji: 
        // public static (string row, int col) GetShotCoordinates(string row = "A", int col = 0) {
    }
}