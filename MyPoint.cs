using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class MyPoint:Geometry
    {
        private Point position; 
        public MyPoint(Point positionCenter, Color color): base(color)
        {
            this.position.X = positionCenter.X - 2;
            this.position.Y = positionCenter.Y - 2;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(brush, position.X, position.Y, 4, 4);
        }
    }
}
