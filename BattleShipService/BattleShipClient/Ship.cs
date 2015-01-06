using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipClient
{
    class Ship
    {
        private Cell cella;
        private Cell cellb;
        private Cell cellc;
        public List<Cell> celllist = new List<Cell>();
        public int holdingCell = 0;
        public Ship()
        { }

        public Ship(Cell cell1, Cell cell2)
        {
            this.cella = cell1;
            this.cellb = cell2;
            celllist.Add(cella);
            celllist.Add(cellb);
        }

        public Ship(Cell cell1, Cell cell2, Cell cell3)
        {
            this.cella = cell1;
            this.cellb = cell2;
            this.cellc = cell3;
            celllist.Add(cella);
            celllist.Add(cellb);
            celllist.Add(cellc);
        }
    }
}
