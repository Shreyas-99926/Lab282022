namespace PointLab
{
    internal class Point
    {
        int x;
        int y;

        public void Initialize(int X, int Y)
        {
            setX(x);
            setY(y);
        }

        public void setX(int X)
        {
            this.x = X;
        }
        public void setY(int Y)
        {
            this.y = Y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public void Translate(int xOffset, int yOffset)
        {
            this.x += xOffset;
            this.y += yOffset;
        }
        public void Scale(int a)
        {
            this.x *= a;
            this.y *= a;
        }
        public double Distance(Point p)
        {
            //double Value = 0;
            return Math.Sqrt((this.x - p.x) * (this.x - p.x) + (this.y - p.y) * (this.y - p.y));
            //return Value;
        }

        static void Main()
        {
            Point p = new Point();
            Point p1 = new Point();

            p.Initialize(2, 3);
            p.Translate(2, 3);
            p.Scale(2);
            p1.Initialize(2, 3);
            double Value = p.Distance(p1);
            //int x, y;
            // Value = p.Distance(p1);
            int x = p.getX();
            int y = p.getY();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Value);

        }
    }

}