using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    abstract class AbstractBuilder
    {
            public ColoredFigure coloredFigure { get; private set; }
            public void CreateFigure()
            {
                coloredFigure = new ColoredFigure();
            }
            public abstract void SetTypeFigure();
            public abstract void SetColor();
        }
}
