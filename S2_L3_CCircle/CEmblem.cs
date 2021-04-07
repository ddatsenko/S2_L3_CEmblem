using System.Drawing;
using System.Drawing.Drawing2D;

namespace S2_L3_CCircle
{
    class CEmblem
    {
        const int DefaultRadius = 50;
        private Graphics graphics; private int _radius;
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }

        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }

        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }

        private void Draw(Pen pen)
        {
            Rectangle rectangle = new Rectangle(X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            using (GraphicsPath myPath2 = new GraphicsPath())
            {
                myPath2.AddLines(new[]
                {
                    new Point(rectangle.X - Radius / 2, rectangle.Y + (rectangle.Height / 2)),
                    new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y - Radius / 2),
                    new Point(rectangle.X + rectangle.Width + Radius / 2, rectangle.Y + (rectangle.Height / 2)),
                    new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y + rectangle.Height + Radius / 2),
                    new Point(rectangle.X - Radius / 2, rectangle.Y + (rectangle.Height / 2)),
                });
                graphics.DrawPath(pen, myPath2);
            }

            using (GraphicsPath myPath1 = new GraphicsPath())
                {
                myPath1.AddLines(new[]
                {
                    new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2)),
                    new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y),
                    new Point(rectangle.X + rectangle.Width, rectangle.Y + (rectangle.Height / 2)),
                    new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y + rectangle.Height),
                    new Point(rectangle.X, rectangle.Y + (rectangle.Height / 2))
                });
                graphics.DrawPath(pen, myPath1);
            }

            graphics.DrawEllipse(pen, rectangle);
        }

        public void Show()
        {
            Draw(Pens.Red);
        }

        public void Hide()
        {
            Draw(Pens.White);
        }
        public void Expand()
        {
            Hide();
            Radius++;
            Show();
        }
        public void Expand(int dR)
        {
            Hide();
            Radius = Radius + dR;
            Show();
        }
        public void Collapse()
        {
            Hide();
            Radius--;
            Show();
        }

        public void Collapse(int dR)
        {
            Hide();
            Radius = Radius - dR;
            Show();
        }
        public void Move(int dX, int dY)
        {
            Hide();
            X = X + dX;
            Y = Y + dY;
            Show();
        }
    }
}