using DonaldKnuthAlgoX.Algorithm;
using DonaldKnuthAlgoX.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            pr.StartPent(20, 3);//(12, 5);//(15, 4);//(10, 6);//

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

        List<FigureRow> frows;

        void StartPent(int a, int b)
        {
            Dance dance = new Dance(12 + 60);
            Pentamimo.Pentamimo pent = new Pentamimo.Pentamimo();
            //pent.Show(2, 3, 5, 10);

            int nr = 0;
            int fn = 0;
            frows = new List<FigureRow>();
            foreach (Figure figure in pent.figures)
            {
                int vn = 0;
                foreach (Variant variant in figure.Variants)
                {
                    for (int sx = 0; sx < a; sx++)
                    {
                        for (int sy = 0; sy < b; sy++)
                        {
                            bool can = true;
                            for (int i = 0; i < variant.X.Length; i++)
                            {
                                if (variant.X[i] + sx < 0 || variant.X[i] + sx >= a)
                                    can = false;
                                if (variant.Y[i] + sy < 0 || variant.Y[i] + sy >= b)
                                    can = false;
                            }
                            if (!can)
                                continue;

                            dance.AddRow(nr, new int[]
                            {
                                fn,
                                12 + variant.X[0] + sx + a * (variant.Y[0] + sy),
                                12 + variant.X[1] + sx + a * (variant.Y[1] + sy),
                                12 + variant.X[2] + sx + a * (variant.Y[2] + sy),
                                12 + variant.X[3] + sx + a * (variant.Y[3] + sy),
                                12 + variant.X[4] + sx + a * (variant.Y[4] + sy)
                            });
                            frows.Add(new FigureRow(fn, vn, sx, sy));
                            //pent.Show(fn, vn, sx, sy);
                            //Console.SetCursorPosition(0, 10);
                            //Console.WriteLine(nr + " " + fn + " " + vn + " " + sx + " " + sy + "  ");
                            //Console.ReadLine();
                            //pent.Hide(fn, vn, sx, sy);
                            nr++;
                        }
                    }
                    vn++;
                }
                fn++;
            }
            //dance.AddRow(0, new[] { 3, 6, 7 });
            foreach (var ans in dance.Go(0))
            {
                //Console.Clear();
                foreach (int row in ans)
                    pent.Show(frows[row]);

                Thread.Sleep(10);

                foreach (int row in ans)
                {
                    pent.Hide(frows[row]);
                    break;
                }
                //Console.ReadLine();
            }
        }
    }
}
