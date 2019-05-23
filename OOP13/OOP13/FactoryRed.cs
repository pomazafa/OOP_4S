using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    class FactoryRed : AbstractFactory
    {
        public override Circle CreateCircle()
        {
            return new RedCircle();
        }

        public override Rectangle CreateRectangle()
        {
            return new RedRectangle();
        }
    }
}
