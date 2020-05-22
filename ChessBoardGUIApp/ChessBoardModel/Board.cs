using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        // the board is always square, Typically a 8x8 style
        public int Size { get; set; }

        //2d array of cell objects
        public Cell[,] theGrid;

        public Board(int s)
        {
            Size = s;
            //initiate the array to avoid null exception errors.
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);

                }
            }

        }


        public void MarkLegalMove(int row, int col)
        {
            //Console.WriteLine(row +" " + col);
            if ((row >= 0) && (row <= Size-1) && (col >= 0) && (col <= Size-1))
            {
                theGrid[row, col].LegalNextMove = true;
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            //step 1 - clear all legal moves from previous turn
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                    theGrid[r, c].CurrentlyOccupied = false;

                }
            }
            currentCell.CurrentlyOccupied = true;
            switch (chessPiece)
            {
                case "Knight":
                    //followed the guide, had to also look at it in drawing so drew it up on an ipad to see how it would look like

                    //can't think of any other way, not smart enough lol
                    MarkLegalMove(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1);
                    MarkLegalMove(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1);
                    MarkLegalMove(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2);
                    MarkLegalMove(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2);
                    MarkLegalMove(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1);
                    MarkLegalMove(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1);
                    MarkLegalMove(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2);
                    MarkLegalMove(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2);

                    break;

                case "King":

                    for (int i = -1; i < 2; i++)
                    {
                        MarkLegalMove(currentCell.RowNumber, (i + currentCell.ColumnNumber));
                        MarkLegalMove((i + currentCell.RowNumber), currentCell.ColumnNumber);
                        MarkLegalMove((i + currentCell.RowNumber), (i + currentCell.ColumnNumber));
                        MarkLegalMove((i * 1 + currentCell.RowNumber), (i * -1 + currentCell.ColumnNumber));
                    }
                    
                    break;
                case "Rook":
                    for (int i = (Size * -1); i < Size; i++)
                    {
                        MarkLegalMove(currentCell.RowNumber,(i+currentCell.ColumnNumber));
                        MarkLegalMove((i + currentCell.RowNumber), currentCell.ColumnNumber);
                    }
                    break;

                case "Bishop":
                    for (int i = (Size*-1); i < Size; i++)
                    {
                        MarkLegalMove((i + currentCell.RowNumber), (i + currentCell.ColumnNumber));
                        MarkLegalMove((i*1 + currentCell.RowNumber), (i * -1 + currentCell.ColumnNumber));
                    }

                    break;
                case "Queen":

                    for (int i = (Size * -1); i < Size; i++)
                    {
                        MarkLegalMove((i + currentCell.RowNumber), (i + currentCell.ColumnNumber));
                        MarkLegalMove((i * 1 + currentCell.RowNumber), (i * -1 + currentCell.ColumnNumber));

                        MarkLegalMove(currentCell.RowNumber, (i + currentCell.ColumnNumber));
                        MarkLegalMove((i + currentCell.RowNumber), currentCell.ColumnNumber);

                    }

                    break;


                
                case "Default":
                    break;
            }


        }


        


    }
}
