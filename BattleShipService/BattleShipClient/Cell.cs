using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BattleShipClient
{
    class Cell
    {
        public Point P;
        public bool isEmpty;
        public Cell(Point p, bool empty)
        {
            this.isEmpty = empty;
            P = p;
        }

        public Cell getCell()
        {
            return this;
        }


    }
}
