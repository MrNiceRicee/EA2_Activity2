using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessBoardModel;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        static public Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size,myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            int buttonSize = pn_Grid.Width / myBoard.Size;
            pn_Grid.Height = pn_Grid.Width;
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].Click += Grid_Button_Click;
                    pn_Grid.Controls.Add(btnGrid[r, c]);
                    btnGrid[r, c].Location = new Point(buttonSize*r,buttonSize*c); //positioneed in xy based on r and c intervals by the size

                    btnGrid[r, c].Text = r + "," + c;

                    btnGrid[r, c].Tag = r + "," + c;
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            string[] strArr = (sender as Button).Tag.ToString().Split(',');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);
            if (cb_ListPieces.SelectedIndex > -1) {


                Cell currentCell = myBoard.theGrid[r, c];
                myBoard.MarkNextLegalMoves(currentCell, cb_ListPieces.SelectedItem.ToString());

                for (int i = 0; i < myBoard.Size; i++)
                {
                    for (int j = 0; j < myBoard.Size; j++)
                    {
                        btnGrid[i, j].BackColor = default(Color);
                    }
                }
                //set the background color of the clicked button to something
                (sender as Button).BackColor = Color.Cornsilk;
                updateButtonLabels();
            }
            else
            {
                btnGrid[r, c].Text = "Select Mode";
            }
        }

        public void updateButtonLabels()
        {
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c].Text = "";        //reset everything

                    if (myBoard.theGrid[r, c].LegalNextMove)
                    {
                        btnGrid[r, c].Text = "Legal";
                    }
                    if (myBoard.theGrid[r, c].CurrentlyOccupied)
                    {
                        btnGrid[r, c].Text = cb_ListPieces.SelectedItem.ToString();
                    }

                }
            }
        }

        private void Grid_SizeUpdate(object sender, EventArgs e)
        {
            this.Width = this.Height;

            pn_Grid.Height = this.Width-150;
            pn_Grid.Width = pn_Grid.Height;

            this.cb_ListPieces.Location = new Point(pn_Grid.Width+pn_Grid.Location.X,pn_Grid.Location.Y);
            this.lb_hint2.Location = new Point(10,pn_Grid.Location.Y+pn_Grid.Height);

            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    int ns = pn_Grid.Width / myBoard.Size;
                    btnGrid[r, c].Width = ns;
                    btnGrid[r, c].Height = ns;
                    btnGrid[r, c].Location = new Point(ns * r, ns * c);
                    btnGrid[r, c].Font = new Font(FontFamily.GenericSansSerif, ns / 6);
                }
            }
            Console.WriteLine(this.cb_ListPieces.Location.ToString());

        }
    }
}
