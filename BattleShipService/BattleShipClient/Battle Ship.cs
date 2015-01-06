using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using BattleShipService;

namespace BattleShipClient
{
    public partial class Battle_Ship : Form, ServiceReference1.IChatCallback
    {
        string Playername;
        string Opponent;
        ServiceReference1.ChatClient proxy2;

        private int type;
        private List<Cell> cellList = new List<Cell>();
        private List<Cell> cellList2 = new List<Cell>();
        private List<Ship> Shiplist = new List<Ship>();
        Point a1 = new Point(0, 0);
        Point b1 = new Point(0, 0);
        Graphics grapgics;
        int drawRow = 0;
        int drawCol = 0;
        Ship ship1;
        public Battle_Ship(Game game, string username, string opponent)
        {
            InitializeComponent();
            this.type = 0;

            proxy2 = new ServiceReference1.ChatClient(new InstanceContext(this));

            this.lbName.Text = username + " !";
            this.Playername = username;
            this.Opponent = opponent;
            proxy2.StartChatSession(Playername);
        }

        private void createCell()
        {
            for (int i = 0; i < 10; i++)
            {
                a1.X = 0;
                for (int j = 0; j < 9; j++)
                {
                    Cell temp = new Cell(a1, this.imageList1.Images[0],0);
                    a1.X += 35;
                    this.cellList.Add(temp);
                }
                a1.Y += 35;
            }
        }

        private void createCell2()
        {
            for (int i = 0; i < 10; i++)
            {
                b1.X = 0;
                for (int j = 0; j < 9; j++)
                {
                    Cell temp = new Cell(b1, this.imageList1.Images[0], 0);
                    b1.X += 35;
                    this.cellList2.Add(temp);
                }
                b1.Y += 35;
            }
        }

        private void PaintCell(Cell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 70, 35);
            gr.DrawImage(a.Image, destrec);
        }

