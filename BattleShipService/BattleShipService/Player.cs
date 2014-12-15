using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipService
{
    public class Player
    {
        public string name { get; set; }
        public string passwd { get; set; }
        public PlayerLogInCallback loginCallback { get; set; }
        public Player(string name, string passwd)
        {
            this.name = name;
            this.passwd = passwd;
        }
    }
}
