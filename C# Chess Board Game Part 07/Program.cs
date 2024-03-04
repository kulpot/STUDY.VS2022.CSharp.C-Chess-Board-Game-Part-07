using ClassBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------------- C# Chess Board 02 board cell classes -------------------------------
//ref link:https://www.youtube.com/watch?v=SFMVyiJ2S6g&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=3

// addNewItemToSolution:class library(name:ClassBoardModel), addNewClassTo:ClassBoardModel(name:Cell.cs/Board.cs),

//-------------------- C# Chess Board 03 next legal moves -------------------------------------------------
//ref link:https://www.youtube.com/watch?v=iV9hBTi-QB8&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=5&t=20s

//-------------------- C# Chess Board 04 program flow -------------------------------------------------
//ref link:https://www.youtube.com/watch?v=xc6C2I_wAxI&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=4

// Add ref to:C# Chess Board 04->Add->Reference...->Projects->ChessBoardModel,

//-------------------- C# Chess Board 05 print board squares -----------------------------------------------
//ref link:https://www.youtube.com/watch?v=U9dsYjKaEAo&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=6

// PrintBoard method,

//-------------------- C# Chess Board Game 06 place piece -------------------------------------------------------
//ref link:https://www.youtube.com/watch?v=qV1ib7dfXvk&list=PLhPyEFL5u-i0YDRW6FLMd1PavZp9RcYdF&index=6

//

namespace C__Chess_Board_02
{
    class Program
    {
        //--------START---------- C# Chess Board 04 program flow -------------------------------------------------
        static Board myBoard = new Board(8);
        //--------END---------- C# Chess Board 04 program flow -------------------------------------------------

        static void Main(string[] args)
        {
            //-------START----------- C# Chess Board 04 program flow -------------------------------------------------

            // show the empty chess board
            //--------START---------- C# Chess Board 05 print board squares -----------------------------------------------
            printBoard(myBoard);
            //--------END---------- C# Chess Board 05 print board squares -----------------------------------------------

            // ask the user for an x and y coordinate where we will place a piece
            //--------START---------- C# Chess Board Game 06 place piece -------------------------------------------------------
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            //---------END--------- C# Chess Board Game 06 place piece -------------------------------------------------------

            // calculate all legal moves for that piece
            //--------START---------- C# Chess Board Game 06 place piece -------------------------------------------------------
            myBoard.MarkNextLegalMoves(currentCell, "Knight");
            //---------END--------- C# Chess Board Game 06 place piece -------------------------------------------------------


            // print the chess board. Use an X for occupied square. Use a + for legal move. Use . for empty cell.
            //--------START---------- C# Chess Board Game 06 place piece -------------------------------------------------------
            printBoard(myBoard);
            //---------END--------- C# Chess Board Game 06 place piece -------------------------------------------------------

            // wait for another enter key press before ending the program.
            //--------START---------- C# Chess Board 05 print board squares -----------------------------------------------
            Console.ReadLine();
            //--------END---------- C# Chess Board 05 print board squares -----------------------------------------------

            //--------END---------- C# Chess Board 04 program flow -------------------------------------------------

        }

        //--------START---------- C# Chess Board Game 06 place piece -------------------------------------------------------
        private static Cell setCurrentCell()
        {
            // get x and y coordinates from the user. return a cell location from the grid.
            Console.WriteLine("Enter the current row number");
            int currentRow = int.Parse(Console.ReadLine());     //Parsing for string to int

            Console.WriteLine("Enter the current column number");
            int currentColumn = int.Parse(Console.ReadLine());

            //myBoard.theGrid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.theGrid[currentRow, currentColumn];
        }
        //---------END--------- C# Chess Board Game 06 place piece -------------------------------------------------------

        //--------START---------- C# Chess Board 05 print board squares -----------------------------------------------
        private static void printBoard(Board myBoard)
        {
            // print the chess board to the console. Use X for the piece location. + for legal move. . for empty square
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if(c.CurrentlyOccupied == true)
                    {
                        Console.Write("X");
                    }
                    else if(c.LegalNextMove == true)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();        // this makes a grid of 8x8 of periods.
            }

            Console.WriteLine("====================================");
        }
        //--------END---------- C# Chess Board 05 print board squares -----------------------------------------------

    }
}
