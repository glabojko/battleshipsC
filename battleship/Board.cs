using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public class Board
    {
        public static char[,]? board;
        public static void InitializeBoard(string[,] board)
        {
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    // Fill the board with "X" signs
                    board[row, col] = "0";
                }
            }
        }

         public static void DisplayBoard(string[,] board)
            {

                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {

                        Console.Write($"{board[row, col],1} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

