
namespace Battleships_game
{
    public class Display
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Witaj w grze Battleships!");
            // stworzyc menu gry ktore pokazuje sie po wlaczeniu programu
        }
        public static void PrintManualShipPlacement()
        {
            Console.WriteLine("Tworzenie tablicy!");
            // stworzyc mini menu w ktorym gracz bedzie tworzyl swoja tablice ze statkami
        }
        public static void PrintGameplay()
        {
            Console.WriteLine("Rozgrywka trwa!");
            // stworzyc funkcje ktora bedzie wyswietlac plansze w czasie rozgrywki
        }
        public static void PrintGameOver(bool isAlive)
        {
            Console.WriteLine("Gra zakoñczona!");
            // tutaj chyba tylko tyle bedzie
        }
    }
}