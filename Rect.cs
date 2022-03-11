using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rect:Geometry
    {

        public Point position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Rect(Point point, int width, int height, Color color) : base(color)
        {
            position = point;
            this.Width = width;
            this.Height = height;

        }
        public Rect(Point first, Point second, Color color) : base(color)
        {
            position = first;
            this.Width = second.X- first.X;
            this.Height = second.Y - first.Y;

        }
        public override void Draw(Graphics g)
        {

            g.FillRectangle(brush, position.X, position.Y, Width, Height);
        }
    }
}
