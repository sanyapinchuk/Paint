using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Line:Geometry
    {
       /* private readonly int x1;
        private readonly int y1;
        private readonly int x2;
        private readonly int y2;*/

        public Point First { get; set; }
        public Point Second { get; set; }

        public Line(Point first, Point second, Color color) : base(color)
        {
           /* x1 = first.X;
            y1 = first.Y;*/
            First = first;
            Second = second;
            /*x2 = second.X;
            y2 = second.Y;*/
        }
        public Line( Point point, int length, float angle, Color color) : base(color)
        {
            First = point;
            /*x2 = x1 + (int)(length * Math.Cos(angle * Math.PI / 180));
            y2 = y1 - (int)(length * Math.Sin(angle * Math.PI / 180));*/
            Second = new Point(First.X + (int)(length * Math.Cos(angle * Math.PI / 180)),
                                First.Y - (int)(length * Math.Sin(angle * Math.PI / 180)));
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(brush.Color, 4f);

            g.DrawLine(pen,First,Second);
        }

    }
}
