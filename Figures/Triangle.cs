using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Triangle : BaseFigure
    {
        private int x1,y1; 
        private int x2, y2;
        private int x3, y3;

        public int p_x1 { get { return x1; } set { x1 = value; } }
        public int p_x2 { get { return x2; } set { x2 = value; } }
        public int p_x3 { get { return x3; } set { x3 = value; } }
        public int p_y1 { get { return y1; } set { y1 = value; } }
        public int p_y2 { get { return y2; } set { y2 = value; } }
        public int p_y3 { get { return y3; } set { y3 = value; } }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            id = ++index;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }
        public Triangle()
        {
            id = ++index;
        }

        public override string FigureName() { return "трегуольник"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"Это {FigureName()} с координатами({x1},{y1}),({x2},{y2}),({x3},{y3})");
        }

        public override void changeAllCoordinatesConsole()
        {
            Console.Write("x1 => ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 => ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("x2 => ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 => ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("x3 => ");
            x3 = int.Parse(Console.ReadLine());
            Console.Write("y3 => ");
            y3 = int.Parse(Console.ReadLine());
        }
    }
}

