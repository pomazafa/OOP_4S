using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    abstract class AbstractFactory
    {
        public abstract Circle CreateCircle();
        public abstract Rectangle CreateRectangle();
    }
}
