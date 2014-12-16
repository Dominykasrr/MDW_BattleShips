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

namespace BattleShipClient
{
    public partial class Form1 : Form, ServiceReference1.IPortalCallback
    {
        ServiceReference1.PortalClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceReference1.PortalClient(new InstanceContext(this));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (proxy.Login(tbName.Text, tbPasswd.Text))
            { 
                this.label1.Text = tbName.Text;
                Battle_Ship form = new Battle_Ship();
                form.Show();
            }
        }

        public void playerLoggedIn(string name)
        {
            MessageBox.Show("Player logged in");
            label1.Text = name +" logged in";
        }
    }
}
