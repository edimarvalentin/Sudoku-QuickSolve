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
        private void InitializeComponent()
        {
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
            this.validateBtn.AutoSize = true;
            this.validateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateBtn.Location = new System.Drawing.Point(85, 250);
            this.Controls.Add(this.validateBtn);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(50, 10);
            this.validateBtn.Text = "Validate";
            this.validateBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.validateBtn.Click += new System.EventHandler(isValidClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 430);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

        }

        #endregion

        private System.Windows.Forms.TextBox[,] grid = new System.Windows.Forms.TextBox[9, 9];
        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Button validateBtn;


        public System.Windows.Forms.TextBox[,] getGrid()
        {
            return grid;
        }

    }



    
}

