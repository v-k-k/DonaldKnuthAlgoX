
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
