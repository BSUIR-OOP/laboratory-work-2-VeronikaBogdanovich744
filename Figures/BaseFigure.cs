using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    internal abstract class BaseFigure
    {
        public int ID { get { return id; } }
        private protected int id;

        private protected static int index=0;
        public abstract string FigureName();
        public abstract void ShowFigure();
        public abstract void changeAllCoordinatesConsole();

    }
}
