using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BattleShipService
{
    [DataContract]
    public class Player
    {
        public int useID;
        public string name;
        public string passwd;
        public IPortalCallback iPortal_Callback;
        public IChatCallback IchatCallBack;
        public List<Ship> shiplist;

        public Player(int useid, string name, string passwd)
        {
            this.Name = name;
            this.Passwd = passwd;
            this.useID = useid;
            shiplist = new List<Ship>();
        }
        [DataMember]
        public int UseID { get { return this.useID; } set { this.useID = value; } }

        [DataMember]
        public string Name { get { return this.name; } set { this.name = value; } }

        [DataMember]
        public string Passwd { get { return this.passwd; } set { this.passwd = value; } } 

        public IPortalCallback IPortal_Callback { get; set; }
        public IGameCallback IgameCallBack { get; set; }
    }
}
