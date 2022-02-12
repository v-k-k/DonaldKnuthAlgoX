using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX.Cells
{
    public class Header : Cell
    {
        public int name;
        public int size;

        public Header(int name)
            : base(null)
        {
            this.name = name;
            size = 0;
            H = this;
        }
    }
}
