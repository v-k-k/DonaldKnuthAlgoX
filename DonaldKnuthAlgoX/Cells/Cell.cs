using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX.Cells
{
    public class Cell
    {
        public int row;
        public Cell L { get; set; }
        public Cell R { get; set; }
        public Cell U { get; set; }
        public Cell D { get; set; }
        public Header H { get; set; }

        public Cell(Header header)
        {
            row = -1;
            L = this;
            R = this;
            U = this;
            D = this;
            H = header;
        }

        public void InsertLeft(Cell cell)
        {
            cell.L = L;
            L.R = cell;
            L = cell;
            cell.R = this;
        }

        public void InsertUp(Cell cell)
        {
            cell.U = U;
            U.D = cell;
            U = cell;
            cell.D = this;
        }
    }
}
