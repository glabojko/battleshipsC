// Funkcje:

// Funkcja rozpoczęcia gry
// Funkcja wyświetlająca planszę gry
// Funkcja do losowego rozmieszczenia statków na planszy
// Funkcja do pobierania ruchu gracza
// Funkcja sprawdzająca trafienie i aktualizująca planszę
// Funkcja sprawdzająca warunki zakończenia gry
// Funkcja wyświetlająca wynik gry


// Zmienne:

// Zmienna przechowująca planszę gry, np. dwuwymiarowa tablica
// Zmienne przechowujące informacje o statkach, takie jak ich rozmieszczenie i trafienia
// Zmienne do śledzenia liczby trafień, pudłów itp
// Zmienna przechowująca informacje o aktualnym stanie gry, czyli czy gra jest w trakcie czy zakończona


// Mini plan działania: 

// Stworzenie planszy gry o odpowiednim rozmiarze, np. 10x10
// Rozmieszczenie statków na planszy w losowy sposób
// Wykorzystać znaki specjalne np. "." dla pustego pola, "X" dla trafienia i "O" dla pudła
// Wyświetlenie planszy w czytelny sposób aby gracz mógł zobaczyć stan mapy
// Przemyśleć logikę sprawdzania trafień i zakończenia gry
// Zapewnienie interakcji z graczem, pozwalając mu wprowadzać ruchy przy tym wyświetlając odpowiednie komunikaty


// Statki: 

// 1 statek typu "Carrier" (zwany również "Lotniskowcem") o długości 5 pól
// 1 statek typu "Battleship" (znany również jako "Pancernik") o długości 4 pól
// 1 statek typu "Cruiser" (nazywany również "Krążownikiem") o długości 3 pól
// 2 statki typu "Destroyer" (nazywane również "Niszczycielami") o długości 2 pól każdy
// 2 statki typu "Submarine" (zwane również "Okrętami podwodnymi") o długości 1 pola każdy
using System;

public class Battleship
{
    public static void Main(string[] args)
    {
        bool GameOver = false;
        Display display = new Display();

        while (!GameOver)
        {
            display.DisplayBoard();
            GameOver = true; // For demonstration purposes, set to true to break the loop after the first display
        }

        Console.WriteLine("Koniec gry i tutaj będzie jeszcze cała plansza pokazana!");
    }
}

public class Display
{
    private char[,] board = new char[10, 10];

    public Display()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                board[row, col] = '•';
            }
        }
    }

    public void DisplayBoard()
    {
        PrintBoard();
    }

    public void PrintBoard()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(board[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
