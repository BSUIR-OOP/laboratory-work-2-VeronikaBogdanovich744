using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Rectangle : Parallelogram
    {
        public override int p_x3 { get { return x3; } }
        public override int p_x4 { get { return x4; } }
        public override int p_y3 { get { return y3; } }
        public override int p_y4 { get { return y4; } }
        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x1, y2, x2, y2, x2, y1)
        {

        }
        public Rectangle() : base()
        {

        }
        public override string FigureName() { return "прямоугольник"; }

        public override void ShowFigure()
        {
            Console.WriteLine(
                 $"Это прямоугольник с координатами противоположных углов ({this.x1},{this.y1}),({this.x2},{this.y2})");
        }

        public override void changeAllCoordinatesConsole()
        {
            Console.Write("Left bottom x => ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Left bottom y => ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("Right top x => ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("Right top y => ");
            y2 = int.Parse(Console.ReadLine());
        }
    }
}

