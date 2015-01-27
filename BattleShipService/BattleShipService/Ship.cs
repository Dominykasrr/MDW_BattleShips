using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace BattleShipService
{
    [DataContract]
    public class Ship
    {
        [DataMember]
        public int x;
        [DataMember]
        public int y;
        [DataMember]
        public bool isHorizontal;
        [DataMember]
        public int size;
        [DataMember]
        public int cubesDestroyed;
        [DataMember]
        public bool direction;

        public Ship(int x, int y, bool isHorizontal, int size)
        {
            this.x = x;
            this.y = y;
            this.isHorizontal = isHorizontal;
            this.size = size;
        }
        //int size;
    }
}
