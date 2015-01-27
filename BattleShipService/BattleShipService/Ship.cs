using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BattleShipService
{
    public class Ship
    {
        public int x;
        public int y;
        public bool isHorizontal;
        public int size;
        public Ship(int x, int y, bool isHorizontal, int size)
        {
            this.x = x;
            this.y = y;
            this.isHorizontal = isHorizontal;
            this.size = size;
        }
        bool direction;
        //int size;
    }
}
