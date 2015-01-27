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
    public partial class Battle_Ship : Form, ServiceReference1.IChatCallback, ServiceReference1.IBattleCallback
    {
        string Playername;
        string Opponent;
        ServiceReference1.ChatClient proxy2;
        ServiceReference1.BattleClient proxy3;

        private int cellWidth = 35;
        private int cellHeight = 35;
        private int shipLengthToAdd;
        private Cell[,] cellArray = new Cell[10, 10];
        private Cell[,] cellArrayOpponent = new Cell[10, 10];
        private List<Ship> Shiplist = new List<Ship>();
        private Point a1 = new Point(0, 0);
        private Point b1 = new Point(0, 0);
        private Graphics graphics;
        private int drawRow = 0;
        private int drawCol = 0;
        private int[] shipsLeft = { 4, 3, 2, 1 };

        public Battle_Ship(Game game, string username, string opponent)
        {
            InitializeComponent();
            this.shipLengthToAdd = 0;

            proxy2 = new ServiceReference1.ChatClient(new InstanceContext(this));
            proxy3 = new ServiceReference1.BattleClient(new InstanceContext(this));

            this.lbName.Text = username + " !";
            this.Playername = username;
            this.Opponent = opponent;
            proxy2.StartChatSession(Playername);
            proxy3.StartGameSession(Playername);
            this.createCell();
            this.createCell2();

            rbHorizontal.Checked = true; // initialize radio buttons;
        }

        private void createCell()
        {
            a1.Y = 0;
            for (int i = 0; i < 10; i++)
            {
                a1.X = 0;
                for (int j = 0; j < 10; j++)
                {
                    Cell temp = new Cell(a1, true);
                    a1.X += cellWidth;
                    this.cellArray[j, i] = temp;
                }
                a1.Y += cellHeight;
            }
        }

        private void createCell2()
        {
            for (int i = 0; i < 10; i++)
            {
                b1.X = 0;
                for (int j = 0; j < 9; j++)
                {
                    Cell temp = new Cell(b1, false);
                    b1.X += cellWidth;
                    this.cellArrayOpponent[j, i] = temp;
                }
                b1.Y += cellHeight;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            Rectangle rect = this.Bounds;
            int col = rect.Width;
            int row = rect.Height;
            this.drawCol = 0;
            this.drawRow = 0;
            int x = cellWidth;

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
            foreach (Cell c in cellArray)
            {
                if (!c.isEmpty)
                {
                    e.Graphics.FillRectangle(Brushes.Black, c.P.X, c.P.Y, 35, 35);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
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

        public Ship GetShipByCell(int cellX, int cellY)
        {
            foreach (Ship s in Shiplist)
            {
                if (s.isHorizontal)
                {
                    if (cellX >= s.x && cellX <= s.x + s.size && cellY == s.y)
                    {
                        return s;
                    }
                }
                else
                {
                    if (cellX == s.x && cellY <= s.x + s.size && cellY >= s.y)
                    {
                        return s;
                    }
                }
            }
            return null;
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            bool checker = true;
            int cellX, cellY;
            cellX = e.X / cellWidth;
            cellY = e.Y / cellHeight;

            if (cellArray[cellX, cellY].isEmpty && shipLengthToAdd > 0)
            {
                if (shipsLeft[shipLengthToAdd - 1] > 0)
                {
                    try
                    {
                        int xTilesToCheck = 0;
                        int yTilesToCheck = 0;
                        if (rbHorizontal.Checked)
                        {
                            yTilesToCheck = 3;
                            xTilesToCheck = shipLengthToAdd + 2;
                        }
                        else
                        {
                            yTilesToCheck = shipLengthToAdd + 2;
                            xTilesToCheck = 3;
                        }
                        for (int yy = 0; yy < yTilesToCheck; yy++) //check if surrounding tiles are empty
                        {
                            for (int xx = 0; xx < xTilesToCheck; xx++)
                            {
                                if (!cellArray[Math.Max(Math.Min((cellX - 1 + xx), 9), 0), Math.Max(Math.Min((cellY - 1 + yy), 9), 0)].isEmpty)
                                {
                                    checker = false;
                                }
                            }
                        }
                        if (checker)
                        {
                            if (rbHorizontal.Checked)
                            {
                                for (int i = shipLengthToAdd - 1; i >= 0; i--)
                                {
                                    cellArray[cellX + i, cellY].isEmpty = false;
                                }
                            }
                            else
                            {
                                for (int i = shipLengthToAdd - 1; i >= 0; i--)
                                {
                                    cellArray[cellX, cellY + i].isEmpty = false;
                                }
                            }
                            Shiplist.Add(new Ship(cellX, cellY, rbHorizontal.Checked, shipLengthToAdd));
                            shipsLeft[shipLengthToAdd - 1]--;
                            updateShipCountIndicators();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        MessageBox.Show("Ship is too long to add here");
                        return;
                    }
                }
            }
            this.panel2.Refresh();
        }
        private void updateShipCountIndicators()
        {
            lbShip1.Text = shipsLeft[0] + "x";
            lbShip2.Text = shipsLeft[1] + "x";
            lbShip3.Text = shipsLeft[2] + "x";
            lbShip4.Text = shipsLeft[3] + "x";
        }
        private void drawShipsFromList(List<Ship> shipsToDraw)
        {
            foreach (Ship s in shipsToDraw)
            {
                if (s.isHorizontal)
                {
                    for (int i = s.size - 1; i >= 0; i--)
                    {
                        cellArray[s.x + i, s.y].isEmpty = false;
                    }
                }
                else
                {
                    for (int i = s.size - 1; i >= 0; i--)
                    {
                        cellArray[s.x, s.y + i].isEmpty = false;
                    }
                }
            }
            panel2.Refresh();
        }
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {


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
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.shipLengthToAdd = 1;
            lbSelectedSize.Text = shipLengthToAdd.ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.shipLengthToAdd = 2;
            lbSelectedSize.Text = shipLengthToAdd.ToString();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.shipLengthToAdd = 3;
            lbSelectedSize.Text = shipLengthToAdd.ToString();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.shipLengthToAdd = 4;
            lbSelectedSize.Text = shipLengthToAdd.ToString();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            proxy3.ConfirmReady(Playername);
        }

        public void PlayerReady()
        {
            this.lb_DisplayMessages.ScrollAlwaysVisible = true;
            this.lb_DisplayMessages.Items.Add(Playername + " is ready");
        }

        public void NotifyShot(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
