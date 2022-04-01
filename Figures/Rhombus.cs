using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Rhombus: Parallelogram
    {
        public override int p_x4 { get { return x4; } }
        public override int p_y4 { get { return y4; } }
        public Rhombus(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }
        public Rhombus() : base()
        {
        }
        public override string FigureName() { return "ромб"; }
    }
}
