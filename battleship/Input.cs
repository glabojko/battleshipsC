namespace Battleships_game
{
    class Input
    {
        public static string GetMenuChoice()
        {
            return "";
        }
        public static (int row, int col, string direction) GetPieceOfShipPlacement()
        {
            return (0, 0, "");


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