namespace Figures
{
    class AllFigures
    {
        public AllFigures()
        {
            
            point = new MyPoint(new Point(500, 10), Color.Red);

            line = new Line(new Point(100, 100), 200, 20f, Color.Blue);

            rect = new Rect(new Point(100, 200), 200, 100, Color.Brown);

            square = new Square(new Point(20, 400), 150, Color.Black);

            ellipse = new Ellipse(new Point(690, 40), 200, 100, Color.Yellow);

            circle = new Circle(new Point(715, 260), 70, Color.Green);


           /* PointF temppoint6 = new PointF(715f, 460f);
            PointF temppoint7 = new PointF(885f, 470f);
            PointF temppoint8 = new PointF(855f, 580f);
            PointF temppoint9 = new PointF(725f,500f);*/
            // PointF[] arrpoints = new[] { temppoint6,temppoint7, temppoint8 , temppoint9};
            
            PointF[] arrpoints = new[] { new PointF(715f, 460f), new PointF(885f, 470f), new PointF(855f, 580f), new PointF(725f, 500f) };
            polygon = new Polygon(arrpoints, Color.Gray);



        }
        /*private List<Line> lines;
        private List<Rect> rects;
        private List<Square> squares;
        private List<Ellipse> ellipses;
        private List<Circle> circles;
        private List<Polygon> polygons;*/

        public List<MyPoint> Points { get; set; } = new List<MyPoint> { };
        public List<Line> Lines { get; set; } = new List<Line> { };
        public List<Rect> Rects { get; set; } = new List<Rect> { };
        public List<Square> Squares { get; set; } = new List<Square> { };
        public List<Ellipse> Ellipses { get; set; } = new List<Ellipse> { };
        public List<Circle> Circles { get; set; } = new List<Circle> { };
        public List<Polygon> Polygons { get; set; } = new List<Polygon> { };



        private MyPoint point;
        private Line line;
        private Rect rect;
        private Square square;
        private Ellipse ellipse;
        private Circle circle;
        private Polygon polygon;
        public MyPoint Point
        {
            get { return point; }
            set { point = value; }
        }
        public Line Line { 
            get { return line; }
            set { line = value; }
        }
        public Rect Rect
        {
            get { return rect; }
            set { rect = value; }
        }
        public Square Square
        {
            get { return square; }
            set { square = value; }
        }
        public Ellipse Ellipse
        {
            get { return ellipse; }
            set { ellipse = value; }
        }
        public Circle Circle
        {
            get { return circle; }
            set { circle = value; }
        }
        public Polygon Polygon
        {
            get { return polygon; }
            set { polygon = value; }
        }
    }
}