        private void PaintCell2(Cell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 105, 35);
            gr.DrawImage(a.Image, destrec);
        }

        private void PaintCell3(Cell a, Graphics gr)
        {
            Rectangle destrec = new Rectangle(a.P.X, a.P.Y, 35, 70);
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

            this.createCell();
            foreach (Cell item in cellList)
            {
                if (item.type == 1)
                {
                    this.PaintCell(item, grapgics);
                }
                else if (item.type == 2)
                {
                    this.PaintCell2(item, grapgics);
                }
                else if (item.type == 3)
                {
                    this.PaintCell3(item, grapgics);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

            this.createCell2();

            this.ship1 = new Ship(cellList2[1], cellList2[2], cellList2[3]);
            this.ship1.holdingCell = 3;
            cellList2[1].ship = ship1;
            cellList2[2].ship = ship1;
            cellList2[3].ship = ship1;
            Shiplist.Add(ship1);

            foreach (Cell item in cellList2)
            {
                Rectangle destrec = new Rectangle(item.P.X, item.P.Y, 35, 35);
                this.grapgics.DrawImage(item.Image, destrec);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.type = 1;
        }

        private bool GetNextEmptyCell(Cell cell)
        {
            foreach (Cell item in cellList)
            {
                if (item.P.X == cell.P.X + 35 && item.P.Y == cell.P.Y && item.empty == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GetNextEmptyCell2(Cell cell)
        {
            foreach (Cell item in cellList)
            {
                if (item.P.X == cell.P.X + 70 && item.P.Y == cell.P.Y && item.empty == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool GetNextBottomEmptyCell(Cell cell)
        {
            foreach (Cell item in cellList)
            {
                for (int i = 0; i < cellList.Count; i++)
                {
                    if (cellList[i] == cell)
                    {
                        if (cellList[i + 10].empty == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Point a = new Point(-1, -1);
            if (this.type == 1)
            {
                foreach (Cell item in cellList)
                {
                    if (e.X > item.P.X && e.X <= item.P.X + 35 && e.Y > item.P.Y && e.Y <= item.P.Y + 35)
                    {
                        for (int i = 0; i < cellList.Count; i++)
                        {
                            if (cellList[i].getCell() == item)
                            {
                                if (GetNextEmptyCell(item) == true)
                                {
                                    cellList[i].empty = 1;
                                    cellList[i].type = 1;
                                    cellList[i + 1].empty = 1;
                                    cellList[i].Image = this.imageList2.Images[1];

                                    Ship temp = new Ship(cellList[i], cellList[i + 1]);
                                    Shiplist.Add(temp);
                                    cellList[i].ship = temp;
                                    cellList[i + 1].ship = temp;
                                }
                            }

                        }
                    }
                }
            }

            if (this.type == 2)
            {
                foreach (Cell item in cellList)
                {
                    if (e.X > item.P.X && e.X <= item.P.X + 35 && e.Y > item.P.Y && e.Y <= item.P.Y + 35)
                    {
                        for (int i = 0; i < cellList.Count; i++)
                        {
                            if (cellList[i].getCell() == item)
                            {
                                if (GetNextEmptyCell(item) == true && GetNextEmptyCell2(item) == true)
                                {
                                    cellList[i].empty = 1;
                                    cellList[i + 1].empty = 1;
                                    cellList[i + 2].empty = 1;
                                    cellList[i].type = 2;
                                    cellList[i].Image = this.imageList2.Images[1];
                                }
                            }

                        }
                    }
                }
            }

            if (this.type == 3)
            {
                foreach (Cell item in cellList)
                {
                    if (e.X > item.P.X && e.X <= item.P.X + 35 && e.Y > item.P.Y && e.Y <= item.P.Y + 35)
                    {
                        for (int i = 0; i < cellList.Count; i++)
                        {
                            if (cellList[i].getCell() == item)
                            {
                                if (GetNextBottomEmptyCell(item))
                                {
                                    cellList[i].empty = 1;
                                    cellList[i + 10].empty = 1;
                                    cellList[i].type = 3;
                                    cellList[i].Image = this.imageList2.Images[2];
                                }
                            }

                        }
                    }
                }
            }

            this.panel2.Refresh();
        }


        public void UpdateChatMessages(string message, string playername)
        {
            this.lb_DisplayMessages.ScrollAlwaysVisible = true;
            this.lb_DisplayMessages.Items.Add(playername + ": " + message);
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if (this.tbWriteChat.Text != "")
            {
                string msg = this.tbWriteChat.Text;
                this.tbWriteChat.Text = string.Empty;
                proxy2.PostChatMessage(msg, Playername, Opponent);
                this.lb_DisplayMessages.Items.Add(Playername + " : " + msg);
            }
            else
            {
                MessageBox.Show("You have to type the message first.");
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            this.type = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.type = 3;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Point a = new Point(-1, -1);

            foreach (Cell item in cellList2)
            {
                if (e.X > item.P.X && e.X <= item.P.X + 35 && e.Y > item.P.Y && e.Y <= item.P.Y + 35)
                {
                    for (int i = 0; i < cellList2.Count; i++)
                    {
                        if (cellList2[i].getCell() == item)
                        {
                            if (cellList2[i].ship != null)
                            {
                                cellList2[i].empty = 0;
                                for (int j = 0; j < Shiplist.Count; i++)
                                {
                                    if (Shiplist[j].holdingCell == cellList2[i].ship.holdingCell)
                                    {
                                        Shiplist[j].celllist.Remove(cellList2[i]);
                                        cellList2[i].ship.holdingCell -= 1;
                                        cellList2[i].Image = imageList2.Images[3];
                                        if (Shiplist[j].celllist.Count < 1)
                                        {
                                            MessageBox.Show("HIT!");
                                            this.panel3.Refresh();
                                            return;
                                        }
                                        this.panel3.Refresh();
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                cellList2[i].Image = imageList2.Images[4];
                            }
                        }

                    }
                }
            }
            this.panel3.Refresh();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.type = 2;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.type = 3;
        }

    }
}
