using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleGames.YellowRed
{
    public partial class frmMain : Form
    {
        const int MAX = 9;
        const int dfSize = 40;
        const int dfMargin = 6;
        const int dfForm = 10;

        static Cell[,] pics = new Cell[MAX, MAX];
        static int total = 0;

        public frmMain()
        {
            InitializeComponent();
            
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
            		var pic = create(i, j);
            		pics[i, j] = pic;
                    this.pnlCell.Controls.Add(pic);
                }
            }
            
            var width = MAX * (dfSize + dfMargin) + dfMargin + pnlControl.Width + dfForm;
            var height = MAX * (dfSize + dfMargin) + dfMargin + dfForm * 3;
            this.Size = new Size(width, height);
            
            reset();
        }

        private Cell create(int i, int j)
        {
            var pic = new Cell(i, j);
            pic.Size = new System.Drawing.Size(dfSize, dfSize);
            pic.Location = new System.Drawing.Point(i * (dfSize + dfMargin) + dfMargin, j * (dfSize + dfMargin) + dfMargin);
            pic.Click += new System.EventHandler(playEvent);
            return pic;
        }

        private void reset()
        {
            for (int i = 0; i < MAX; i++)
                for (int j = 0; j < MAX; j++)
                {
                    pics[i, j].BackColor = Color.Yellow;
                }
            total = 0;
            switchColor(MAX / 2, MAX / 2);
            
            lblScore.Text = total.ToString();
        }

        private void switchColor(int i, int j)
        {
            if (i > -1 && j > -1 && i < MAX && j < MAX)
            {
                Cell box = pics[i, j];
                if (box.BackColor == Color.Yellow)
                {
                    box.BackColor = Color.Red;
                    total++;
                }
                else
                {
                    box.BackColor = Color.Yellow;
                    total--;
                }
            }
        }

        private void playEvent(object sender, EventArgs e)
        {
            var box = (Cell)sender;
            int i = box.X;
            int j = box.Y;

            switchColor(i, j);
            switchColor(i - 1, j);
            switchColor(i + 1, j);
            switchColor(i, j - 1);
            switchColor(i, j + 1);

            lblScore.Text = total.ToString();
            if (total == MAX * MAX)
            {
                MessageBox.Show("You won !");
                reset();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
