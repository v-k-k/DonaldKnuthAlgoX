using DonaldKnuthAlgoX.Algorithm;
using DonaldKnuthAlgoX.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dance dance = new Dance(45);

            dance.AddRow(0, new[] { 24, 33, 34 });
            dance.AddRow(1, new[] { 34, 43, 44 });
            dance.AddRow(2, new[] { 33, 42, 43 });
            dance.AddRow(3, new[] { 13, 14, 24 });

            dance.AddRow(4, new[] { 32, 33, 43 });
            dance.AddRow(5, new[] { 31, 32, 41 });
            dance.AddRow(6, new[] { 23, 32, 33 });
            dance.AddRow(7, new[] { 23, 33, 34 });

            dance.AddRow(8, new[] { 13, 14, 23 });
            dance.AddRow(9, new[] { 31, 41, 42 });
            dance.AddRow(10, new[] { 33, 34, 44 });
            dance.AddRow(11, new[] { 33, 43, 44 });
            */

            Program pr = new Program();
            pr.StartPent(20, 3);

            //Dance dance = new Dance(12);

            //dance.AddRow(0, new[] { 3, 6, 7 });
            //dance.AddRow(1, new[] { 7, 10, 11 });
            //dance.AddRow(2, new[] { 6, 9, 10 });
            //dance.AddRow(3, new[] { 0, 1, 3 });

            //dance.AddRow(4, new[] { 5, 6, 10 });
            //dance.AddRow(5, new[] { 4, 5, 8 });
            //dance.AddRow(6, new[] { 2, 5, 6 });
            //dance.AddRow(7, new[] { 2, 6, 7 });

            //dance.AddRow(8, new[] { 0, 1, 2 });
            //dance.AddRow(9, new[] { 4, 8, 9 });
            //dance.AddRow(10, new[] { 6, 7, 11 });
            //dance.AddRow(11, new[] { 6, 10, 11 });

            //dance.Go(0);
            Console.Read();
        }

        void StartPent(int a, int b)
        {
            Dance dance = new Dance(12 + 60);
            Pentamimo.Pentamimo pent = new Pentamimo.Pentamimo();
            pent.Show(2, 3, 5, 10);
        }
    }
}
