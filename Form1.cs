using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace Figures
{

    public delegate void CurrentFiguresHandler();
    public delegate void CurrentPensHandler(object sender, MouseEventArgs e);
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
            
            globalPen = new Pen(Color.Red, 1);
            globalPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            globalPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        Cursor paintCursor = new Cursor("C:/Users/Asus/Desktop/4сем/ооп/Paint/icons/cursor.cur");

        

        private List<Point> cursorsHistory = new List<Point>();

        private Point lastPosition = new Point(0,0);
        private Point mousePositon;
        public Graphics g;
        private AllFigures figures= new AllFigures();

        CurrentFiguresHandler currentFiguresHandler;

        private Color globalColor = Color.Red;

        Pen globalPen;

        private bool isCreating = false;
        private bool isPressed = false;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeFiguresButtons(bool isEnable)
        {
            circle.Enabled = isEnable;
            ellipse.Enabled = isEnable;
            square.Enabled = isEnable;
            rect.Enabled = isEnable;
            polygon.Enabled = isEnable;
            line.Enabled = isEnable;
            button7.Enabled = isEnable;
            //colors
            button1.Enabled = isEnable;
            button2.Enabled = isEnable;
            button3.Enabled = isEnable;
            button4.Enabled = isEnable;
            button5.Enabled = isEnable;
            button6.Enabled = isEnable;
           
        }



        private int GetDistanceBetweenPoints(Point first, Point second)
        {
            int result = (second.X - first.X) * (second.X - first.X);
            result += (second.Y - first.Y) * (second.Y - first.Y);
            result = Convert.ToInt32(Math.Sqrt(result));

            return result;
        }

        private bool IsNearPoints(Point first, Point second, int distance)
        {
            if (GetDistanceBetweenPoints(first,second) < distance)
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
                //figures.Line.First = mousePositon;
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
                //figures.Square.position = mousePositon;
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
                //figures.Rect.position = mousePositon;
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
                //figures.Circle.FirstPoint = mousePositon;
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
               // figures.Ellipse.FirstPoint = mousePositon;
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
                if (!IsNearPoints(mousePositon, cursorsHistory[0], 20))
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

        private void WorkArea_Click_Brush(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                g.DrawLine(globalPen, lastPosition, e.Location);
            }
            lastPosition = e.Location;
        }



        private void line_Click(object sender, EventArgs e)
        {

            currentFiguresHandler = WorkArea_Click_Line;
            workArea.MouseMove -= WorkArea_Click_Brush;

        }

        private void circle_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Circle;
            workArea.MouseMove -= WorkArea_Click_Brush;

        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Ellipse;
            workArea.MouseMove -= WorkArea_Click_Brush;
        }

        private void rect_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Rect;
            workArea.MouseMove -= WorkArea_Click_Brush;
        }

        private void square_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Square;
            workArea.MouseMove -= WorkArea_Click_Brush;
        }

        private void polygon_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = WorkArea_Click_Polygon;
            workArea.MouseMove -= WorkArea_Click_Brush;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentFiguresHandler = null;
            workArea.MouseMove += WorkArea_Click_Brush;
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
        }
       


        private void workArea_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositon = e.Location;
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

        private void workArea_MouseDown(object sender, MouseEventArgs e)
        {
            globalPen.Color = globalColor;
            isPressed = true;
        }

        private void workArea_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            globalPen.Width = trackBar1.Value;
        }
    }
}