using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    class Builder
    {
        public ColoredFigure Build(AbstractBuilder breadBuilder)
        {
            breadBuilder.CreateFigure();
            breadBuilder.SetTypeFigure();
            breadBuilder.SetColor();
            return breadBuilder.coloredFigure;
        }
    }

    class BlueTriangleBuilder : AbstractBuilder
    {
        public override void SetTypeFigure()
        {
            this.coloredFigure.TypeFigure = "triangle";
        }

        public override void SetColor()
        {
            this.coloredFigure.Color = "blue";
        }
    }

    class EllipceBuilder : AbstractBuilder
    {
        public override void SetTypeFigure()
        {
            this.coloredFigure.TypeFigure = "ellipce";
        }

        public override void SetColor()
        {
        }
    }
}
