using System.Collections.Generic;
using DonaldKnuthAlgoX.Algorithm;
using DonaldKnuthAlgoX.Structs;
using System.Threading;
using System;

namespace DonaldKnuthAlgoX
{
    class Program
    {
        List<FigureRow> frows;

        static void Main(string[] args)
        {
            Program program = new Program();
            int boardWidth;
            int boardHeight;

            /* Example:
             *   Values for boardWidth and boardHeight like: 
             *      20 and 3, 12 and 5, 15 and 4, 10 and 6, etc.
             */

            program.ReadInput(out boardWidth, nameof(boardWidth));
            program.ReadInput(out boardHeight, nameof(boardHeight));
            Console.Clear();

            program.StartPentamimoGame(boardWidth: boardWidth, boardHeight: boardHeight);
            Console.Read();
        }

        void ReadInput(out int target, string targetName)
        {
            string potentialTarget;
            do
            {
                Console.WriteLine($"Set the integer value of the {targetName}:");
                potentialTarget = Console.ReadLine();
            } while (! int.TryParse(potentialTarget, out target));
        }

        void StartPentamimoGame(int boardWidth, int boardHeight)
        {
            Dance dance = new Dance(12 + 60);
            Pentamimo.Pentamimo pentamimo = new Pentamimo.Pentamimo();

            int nr = 0;
            int fn = 0;
            frows = new List<FigureRow>();
            foreach (Figure figure in pentamimo.figures)
            {
                int vn = 0;
                foreach (Variant variant in figure.Variants)
                {
                    for (int sx = 0; sx < boardWidth; sx++)
                    {
                        for (int sy = 0; sy < boardHeight; sy++)
                        {
                            bool can = true;
                            for (int i = 0; i < variant.X.Length; i++)
                            {
                                if (variant.X[i] + sx < 0 || variant.X[i] + sx >= boardWidth)
                                    can = false;
                                if (variant.Y[i] + sy < 0 || variant.Y[i] + sy >= boardHeight)
                                    can = false;
                            }
                            if (!can)
                                continue;

                            dance.AddRow(nr, new int[]
                            {
                                fn,
                                12 + variant.X[0] + sx + boardWidth * (variant.Y[0] + sy),
                                12 + variant.X[1] + sx + boardWidth * (variant.Y[1] + sy),
                                12 + variant.X[2] + sx + boardWidth * (variant.Y[2] + sy),
                                12 + variant.X[3] + sx + boardWidth * (variant.Y[3] + sy),
                                12 + variant.X[4] + sx + boardWidth * (variant.Y[4] + sy)
                            });
                            frows.Add(new FigureRow(fn, vn, sx, sy));
                            nr++;
                        }
                    }
                    vn++;
                }
                fn++;
            }
            foreach (var ans in dance.Go(0))
            {
                foreach (int row in ans)
                    pentamimo.Show(frows[row]);

                Thread.Sleep(10);

                foreach (int row in ans)
                {
                    pentamimo.Hide(frows[row]);
                    break;
                }
            }
        }
    }
}
