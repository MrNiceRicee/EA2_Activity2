using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    public class Program
    {
        public static Board myBoard = new Board(8);

        static void Main(string[] args)
        {
            //Show the empty chess board

            //get the location of the chess piece

            // calculate and mark the cells where legal moves are possible

            //show the chess board. Use . for an empty square, X for the piece location and + for a possible legal move
            //wait for another return key to end the program

            do
            {
                Console.Clear();
                Console.WriteLine("Start program: Yes or No");
                String answer = Console.ReadLine();
                if ((answer.Equals("yes",StringComparison.InvariantCultureIgnoreCase)) || (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)))
                {
                    myBoard = new Board(8);
                    Console.WriteLine(printGrid(myBoard));
                    Cell myLocation = setCurrentCell();
                    myBoard.MarkNextLegalMoves(myLocation, getMode());
                    Console.WriteLine(printGrid(myBoard));
                    Console.ReadLine();
                }
                else if ((answer.Equals("no", StringComparison.InvariantCultureIgnoreCase)) || (answer.Equals("n", StringComparison.InvariantCultureIgnoreCase)))
                {
                    break;
                }
                else
                {
                    //Console.WriteLine("Please answer.");
                }

            } while (true);            
        }



        public static String printGrid(Board myBoard)
        {
            String r = "";
            for (int x = 0; x < myBoard.Size; x++)
            {
                r += "| "+x+" ";
            }
            for (int c = 0; c < myBoard.Size; c++)
            {
                r += "\n";
                for (int ro  = 0; ro < myBoard.Size; ro++)
                {
                    r += "----";
                }
                r += "\n";
                for (int ro = 0; ro < myBoard.Size; ro++)
                {
                    if (myBoard.theGrid[ro, c].CurrentlyOccupied)
                    {
                        r+=("| X ");
                    }
                    else if (myBoard.theGrid[ro, c].LegalNextMove)
                    {
                        r+=("| + ");
                    }
                    else
                    {
                        r+=("|   ");
                    }
                }
                r += "| "+c+"";
            }
            r += "\n";
            for (int ro = 0; ro < myBoard.Size; ro++)
            {
                r += "----";
            }
            return r;
        }

        public static String getMode()
        {
            do
            {
                Console.WriteLine("Please pick a chess piece");
                Console.WriteLine("0 - Knight\n"+
                                  "1 - King\n"+
                                  "2 - Rook\n"+
                                  "3 - Bishop\n"+
                                  "4 - Queen");
                String picked = Console.ReadLine();
                if(int.TryParse(picked,out int p))
                {
                    if (p==0)
                    {
                        return "Knight";
                    }else if (p == 1)
                    {
                        return "King";
                    }
                    else if (p == 2)
                    {
                        return "Rook";
                    }
                    else if (p == 3)
                    {
                        return "Bishop";
                    }
                    else if (p == 4)
                    {
                        return "Queen";
                    }
                }
                else{
                    if (picked.Equals("Knight",StringComparison.InvariantCultureIgnoreCase))
                    {
                        return "Knight";
                    }else if (picked.Equals("King", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return "King";
                    }
                    else if (picked.Equals("Rook", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return "Rook";
                    }
                    else if (picked.Equals("Bishop", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return "Bishop";
                    }
                    else if (picked.Equals("Queen", StringComparison.InvariantCultureIgnoreCase))
                    {
                        return "Queen";
                    }
                }
            } while (true);
        }

        public static int getNumber()
        {
            do
            {
                if (int.TryParse(Console.ReadLine(),out int r))
                {
                    return r;
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            } while (true);
        }

        public static Cell setCurrentCell()
        {
            Console.Out.WriteLine("Enter your current row number ");
            int currentRow = getNumber();
            Console.Out.WriteLine("Enter your current column number ");
            int currentCol = getNumber();

            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentCol];
        }
    }
}
