using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Geometry
    {
        abstract public void Draw(Graphics g);
        public SolidBrush brush;
        public Geometry(Color color)
        {
            brush = new SolidBrush(color);
        }
    }
}
