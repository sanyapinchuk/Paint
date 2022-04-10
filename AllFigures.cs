using System.Drawing;
using System.Collections.Generic;
namespace Figures
{
    class AllFigures
    {
        public AllFigures()
        {

        }

        public List<MyPoint> Points { get; set; } = new List<MyPoint> { };
        public List<Line> Lines { get; set; } = new List<Line> { };
        public List<Rect> Rects { get; set; } = new List<Rect> { };
        public List<Square> Squares { get; set; } = new List<Square> { };
        public List<Ellipse> Ellipses { get; set; } = new List<Ellipse> { };
        public List<Circle> Circles { get; set; } = new List<Circle> { };
        public List<Polygon> Polygons { get; set; } = new List<Polygon> { };

    }
}
