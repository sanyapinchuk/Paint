using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    abstract class Geometry
    {
        public SolidBrush brush;
        public Geometry(Color color)
        {
            brush = new SolidBrush(color);
        }
    }
}
