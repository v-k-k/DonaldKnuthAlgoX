
namespace DonaldKnuthAlgoX.Cells
{
    /// <summary>
    /// Header of the Cell's column
    /// </summary>
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
