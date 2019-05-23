using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP13
{

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    class Rectangle1 : IFigure
    {
        int width;
        int height;
        public Rectangle1(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle1(this.width, this.height);
        }
        public void GetInfo()
        {
            MessageBox.Show("Прямоугольник длиной " + height + " и шириной " + width);
        }
    }

    class Circle1 : IFigure
    {
        int radius;
        public Circle1(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle1(this.radius);
        }
        public void GetInfo()
        {
            MessageBox.Show("Круг радиусом " + radius);
        }
    }
}
