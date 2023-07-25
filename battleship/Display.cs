using System.Security.Cryptography.X509Certificates;

namespace Battleships_game
{
    public class Display
    {
        public static void IntroduceYourself(){
            Console.WriteLine("Jak masz na imię?");
        }
        public static void WrongName(){ 
            Console.WriteLine("No na pewno...");
        }
        public static void PrintMenu()
        {
            Console.WriteLine("<--- Witaj w grze Battleships --->");
            Console.WriteLine("");
            Console.WriteLine("Wpisz numer opcji aby ją wybrać!");
            Console.WriteLine("1. Rozpocznij grę");
            Console.WriteLine("2. Wyjdź z programu");
            Console.WriteLine("");
            Console.WriteLine("Najlepsze wyniki: ");
            Console.WriteLine("1. adam:  ∞ pkt");
        }
        public static void PrintManualShipPlacement()
        {
            Console.WriteLine("Tworzenie tablicy!");
            Console.WriteLine("Tablica to pole o wymiarach 10x10");
            Console.WriteLine("Masz do dyspocyzji takie statki: ");
            Console.WriteLine(" ");
            Console.WriteLine("1 statek typu 'Carrier' o długości 5 pól");
            Console.WriteLine("1 statek typu 'Battleship' o długości 4 pól");
            Console.WriteLine("1 statek typu 'Cruiser' o długości 3 pól");
            Console.WriteLine("2 statki typu 'Destroyer' o długości 2 pól każdy");
            Console.WriteLine("2 statki typu 'Submarine' o długości 1 pola każdy");
            
            // for (int ShipNumber = 0; ShipNumber < Ship.ShipsToCreate.Count; ShipNumber++) {
            //     for (int pieces = 0; pieces < Ship.GetShipSize(ShipNumber); pieces++) {
            //         (int row, int col) = Input.GetPieceOfShipPlacement();
            //         Ship.PlacePieceByCordinates(row, col);
            //     }
            // }
        }
        public static void PrintGameplay()
        {
            Console.WriteLine("Rozgrywka trwa!");
            // stworzyc funkcje ktora bedzie wyswietlac plansze w czasie rozgrywki
        }
        public static void PrintGameOver(bool isAlive)
        {
            Console.WriteLine("Gra zako�czona!");
            // tutaj chyba tylko tyle bedzie
        }
    }
}