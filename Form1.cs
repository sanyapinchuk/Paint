using System.Drawing;
using System.Windows.Input;

namespace Figures
{

    public delegate void CurrentFiguresHandler();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = workArea.CreateGraphics();
            Cursor.Current = paintCursor;
            this.workArea.Cursor = paintCursor;
            clearButton.FlatAppearance.BorderSize = 1;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 100);
        }

        Cursor paintCursor = new Cursor("C:/Users/Asus/Desktop/4сем/ооп/Paint/icons/cursor.cur");

        

        private List<Point> cursorsHistory = new List<Point>();


        private Point mousePositon;
        public Graphics g;
        private AllFigures figures= new AllFigures();

        private Color globalColor = Color.Red;
        private bool isCreating = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*figures.Point.Draw(g);
            figures.Line.Draw(g);
            figures.Rect.Draw(g);
            figures.Square.Draw(g);
            figures.Ellipse.Draw(g);
            figures.Circle.Draw(g);
            figures.Polygon.Draw(g);*/
        }

        private void ChangeFiguresButtons(bool isEnable)
        {
            if (isEnable)
            {
                //figures
                circle.Enabled = true;
                ellipse.Enabled = true;
                square.Enabled = true;
                rect.Enabled = true;
                polygon.Enabled = true;
                line.Enabled = true;
                //colors
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
            }
            else
            {
                circle.Enabled = false;
                ellipse.Enabled = false;
                square.Enabled = false;
                rect.Enabled = false;
                polygon.Enabled = false;
                line.Enabled = false;
                
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        CurrentFiguresHandler currentFiguresHandler;

        private int GetDistanceBetweenPoints(Point first, Point second)
        {
            int result = (second.X - first.X) * (second.X - first.X);
            result += (second.Y - first.Y) * (second.Y - first.Y);
            result = Convert.ToInt32(Math.Sqrt(result));

            return result;
        }

        private bool IsNearPoints(Point first, Point second, int distance)
        {
            if (GetDistanceBetweenPoints(first,second) < 5)
                return true;
            else
                return false;
        }
        //create figures
        private void WorkArea_Click_Line()
        {
            //MessageBox.Show("Line");
            if (!isCreating)
            {
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                //figures.Points[0].Draw(g);
                cursorsHistory.Add(mousePositon);
                figures.Line.First = mousePositon;
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                cursorsHistory.Add(mousePositon);
                figures.Lines.Add(new Line(cursorsHistory[0], cursorsHistory[1],globalColor));
                isCreating =false;
                //this.Invalidate();
                workArea_Paint(this, PaintEventArgs.Empty);
                cursorsHistory.Clear();
                figures.Points.Clear();
                ChangeFiguresButtons(true);
            }
            
            
        }
        
        private void WorkArea_Click_Square()
        {
            if (!isCreating)
            {                
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                //figures.Points[0].Draw(g);
                cursorsHistory.Add(mousePositon);
                figures.Square.position = mousePositon;
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                cursorsHistory.Add(mousePositon);
                Point first= cursorsHistory[0], second = mousePositon;
                if (mousePositon.X - cursorsHistory[0].X < 0)
                {
                    (second.X, first.X) = (first.X, second.X);
                }
                if (mousePositon.Y - cursorsHistory[0].Y < 0)
                {
                    (second.Y, first.Y) = (first.Y, second.Y);
                }
                figures.Squares.Add(new Square(first, second, globalColor));
                isCreating = false;
                //this.Invalidate();
                workArea_Paint(this, PaintEventArgs.Empty);
                cursorsHistory.Clear();
                figures.Points.Clear();
                ChangeFiguresButtons(true);
            }
        }
        
        private void WorkArea_Click_Rect()
        {
            if (!isCreating)
            {
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                //figures.Points[0].Draw(g);
                cursorsHistory.Add(mousePositon);
                figures.Rect.position = mousePositon;
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                cursorsHistory.Add(mousePositon);
                Point first = cursorsHistory[0], second = mousePositon;
                if (mousePositon.X - cursorsHistory[0].X < 0)
                {
                    (second.X, first.X) = (first.X, second.X);
                }
                if (mousePositon.Y - cursorsHistory[0].Y < 0)
                {
                    (second.Y, first.Y) = (first.Y, second.Y);
                }
                figures.Rects.Add(new Rect(first, second, globalColor));
                isCreating = false;
                //this.Invalidate();
                workArea_Paint(this, PaintEventArgs.Empty);
                cursorsHistory.Clear();
                figures.Points.Clear();
                ChangeFiguresButtons(true);
            }
        }
        
        private void WorkArea_Click_Circle()
        {
            if (!isCreating)
            {
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                //figures.Points[0].Draw(g);
                cursorsHistory.Add(mousePositon);
                figures.Circle.FirstPoint = mousePositon;
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                cursorsHistory.Add(mousePositon);

                //calculate radius
                int radius = GetDistanceBetweenPoints(cursorsHistory[0], cursorsHistory[1]);
                
                figures.Circles.Add(new Circle(cursorsHistory[0], radius, globalColor));
                isCreating = false;
                //this.Invalidate();
                workArea_Paint(this, PaintEventArgs.Empty);
                cursorsHistory.Clear();
                figures.Points.Clear();
                ChangeFiguresButtons(true);
            }
        }
       
        private void WorkArea_Click_Ellipse()
        {
            if (!isCreating)
            {
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                //figures.Points[0].Draw(g);
                cursorsHistory.Add(mousePositon);
                figures.Ellipse.FirstPoint = mousePositon;
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                cursorsHistory.Add(mousePositon);
                Point first = cursorsHistory[0], second = mousePositon;
                if (mousePositon.X - cursorsHistory[0].X < 0)
                {
                    (second.X, first.X) = (first.X, second.X);
                }
                if (mousePositon.Y - cursorsHistory[0].Y < 0)
                {
                    (second.Y, first.Y) = (first.Y, second.Y);
                }
                figures.Ellipses.Add(new Ellipse(first, second, globalColor));
                isCreating = false;
                //this.Invalidate();
                workArea_Paint(this, PaintEventArgs.Empty);
                cursorsHistory.Clear();
                figures.Points.Clear();
                ChangeFiguresButtons(true);
            }
        }
      
        private void WorkArea_Click_Polygon()
        {
            if (!isCreating)
            {
                figures.Points.Add(new MyPoint(mousePositon, globalColor));
                PaintForm.Draw(g,figures.Points[0]);
                cursorsHistory.Add(mousePositon);
                /*figures.Polygon.Vertices.Clear();
                figures.Polygon.Vertices.Add(mousePositon);*/
                figures.Polygons.Add(new Polygon(globalColor));
                figures.Polygons.Last().Vertices.Add(mousePositon);
                isCreating = true;
                ChangeFiguresButtons(false);
            }
            else
            {
                if (!IsNearPoints(mousePositon, cursorsHistory[0], 555))
                {
                    cursorsHistory.Add(mousePositon);
                    figures.Points.Add(new MyPoint(mousePositon, globalColor));
                    PaintForm.Draw(g, figures.Points.Last());
                    figures.Polygons.Last().Vertices.Add(mousePositon);
                }
                else
                {
                    //figures.Polygons.Add(figures.Polygon);
                    isCreating = false;
                    //this.Invalidate();
                    workArea_Paint(this, PaintEventArgs.Empty);
                    cursorsHistory.Clear();
                    figures.Points.Clear();
                    ChangeFiguresButtons(true);
                }

                
            }
        }


        private void line_Click(object sender, EventArgs e)
        {

            currentFiguresHandler = WorkArea_Click_Line;

        }

        private void circle_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Circle;

        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Ellipse;
        }

        private void rect_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Rect;
        }

        private void square_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Square;
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Polygon;
        }
        
        
         
        private void workArea_Paint(object sender, EventArgs e)
        {
            foreach (Line lines in figures.Lines )
            {
                PaintForm.Draw(g, lines);
                //lines.Draw(g);
            }
            foreach (Square squares in figures.Squares)
            {
                PaintForm.Draw(g, squares);
                //squares.Draw(g);
            }
            foreach (Rect rects in figures.Rects)
            {
                PaintForm.Draw(g, rects);
            }
            foreach (Circle circles in figures.Circles)
            {
                PaintForm.Draw(g, circles);
            }
            foreach (Ellipse ellipses in figures.Ellipses)
            {
                PaintForm.Draw(g, ellipses);
            }
            foreach (Polygon polygons in figures.Polygons)
            {
                PaintForm.Draw(g, polygons);
            }
            // g.Clear(Color.White);
            /*figures.Point.Draw(g);
            figures.Line.Draw(g);
            figures.Rect.Draw(g);
            figures.Square.Draw(g);
            figures.Ellipse.Draw(g);
            figures.Circle.Draw(g);
            figures.Polygon.Draw(g);*/
        }
       


        private void workArea_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositon = e.Location;
          /*  if (IsLine)
            {
                figures.Line.Second = e.Location;
                
                figures.Line.Draw(g);
            }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globalColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            globalColor = Color.Black;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            globalColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            globalColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            globalColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()== DialogResult.OK)
            {
                globalColor = colorDialog1.Color;
            }
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            isCreating = false;
            cursorsHistory.Clear();
            figures.Points.Clear();
            ChangeFiguresButtons(true);

            figures.Lines.Clear();
            figures.Rects.Clear();
            figures.Ellipses.Clear();
            figures.Circles.Clear();
            figures.Squares.Clear();
            figures.Polygons.Clear();
        }

        private void workArea_Click(object sender, EventArgs e)
        {
            if (currentFiguresHandler != null)
                currentFiguresHandler();
        }

    }
}