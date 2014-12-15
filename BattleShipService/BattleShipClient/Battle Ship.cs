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
        public Battle_Ship()
        {
            InitializeComponent();
        }

        private void btnOnlonePlayers_Click(object sender, EventArgs e)
        {
            Form OnlinePlayers = new OnlinePlayers();
            OnlinePlayers.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
