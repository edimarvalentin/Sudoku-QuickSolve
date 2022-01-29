namespace Sudoku_QuickSolve
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 


        private void InitializeComponent()
        {

            // Creates the Sudoku grid
            int x = 40;
            int y = 50;
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    grid[i, j] = new System.Windows.Forms.TextBox();
                    grid[i, j].Name = "textBox " + i + "U+002C" + j;
                    grid[i, j].Size = new System.Drawing.Size(20, 20);
                    grid[i, j].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    grid[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.Controls.Add(grid[i, j]);

                    if(j % 3 == 0)
                    {
                        x += 5;
                    }

                    grid[i, j].Location = new System.Drawing.Point(x, y);

                    x += 20;
                }

                x = 40;

                if (i == 2 || i == 5)
                {
                    y += 25;
                }
                else
                {
                    y += 20;
                }
               
            }
            
            this.title = new System.Windows.Forms.Label();
            this.validateBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(257, 29);
            this.title.TabIndex = 81;
            this.title.Text = "Sudoku Quick Solver";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // validateBtn
            //
            this.validateBtn.AutoSize = false;
            this.validateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateBtn.Location = new System.Drawing.Point(65, 250);
            this.Controls.Add(this.validateBtn);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(160, 40);
            this.validateBtn.Text = "Validate";
            this.validateBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.validateBtn.Click += new System.EventHandler(ValidClick);
            //
            // solveBtn
            //
            this.solveBtn.AutoSize = false;
            this.solveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveBtn.Location = new System.Drawing.Point(65, 290);
            this.Controls.Add(this.solveBtn);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(160, 40);
            this.solveBtn.Text = "Solve";
            this.solveBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.solveBtn.Click += new System.EventHandler(SolveClick);
            //
            // clearBtn
            //
            this.clearBtn.AutoSize = false;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(65, 330);
            this.Controls.Add(this.clearBtn);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(160, 40);
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clearBtn.Click += new System.EventHandler(ClearClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 430);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Sudoku Quick Solver";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

        }

        #endregion

        private System.Windows.Forms.TextBox[,] grid = new System.Windows.Forms.TextBox[9, 9];
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Button validateBtn;
        public System.Windows.Forms.Button solveBtn;
        public System.Windows.Forms.Button clearBtn;



        public System.Windows.Forms.TextBox[,] getGrid()
        {
            return grid;
        }

    }



    
}

