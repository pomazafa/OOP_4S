using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    class FactoryYellow : AbstractFactory
    {
        public override Circle CreateCircle()
        {
            return new YellowCircle();
        }

        public override Rectangle CreateRectangle()
        {
            return new YellowRectangle();
        }
    }
}
