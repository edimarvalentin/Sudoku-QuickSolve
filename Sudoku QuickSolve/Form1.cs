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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void isValidClick(object sender, EventArgs e)
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
