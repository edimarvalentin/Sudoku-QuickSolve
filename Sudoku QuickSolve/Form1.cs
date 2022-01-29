/*
 * Written by Edimar Valentín Kery <edimar.valentin@upr.edu>
 * 
 * The porpuse of this project was to have a self made Sudoku solver app in my computer for whenever 
 * I want to see the answer of a newspaper sudoku puzzle I might be solving.
 * 
 * Data structures like multi dymensional arrays and hashsets were put into practice.
 * Recursion and backtracking were used to make the suduko solver feature
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_QuickSolve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     /*
     * ValidClick - Event Function
     * 
     * Validates if the grid has valid values according to Sudoku rules
     * Outputs if it's valid or not
     * 
    */
        public void ValidClick(object sender, EventArgs e)
        {
            if (validateBtn.Text != "Validate")
            {
                validateBtn.Text = "Validate";
            }
            else
            {
                if (isValid(getGrid()))
                {
                    validateBtn.Text = "Valid!";
                }
                else
                {
                    validateBtn.Text = "Invalid!";
                }
            }
        }
       /*
       * SolveClick - Event Function
       * 
       * Solves the grid and outputs it if was sucessful or not
       * 
      */
        public void SolveClick(object sender, EventArgs e)
        {
            if (solveBtn.Text == "Solve")
            {
                if (isValid(getGrid()))
                {
                    if (solveSudoku(getGrid()))
                    {
                        solveBtn.Text = "Solved!";
                    }
                    else
                    {
                        solveBtn.Text = "Can't solve";
                    }
                }
                else
                {
                    solveBtn.Text = "Can't solve";
                }
            }
            else
            {
                solveBtn.Text = "Solve";
            }
        }
        /*
         * Clearlick - Event Function
         * 
         * Clears and restarts the grid for more inputs by the user
         * 
        */
        public void ClearClick(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[,] grid = getGrid();
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    grid[i, j].Clear();
                    grid[i, j].ReadOnly = false;
                    grid[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        //isNumberInRow returns true if a number exist in the specified row
        private bool isNumberInRow(System.Windows.Forms.TextBox[,] grid, int number, int row)
        {
            for(int i = 0; i < 9; i++)
            {
                if(grid[row, i].Text.Length >= 1 && int.Parse(grid[row, i].Text.ToString()) == number)
                {
                    return true;
                }
            }
            return false;
        }
        //isNumberInColumn returns true if a number exist in the specified column
        private bool isNumberInColumn(System.Windows.Forms.TextBox[,] grid, int number, int column)
        {
            for (int i = 0; i < 9; i++)
            {
                if (grid[i, column].Text.Length >= 1 && int.Parse(grid[i, column].Text.ToString()) == number)
                {
                    return true;
                }
            }
            return false;
        }
        //isNumberInSubGrid return true if a number exist in it's local 3 * 3 sub grid.
        private bool isNumberInSubGrid(System.Windows.Forms.TextBox[,] grid, int number, int row, int column)
        {
            int localRow = row - row % 3;
            int localColumn = column - column % 3;

            for(int i = localRow; i < localRow + 3; i++)
            {
                for(int j = localColumn; j < localColumn + 3; j++)
                {
                    if(grid[i, j].Text.Length >= 1 && int.Parse(grid[i, j].Text.ToString()) == number)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //isValidPlacement is a helper method that returns true if a number complies with Sudoku rules in a given coordinate
        private bool isValidPlacement(System.Windows.Forms.TextBox[,] grid, int number, int row, int column)
        {
            return !isNumberInRow(grid, number, row) && !isNumberInColumn(grid, number, column) && !isNumberInSubGrid(grid, number, row, column);
        }

        //solveSudoku will recursevily solve the empty or wrong rows in the puzzle
        private bool solveSudoku(System.Windows.Forms.TextBox[,] grid)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if (grid[row, column].Text.Length == 0)
                        { 
                        for (int entry = 1; entry < 10; entry++)
                        {
                            if (isValidPlacement(grid, entry, row, column))
                            {
                                grid[row, column].Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                grid[row, column].Text = entry.ToString();
                                grid[row, column].ReadOnly = true;

                                if (solveSudoku(grid))
                                {
                                    return true;
                                }
                                else
                                {
                                    grid[row, column].Text = "";
                                }

                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }


        //isValid will return true if a grid complies with Sudoku rules
        private bool isValid(System.Windows.Forms.TextBox[,] grid)
        {
            HashSet<string> visited = new HashSet<string>();

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if (grid[i, j].Text.Length == 1)
                    {
                        char entry = char.Parse(grid[i, j].Text);
                        if(Char.IsDigit(entry) && entry > '0')
                        {
                            if(!(visited.Add(entry + " found in row " + j) && visited.Add(entry + " found in column " + i) && visited.Add(grid[i, j] + " in box " + j / 3 + "-" + i / 3))){
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }else if(grid[i, j].Text.Length == 0)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
