using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Cell
    {

        //following the guide for the Chess pieces.
        //row and col  are the cell's location on the grid.

        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }


        //Checks if the chess piece on thee cell
        public bool CurrentlyOccupied { get; set; }

        //Is the square a legal move for chess piece on the board
        public bool LegalNextMove { get; set; }


        public Cell(int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
        }



    }
}
