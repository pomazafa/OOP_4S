using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP13
{
    class Creator
    {
        public Creator(AbstractFactory factory, int circle, int rectangle)
        {
            for (int i = 0; i < circle; i++)
            {
                Dialog.circles.Add(factory.CreateCircle());
            }
            for (int i = 0; i < rectangle; i++)
            {
                Dialog.rectangles.Add(factory.CreateRectangle());
            }
        }
    }
}
