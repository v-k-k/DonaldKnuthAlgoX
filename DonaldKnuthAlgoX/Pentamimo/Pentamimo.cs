using DonaldKnuthAlgoX.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaldKnuthAlgoX.Pentamimo
{
    public class Pentamimo
    {
        public string names = "FILNPTUVWXYZ ";
        public Figure[] figures;

        public Pentamimo(int range = 12)
        {
            InitRange(range);
        }

        void InitRange(int range)
        {
            figures = new Figure[range];
            figures[0].Total = 2;                                // F
            figures[0].Variants = new Variant[figures[0].Total];
            figures[0].Variants[0].X = new int[] { 0, 1, -1, 0, 0 }; figures[0].Variants[0].Y = new int[] { 0, 0, 1, 1, 2 };
            figures[0].Variants[1].X = new int[] { 0, -1, 0, 1, 1 }; figures[0].Variants[1].Y = new int[] { 0, 1, 1, 1, 2 };

            figures[1].Total = 2;                                // I
            figures[1].Variants = new Variant[figures[1].Total];
            figures[1].Variants[0].X = new int[] { 0, 0, 0, 0, 0 }; figures[1].Variants[0].Y = new int[] { 0, 1, 2, 3, 4 };
            figures[1].Variants[1].X = new int[] { 0, 1, 2, 3, 4 }; figures[1].Variants[1].Y = new int[] { 0, 0, 0, 0, 0 };

            figures[2].Total = 8;                                // L
            figures[2].Variants = new Variant[figures[2].Total];
            figures[2].Variants[0].X = new int[] { 0, 0, 0, 0, 1 }; figures[2].Variants[0].Y = new int[] { 0, 1, 2, 3, 3 };
            figures[2].Variants[1].X = new int[] { 0, 1, 2, 3, 0 }; figures[2].Variants[1].Y = new int[] { 0, 0, 0, 0, 1 };
            figures[2].Variants[2].X = new int[] { 0, 1, 1, 1, 1 }; figures[2].Variants[2].Y = new int[] { 0, 0, 1, 2, 3 };
            figures[2].Variants[3].X = new int[] { 0, -3, -2, -1, 0 }; figures[2].Variants[3].Y = new int[] { 0, 1, 1, 1, 1 };
            figures[2].Variants[4].X = new int[] { 0, 0, 0, -1, 0 }; figures[2].Variants[4].Y = new int[] { 0, 1, 2, 3, 3 };
            figures[2].Variants[5].X = new int[] { 0, 1, 2, 3, 3 }; figures[2].Variants[5].Y = new int[] { 0, 0, 0, 0, 1 };
            figures[2].Variants[6].X = new int[] { 0, 1, 0, 0, 0 }; figures[2].Variants[6].Y = new int[] { 0, 0, 1, 2, 3 };
            figures[2].Variants[7].X = new int[] { 0, 0, 1, 2, 3 }; figures[2].Variants[7].Y = new int[] { 0, 1, 1, 1, 1 };

            figures[3].Total = 8;                                // N
            figures[3].Variants = new Variant[figures[3].Total];
            figures[3].Variants[0].X = new int[] { 0, 1, 1, 2, 3 }; figures[3].Variants[0].Y = new int[] { 0, 0, 1, 1, 1 };
            figures[3].Variants[1].X = new int[] { 0, -1, 0, -1, -1 }; figures[3].Variants[1].Y = new int[] { 0, 1, 1, 2, 3 };
            figures[3].Variants[2].X = new int[] { 0, 1, 2, 2, 3 }; figures[3].Variants[2].Y = new int[] { 0, 0, 0, 1, 1 };
            figures[3].Variants[3].X = new int[] { 0, 0, -1, 0, -1 }; figures[3].Variants[3].Y = new int[] { 0, 1, 2, 2, 3 };
            figures[3].Variants[4].X = new int[] { 0, 1, -2, -1, 0 }; figures[3].Variants[4].Y = new int[] { 0, 0, 1, 1, 1 };
            figures[3].Variants[5].X = new int[] { 0, 0, 1, 1, 1 }; figures[3].Variants[5].Y = new int[] { 0, 1, 1, 2, 3 };
            figures[3].Variants[6].X = new int[] { 0, 1, 2, -1, 0 }; figures[3].Variants[6].Y = new int[] { 0, 0, 0, 1, 1 };
            figures[3].Variants[7].X = new int[] { 0, 0, 0, 1, 1 }; figures[3].Variants[7].Y = new int[] { 0, 1, 2, 2, 3 };

            figures[4].Total = 8;                                // P
            figures[4].Variants = new Variant[figures[4].Total];
            figures[4].Variants[0].X = new int[] { 0, 1, 0, 1, 0 }; figures[4].Variants[0].Y = new int[] { 0, 0, 1, 1, 2 };
            figures[4].Variants[1].X = new int[] { 0, 1, 2, 1, 2 }; figures[4].Variants[1].Y = new int[] { 0, 0, 0, 1, 1 };
            figures[4].Variants[2].X = new int[] { 0, -1, 0, -1, 0 }; figures[4].Variants[2].Y = new int[] { 0, 1, 1, 2, 2 };
            figures[4].Variants[3].X = new int[] { 0, 1, 0, 1, 2 }; figures[4].Variants[3].Y = new int[] { 0, 0, 1, 1, 1 };
            figures[4].Variants[4].X = new int[] { 0, 1, 0, 1, 1 }; figures[4].Variants[4].Y = new int[] { 0, 0, 1, 1, 2 };
            figures[4].Variants[5].X = new int[] { 0, 1, 2, 0, 1 }; figures[4].Variants[5].Y = new int[] { 0, 0, 0, 1, 1 };
            figures[4].Variants[6].X = new int[] { 0, 0, 1, 0, 1 }; figures[4].Variants[6].Y = new int[] { 0, 1, 1, 2, 2 };
            figures[4].Variants[7].X = new int[] { 0, 1, -1, 0, 1 }; figures[4].Variants[7].Y = new int[] { 0, 0, 1, 1, 1 };

            figures[5].Total = 4;                                // T
            figures[5].Variants = new Variant[figures[5].Total];
            figures[5].Variants[0].X = new int[] { 0, 1, 2, 1, 1 }; figures[5].Variants[0].Y = new int[] { 0, 0, 0, 1, 2 };
            figures[5].Variants[1].X = new int[] { 0, -2, -1, 0, 0 }; figures[5].Variants[1].Y = new int[] { 0, 1, 1, 1, 2 };
            figures[5].Variants[2].X = new int[] { 0, 0, -1, 0, 1 }; figures[5].Variants[2].Y = new int[] { 0, 1, 2, 2, 2 };
            figures[5].Variants[3].X = new int[] { 0, 0, 1, 2, 0 }; figures[5].Variants[3].Y = new int[] { 0, 1, 1, 1, 2 };

            figures[6].Total = 4;                                // U
            figures[6].Variants = new Variant[figures[6].Total];
            figures[6].Variants[3].X = new int[] { 0, 2, 0, 1, 2 }; figures[6].Variants[3].Y = new int[] { 0, 0, 1, 1, 1 };
            figures[6].Variants[2].X = new int[] { 0, 1, 0, 0, 1 }; figures[6].Variants[2].Y = new int[] { 0, 0, 1, 2, 2 };
            figures[6].Variants[1].X = new int[] { 0, 1, 2, 0, 2 }; figures[6].Variants[1].Y = new int[] { 0, 0, 0, 1, 1 };
            figures[6].Variants[0].X = new int[] { 0, 1, 1, 0, 1 }; figures[6].Variants[0].Y = new int[] { 0, 0, 1, 2, 2 };

            figures[7].Total = 4;                                // V
            figures[7].Variants = new Variant[figures[7].Total];
            figures[7].Variants[0].X = new int[] { 0, 0, 0, 1, 2 }; figures[7].Variants[0].Y = new int[] { 0, 1, 2, 2, 2 };
            figures[7].Variants[1].X = new int[] { 0, 1, 2, 0, 0 }; figures[7].Variants[1].Y = new int[] { 0, 0, 0, 1, 2 };
            figures[7].Variants[2].X = new int[] { 0, 1, 2, 2, 2 }; figures[7].Variants[2].Y = new int[] { 0, 0, 0, 1, 2 };
            figures[7].Variants[3].X = new int[] { 0, 0, -2, -1, 0 }; figures[7].Variants[3].Y = new int[] { 0, 1, 2, 2, 2 };

            figures[8].Total = 4;                                // W
            figures[8].Variants = new Variant[figures[8].Total];
            figures[8].Variants[0].X = new int[] { 0, 0, 1, 1, 2 }; figures[8].Variants[0].Y = new int[] { 0, 1, 1, 2, 2 };
            figures[8].Variants[1].X = new int[] { 0, 1, -1, 0, -1 }; figures[8].Variants[1].Y = new int[] { 0, 0, 1, 1, 2 };
            figures[8].Variants[2].X = new int[] { 0, 1, 1, 2, 2 }; figures[8].Variants[2].Y = new int[] { 0, 0, 1, 1, 2 };
            figures[8].Variants[3].X = new int[] { 0, -1, 0, -2, -1 }; figures[8].Variants[3].Y = new int[] { 0, 1, 1, 2, 2 };

            figures[9].Total = 1;                                // X
            figures[9].Variants = new Variant[figures[9].Total];
            figures[9].Variants[0].X = new int[] { 0, -1, 0, 1, 0 }; figures[9].Variants[0].Y = new int[] { 0, 1, 1, 1, 2 };

            figures[10].Total = 8;                                // Y
            figures[10].Variants = new Variant[figures[10].Total];
            figures[10].Variants[0].X = new int[] { 0, -1, 0, 0, 0 }; figures[10].Variants[0].Y = new int[] { 0, 1, 1, 2, 3 };
            figures[10].Variants[1].X = new int[] { 0, -2, -1, 0, 1 }; figures[10].Variants[1].Y = new int[] { 0, 1, 1, 1, 1 };
            figures[10].Variants[2].X = new int[] { 0, 0, 0, 1, 0 }; figures[10].Variants[2].Y = new int[] { 0, 1, 2, 2, 3 };
            figures[10].Variants[3].X = new int[] { 0, 1, 2, 3, 1 }; figures[10].Variants[3].Y = new int[] { 0, 0, 0, 0, 1 };
            figures[10].Variants[4].X = new int[] { 0, 0, 1, 0, 0 }; figures[10].Variants[4].Y = new int[] { 0, 1, 1, 2, 3 };
            figures[10].Variants[5].X = new int[] { 0, -1, 0, 1, 2 }; figures[10].Variants[5].Y = new int[] { 0, 1, 1, 1, 1 };
            figures[10].Variants[6].X = new int[] { 0, 0, -1, 0, 0 }; figures[10].Variants[6].Y = new int[] { 0, 1, 2, 2, 3 };
            figures[10].Variants[7].X = new int[] { 0, 1, 2, 3, 2 }; figures[10].Variants[7].Y = new int[] { 0, 0, 0, 0, 1 };

            figures[11].Total = 4;                                // Z
            figures[11].Variants = new Variant[figures[11].Total];
            figures[11].Variants[0].X = new int[] { 0, 1, 1, 1, 2 }; figures[11].Variants[0].Y = new int[] { 0, 0, 1, 2, 2 };
            figures[11].Variants[1].X = new int[] { 0, -2, -1, 0, -2 }; figures[11].Variants[1].Y = new int[] { 0, 1, 1, 1, 2 };
            figures[11].Variants[2].X = new int[] { 0, 1, 0, -1, 0 }; figures[11].Variants[2].Y = new int[] { 0, 0, 1, 2, 2 };
            figures[11].Variants[3].X = new int[] { 0, 0, 1, 2, 2 }; figures[11].Variants[3].Y = new int[] { 0, 1, 1, 1, 2 };
        }

        public void Show(int fnr, int vnr, int sx, int sy)
        {
            __Show(figures[fnr].Variants[vnr], fnr, sx, sy);
        }

        public void Show(FigureRow fr)
        {
            __Show(figures[fr.fn].Variants[fr.vn], fr.fn, fr.sx, fr.sy);
        }

        public void Hide(int fnr, int vnr, int sx, int sy)
        {
            __Show(figures[fnr].Variants[vnr], names.Length - 1, sx, sy);
        }

        public void Hide(FigureRow fr)
        {
            __Show(figures[fr.fn].Variants[fr.vn], names.Length - 1, fr.sx, fr.sy);
        }

        private void __Show(Variant v, int fnr, int sx, int sy)
        {
            Console.ForegroundColor = (ConsoleColor)fnr + 1;
            for(int j =  0; j < v.X.Length; j++)
            {
                Console.SetCursorPosition(sx + v.X[j], sy + v.Y[j]);
                Console.Write(names.Substring(fnr, 1));
            }
        }
    }
}
