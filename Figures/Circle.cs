using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Circle : Ellipse
    {
        public int radius { get { return mainAxis; } set { mainAxis = value; additionalAxis = value; } }

        public Circle(int x1, int y1, int r):base(x1,y1,r,r)
        {
        }
        public Circle() : base()
        {
        }

        public override string FigureName() { return "круг"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"Это {FigureName()} с центром в точке ({x},{y}) и радиусом {radius}");
        }
        public override void changeAllCoordinatesConsole()
        {
            Console.Write("Center x => ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Center y => ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Radius => ");
            radius = int.Parse(Console.ReadLine());
        }
    }
}
