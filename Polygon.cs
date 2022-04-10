using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class Polygon : Geometry
    {
        public List<PointF> Vertices { get; set; }

        public PointF[] Points  { get; set; }
       
        public Polygon(PointF[] points, Color color) : base(color)
        {
            this.Points = points;
            Vertices = new List<PointF>();
            //Points = Array.Empty<PointF>();
            //points.CopyTo(this.points, points.Length);
        }
        public Polygon(Color color) : base(color)
        {
            Vertices = new List<PointF>();
            Points = Array.Empty<PointF>();


        }
    }
}
