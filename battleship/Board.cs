using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public class Board
    {
        public static int boardSize = 10;
        public static char[,] board = new char[boardSize, boardSize];
        public static void InitializeBoard(string[,] board)
        {
            for (int row = 0; row < boardSize; row++)
    {
                for (int col = 0; col < boardSize; col++)
                {
                    char letter = (char)('a' + row);
                    int number = col + 1;
                    board[row, col] = letter.ToString() + number.ToString();
                }
            }
        }

         public static void DisplayBoard(string[,] board)
            {

                for (int row = 0; row < boardSize; row++)
                {
                    for (int col = 0; col < boardSize; col++)
                    {

                        Console.Write($"{board[row, col],1} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

