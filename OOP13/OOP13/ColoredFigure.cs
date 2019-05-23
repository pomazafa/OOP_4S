using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP13
{
    class ColoredFigure
    {
        public string TypeFigure { get; set; }
        // соль
        public string Color { get; set; }
        // пищевые добавки
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Color != null)
                sb.Append(Color);

            if (TypeFigure != null)
                sb.Append(TypeFigure);
            sb.Append('\n');
            return sb.ToString();
        }
    }
}
