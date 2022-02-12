using DonaldKnuthAlgoX.Cells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX.Algorithm
{
    public class Dance
    {
        Header root;
        Header[] headers;
        Stack<int> answer = new Stack<int>();

        public Dance(int columns)
        {
            root = new Header(-1);
            headers = new Header[columns];
            for(int j = 0; j< columns; j++)
            {
                headers[j] = new Header(j);
                root.InsertLeft(headers[j]);
            }
        }

        public void AddRow(int row, int[] ones)
        {
            int last = -1;
            Cell first = null;
            foreach(int x in ones)
            {
                Cell cell = new Cell(headers[x]);
                cell.row = row;
                headers[x].InsertUp(cell);
                headers[x].size++;

                if (x <= last)
                    throw new ArgumentException(
                        "Column indexes must be in increment order");
                last = x;

                if (first == null)
                    first = cell;
                else
                    first.InsertLeft(cell);
            }
        }

        public void Go(int step)
        {
            Console.WriteLine(step);
            //while (head.size == 0 && head != root)
            //    head = (Header)head.R;
            
            if (root.R == root)
            {
                Console.WriteLine("FOUND ANSWER");
                return;
            }

            Header head = (Header)root.R;

            Cover(head);
            for (Cell cell = head.D; cell != head; cell = cell.D)
            {
                answer.Push(cell.row);
                for (Cell nCell = cell.R; nCell != cell; nCell = nCell.R)
                    Cover(nCell.H);

                Go(step + 1);

                answer.Pop();
                for (Cell nCell = cell.L; nCell != cell; nCell = nCell.L)
                    Uncover(nCell.H);
            }
            Uncover(head);
        }

        private void Cover(Header head)
        {
            head.R.L = head.L;
            head.L.R = head.R;

            for(Cell cell = head.D; cell != head; cell = cell.D)
            {
                for (Cell nCell = cell.R; nCell != cell; nCell = nCell.R)
                {
                    nCell.D.U = nCell.U;
                    nCell.U.D = nCell.D;
                    nCell.H.size--;
                }
            }
        }

        private void Uncover(Header head)
        {
            for (Cell cell = head.U; cell != head; cell = cell.U)
            {
                for (Cell nCell = cell.L; nCell != cell; nCell = nCell.L)
                {
                    nCell.D.U = nCell;
                    nCell.U.D = nCell;
                    nCell.H.size++;
                }
            }
            head.R.L = head;
            head.L.R = head;
        }
    }
}
