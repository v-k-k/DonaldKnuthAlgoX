using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX.Structs
{
    public struct FigureRow
    {
        public int fn;
        public int vn;
        public int sx;
        public int sy;

        public FigureRow(int fn, int vn, int sx, int sy)
        {
            this.fn = fn;
            this.vn = vn;
            this.sx = sx;
            this.sy = sy;
        }
    }
}
