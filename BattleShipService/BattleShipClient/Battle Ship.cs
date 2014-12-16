using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    public partial class Battle_Ship : Form
    {
        private int type;
        private List<Cell> cellList = new List<Cell>();
        Cell cell1;
        Point a1 = new Point(0, 0);
        Graphics grapgics;
        int drawRow = 0;
        int drawCol = 0;
        public Battle_Ship()
        {
            InitializeComponent();
            this.type = 0;
            this.cell1 = new Cell(a1, this.imageList1.Images[0]);
        }

        private void PaintCell(Cell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 70, 35);
            gr.DrawImage(a.Image, destrec);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            grapgics = e.Graphics;
            Rectangle rect = this.Bounds;
            int col = rect.Width;
            int row = rect.Height;
            this.drawCol = 0;
            this.drawRow = 0;
            int x = 35;

            Pen p = new Pen(Brushes.Green);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            for (int i = 0; i <= row; i++)
            {
                e.Graphics.DrawLine(p, 5, drawCol, rect.Width, drawCol);
                drawCol += x;
            }
            for (int j = 0; j <= col; j++)
            {
                e.Graphics.DrawLine(p, drawRow, 5, drawRow, rect.Height);
                drawRow += x;
            }
            this.PaintCell(cell1, grapgics);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.Bounds;
            int col = rect.Width;
            int row = rect.Height;
            this.drawCol = 0;
            this.drawRow = 0;
            int x = 35;

            Pen p = new Pen(Brushes.Green);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            for (int i = 0; i <= row; i++)
            {
                e.Graphics.DrawLine(p, 5, drawCol, rect.Width, drawCol);
                drawCol += x;
            }
            for (int j = 0; j <= col; j++)
            {
                e.Graphics.DrawLine(p, drawRow, 5, drawRow, rect.Height);
                drawRow += x;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.type = 1;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            Point a = new Point(-1, -1);
            if (e.X > 0 && e.X <= 70 && e.Y > 0 && e.Y <= 35)
            {
                if (this.type == 1)
                {
                    Cell temp = new Cell(a, this.imageList1.Images[1]);
                    cell1 = temp;
                }
            }
            this.panel2.Refresh();
        }

    }
}
