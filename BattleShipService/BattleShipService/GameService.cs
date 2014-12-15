using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BattleShipService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IPortal
    {
        public List<Player> onlinePlayers = new List<Player>();
        public List<Player> registeredPlayers = new List<Player>();
        GameService()
        {
            registeredPlayers.Add(new Player("tool", "bar"));
            registeredPlayers.Add(new Player("bar", "tool"));
        }
        public bool Login(string name, string passwd)
        {
            foreach(Player p in registeredPlayers)
            {
                if(p.name==name && p.passwd==passwd)
                {
                    foreach(Player player in onlinePlayers)
                    {
                        player.loginCallback.playerLoggedIn(player.name);
                    }
                    p.loginCallback = OperationContext.Current.GetCallbackChannel<PlayerLogInCallback>();
                    onlinePlayers.Add(p);
                    return true;
                }
            }
            return false;
        }
    }
}
