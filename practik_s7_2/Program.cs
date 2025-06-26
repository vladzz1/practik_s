namespace practik_s7_2
{
    class _3D_Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public _3D_Point() : this(0, 0, 0) { }

        public _3D_Point(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            Z = z;
        }
        public override string ToString()
        {

            return $"X: {X}. Y : {Y}. Z : {Z}";
        }

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point() : this(0, 0) { }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {

            return $"X: {X}. Y : {Y}";
        }
        public override bool Equals(object? obj)
        {

            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
        // ref and out not allowed
        //public static return_type operator [symbol](parameters )
        //{
        //code
        //}
        #region Унарні оператори
        public static Point operator -(Point point)
        {
            Point res = new Point
            {
                X = -point.X,
                Y = -point.Y
            };
            return res;
        }
        public static Point operator ++(Point point)
        {
            //a++
            //a = a + 1
            point.X++;
            point.Y++;
            return point;
        }
        public static Point operator --(Point point)
        {
            point.X--;
            point.Y--;
            return point;
        }
        #endregion
        #region Бінарні оператори
        public static Point operator +(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator *(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        //==  < > != <= >=
        #region Оператори порівняння < >  <= >=
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X + p1.Y < p2.X + p2.Y;
        }
        //in pair
        public static bool operator >(Point p1, Point p2)
        {
            //return p1.X + p1.Y > p2.X + p2.Y;
            return !(p1 < p2);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return p1.X + p1.Y <= p2.X + p2.Y;
        }
        //in pair
        public static bool operator >=(Point p1, Point p2)
        {
            //return p1.X + p1.Y > p2.X + p2.Y;
            return !(p1 <= p2);
        }
        #endregion
        #region Оператори рівності ==, !=
        //public static bool operator ==(Point p1, Point p2)
        //{
        //    return p1.X == p2.X && p1.Y == p2.Y;
        //}
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        //in pair
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        #endregion
        #region true/false operators
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }
        //in pair
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }
        #endregion
        #region Overload types
        public static implicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static explicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static explicit operator _3D_Point(Point p)
        {
            return new _3D_Point(p.X, p.Y, 100);
        }
        #endregion
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;//int ---> int

            double b = 6.7;//double ---> double

            b = a;//int ---> double 5.0000000 implicit
            a = (int)b;//double  --> int 5  explicit

            Point p1 = new Point(5, 8);
            Point p2 = new Point(2, 4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            a = p1;//Point ---> int
            b = p2;
            _3D_Point newPoint = (_3D_Point)p1;//Point ---> _3D_Point
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("newPoint = " + newPoint);
            if (p1)
            {
                Console.WriteLine("P1 is True");
            }
            else
            {
                Console.WriteLine("P1 is False");
            }

            Console.WriteLine(a + b);
            //Console.WriteLine(p1 + p2);
            Point res = -p1;
            Console.WriteLine($"Point res {res}");
            Console.WriteLine($"Point p1 ++ {p1++}");
            Console.WriteLine($"Point p1 ++ {++p1}");
            Console.WriteLine($"Point p1 -- {--p1}");
            Console.WriteLine($"Point p1 -- {p1--}");

            Console.WriteLine($"Point p1 {p1}");
            Console.WriteLine($"Point p2 {p2}");
            res = p1 + p2;
            Console.WriteLine($"Point res {res}");
            res = p1 - p2;
            Console.WriteLine($"Point res {res}");
            res = p1 * p2;
            Console.WriteLine($"Point res {res}");
            res = p1 / p2;
            Console.WriteLine($"Point res {res}");

            //object obj = new object();
            //string str = new string(  "Hello");
            //string str2 = new string("Hello");

            //if (  str.Equals(str2))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");

            //if (p1.Equals(p2))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            if (p1 == p2)
                Console.WriteLine("True p1 == p2");
            else
                Console.WriteLine("False p1!= p2");

            if (p1 > p2)
                Console.WriteLine("True p1 > p2");
            else
                Console.WriteLine("False p1 < p2");
        }
    }
}
