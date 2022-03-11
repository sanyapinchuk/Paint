using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Ellipse: Geometry
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public Point FirstPoint { get; set; }

        public Ellipse(Point point, int width, int height, Color color) : base(color)
        {
            FirstPoint = point;
            this.Width = width;
            this.Height = height;
        }
        public Ellipse(Point firstpoint, Point secondPoint, Color color) : base(color)
        {
            FirstPoint = firstpoint;
            this.Width = secondPoint.X - firstpoint.X;
            this.Height = secondPoint.Y - firstpoint.Y;
        }
    }
}
