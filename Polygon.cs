using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Polygon : Geometry
    {
        public List<PointF> Vertices { get; set; }

        public PointF[] Points  { get; set;}
       
        public Polygon(PointF[] points, Color color) : base(color)
        {
            this.Points = points;
            Vertices = new List<PointF>();
            Points = Array.Empty<PointF>();
            //points.CopyTo(this.points, points.Length);
        }
        public Polygon(Color color) : base(color)
        {
            Vertices = new List<PointF>();
            Points = Array.Empty<PointF>();


        }
        public override void Draw(Graphics g)
        {
            Points = Vertices.ToArray();
            g.FillPolygon(brush, Points);
        }
    }
}
