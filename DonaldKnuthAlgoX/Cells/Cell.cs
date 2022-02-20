
namespace DonaldKnuthAlgoX.Cells
{
    /// <summary>
    /// Class for the node of the 2 dimensional 2 linked list
    /// </summary>
    public class Cell
    {
        public int row;
        public Cell L;
        public Cell R;
        public Cell U;
        public Cell D;
        public Header H;

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
