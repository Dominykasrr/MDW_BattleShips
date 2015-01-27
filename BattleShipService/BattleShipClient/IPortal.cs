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
    public partial class IPortal : Form, ServiceReference1.IPortalCallback
    {
        ServiceReference1.PortalClient proxy;
        public List<BattleShipService.Player> onlinePlayers;
        public string opponent;

        public string myUsername;

        public IPortal()
        {
            InitializeComponent();
            proxy = new ServiceReference1.PortalClient(new InstanceContext(this));

            onlinePlayers = new List<BattleShipService.Player>();

            this.gbSignUp.Visible = false;
            this.gbSignUp.Location = new Point(30, 46);

            this.gbPassReset.Visible = false;
            this.gbPassReset.Location = new Point(30, 46);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            string name = this.tbName.Text;
            myUsername = name;
            string passwd = this.tbPasswd.Text;
            if (name == "")
            {
                MessageBox.Show("Please input your username!");
                this.tbName.Focus();
            }
            else if (passwd == "")
            {
                MessageBox.Show("Please input the password!");
                this.tbPasswd.Focus();
            }
            else
            {
                bool result = proxy.Login(0, name, passwd);
                if (result)
                {
                    this.lbName.Text = name + " !";
                    MessageBox.Show("You are successfully logged in.");
                    proxy.Update();
                }
                else
                {
                    MessageBox.Show("Login Failed, check your input again");
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            this.gbPassReset.Visible = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.gbSignUp.Visible = true;
        }

        private void btnSignUpCancel_Click(object sender, EventArgs e)
        {
            this.gbSignUp.Visible = false;
        }

        private void btnPassResetCancel_Click(object sender, EventArgs e)
        {
            this.gbPassReset.Visible = false;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            int id = 0;
            string nm = this.tbSignUpName.Text;
            string ps = this.tbSignUpPass.Text;
            if (nm == "")
            {
                MessageBox.Show("Please input your username!");
                this.tbSignUpName.Focus();
            }
            else if (ps == "")
            {
                MessageBox.Show("Please input the password!");
                this.tbSignUpPass.Focus();
            }
            else
            {
                bool result = proxy.UserRegister(id, nm, ps);
                if (result)
                {
                    MessageBox.Show("You are successfully Registered.\nFollowing are your Login Detials:\nUsername: " + nm + "\nPassword: " + ps + "", "Registration Detials", MessageBoxButtons.OK);
                    this.gbSignUp.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username is already exists.");
                }
            }
        }
        
        private void btnGetNewPass_Click(object sender, EventArgs e)
        {
            string name = this.tbPassResetName.Text;
            string passwd = this.tbPassResetPass.Text;

            if (name == "")
            {
                MessageBox.Show("Please input your username!");
                this.tbPassResetName.Focus();
            }
            else if (passwd == "")
            {
                MessageBox.Show("Please input the password!");
                this.tbPassResetPass.Focus();
            }
            else
            {
                bool result = proxy.ResetPassword(name, passwd);
                if (result)
                {
                    MessageBox.Show("Your password has been successfully changed.\nYour new password is :" + passwd + "", "Password Recovery Detials", MessageBoxButtons.OK);
                    this.gbPassReset.Visible = false;
                }
                else
                {
                    MessageBox.Show("Password reset is Failed.");
                }
            }
        }
 
        private void btnInvite_Click(object sender, EventArgs e)
        {
            if (this.lbOnlinePlayers.SelectedItem != null)
            {
                if (this.lbOnlinePlayers.SelectedItem.ToString() != myUsername)
                {
                    string opponentPlayer = this.lbOnlinePlayers.SelectedItem.ToString();
                    this.opponent = opponentPlayer;
                    proxy.InvitePlayer(opponentPlayer, myUsername);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You cannot invite yourself!");
                }
            }
            else
            {
                MessageBox.Show("You have to select your opponent Player.");
            }
        }

        /// <summary>
        /// This "NotifyChallenge" is the callback methods, 
        /// Which will call when the player invite other player to play the game. 
        /// If the player click on "YES" than, the method will call the "AcceptInvitation" mwthods,
        /// and open the Battle field. And if palyer click on "NO" than no thing will happen.
        /// </summary>
        /// <param name="Name"></param>
        public void NotifyChallenge(string Name)
        {
            DialogResult inviteAccept = MessageBox.Show(Name + " invited you to play a game.\nDo you want to play?", "Accept/Decline",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            string opponent = Name;

            //Player accept to play.
            if (inviteAccept == DialogResult.Yes)
            {
                this.opponent = opponent;
                proxy.AcceptInvitation(myUsername, opponent);
            }
        }

        /// <summary>
        /// This method is just to show the main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Battle_Ship_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        
        /// <summary>
        /// When the player accept the challange from other player, this NotifyResponce,
        /// callback will close the the lobby form and open the new main battle field, where two player can play the game.
        /// </summary>
        /// <param name="game"></param>
        public void NotifyResponce(BattleShipService.Game game)
        {
            Battle_Ship main = new Battle_Ship(game, myUsername, opponent);
            main.FormClosed += Battle_Ship_FormClosed;
            main.Show();
            this.Hide();
        }

        /// <summary>
        /// This PlayerLoggedIn callback. When the palyer logged in than the callback will add the player on Online field.
        /// And display the player those who are online player lists.
        /// </summary>
        /// <param name="playerlists"></param>
        public void PlayerLoggedIn(List<BattleShipService.Player> playerlists)
        {
            this.lbOnlinePlayers.Items.Clear();
            onlinePlayers = playerlists;
            foreach (BattleShipService.Player players in playerlists)
            {
                lbOnlinePlayers.Items.Add(players.name);
            }
        }
    }
}
