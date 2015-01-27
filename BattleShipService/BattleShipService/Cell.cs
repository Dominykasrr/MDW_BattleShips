using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipService
{
    public class Cell
    {
        public int x;
        public int y;
        public bool isEmpty;
        public Cell(int x, int y, bool empty)
        {
            this.x = x;
            this.y = y;
            this.isEmpty = empty;
        }
    }
}
