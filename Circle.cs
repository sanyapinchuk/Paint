using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle: Ellipse
    {
        public Circle(Point center, int radius, Color color): base(center,radius,radius,color)
        {
            Width = Height = radius*2;
            FirstPoint = center;            
        }

    }
}
