using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class MyPoint:Geometry
    {
        public Point position;
        public Point Position { get { return position; } set { position = value; } } 
        public MyPoint(Point positionCenter, Color color): base(color)
        {
            this.position.X = positionCenter.X - 2;
            this.position.Y = positionCenter.Y - 2;
        }
       
    }
}
