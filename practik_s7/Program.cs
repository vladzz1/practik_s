namespace practik_s7
{
    class Square
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("error: сторона має бути додатньою");
                }
            }
        }
        public Square()
        {
            A = 1;
        }
        public Square(int a)
        {
            A = a;
        }
        public override string ToString()
        {
            return $"a = {A}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Square square && A == square.A;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A);
        }
        public static Square operator ++(Square square)
        {
            square.A++;
            return square;
        }
        public static Square operator --(Square square)
        {
            square.A--;
            return square;
        }
        public static Square operator +(Square square1, Square square2)
        {
            Square res = new Square
            {
                A = square1.A + square2.A
            };
            return res;
        }
        public static Square operator -(Square square1, Square square2)
        {
            Square res = new Square
            {
                A = square1.A - square2.A
            };
            return res;
        }
        public static Square operator *(Square square1, Square square2)
        {
            Square res = new Square
            {
                A = square1.A * square2.A
            };
            return res;
        }
        public static Square operator /(Square square1, Square square2)
        {
            if (square2.A == 0)
            {
                throw new DivideByZeroException();
            }
            Square res = new Square
            {
                A = square1.A / square2.A
            };
            return res;
        }
        public static bool operator <(Square square1, Square square2)
        {
            return square1.A < square2.A;
        }
        public static bool operator >(Square square1, Square square2)
        {
            return square1.A > square2.A;
        }
        public static bool operator <=(Square square1, Square square2)
        {
            return square1.A <= square2.A;
        }
        public static bool operator >=(Square square1, Square square2)
        {
            return square1.A >= square2.A;
        }
        public static bool operator ==(Square square1, Square square2)
        {
            return square1.Equals(square2);
        }
        public static bool operator !=(Square square1, Square square2)
        {
            return !(square1 == square2);
        }
        public static bool operator true(Square square)
        {
            return square.A != 0;
        }
        public static bool operator false(Square square)
        {
            return square.A == 0;
        }
        public static implicit operator Rectangle(Square square)
        {
            return new Rectangle(square.A, square.A);
        }
        public static implicit operator int(Square square)
        {
            return square.A;
        }
    }
    class Rectangle
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
                else
                {
                    throw new Exception("error: сторона має бути додатньою");
                }
            }
        }
        private int b;
        public int B
        {
            get { return a; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
                else
                {
                    throw new Exception("error: сторона має бути додатньою");
                }
            }
        }
        public Rectangle()
        {
            A = 1;
            B = 1;
        }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
        public override string ToString()
        {
            return $"a = {A}, b = {B}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle && A == rectangle.A && B == rectangle.B;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }
        public static Rectangle operator ++(Rectangle rectangle)
        {
            rectangle.A++;
            rectangle.B++;
            return rectangle;
        }
        public static Rectangle operator --(Rectangle rectangle)
        {
            rectangle.A--;
            rectangle.B--;
            return rectangle;
        }
        public static Rectangle operator +(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle res = new Rectangle
            {
                A = rectangle1.A + rectangle2.A,
                B = rectangle1.B + rectangle2.B
            };
            return res;
        }
        public static Rectangle operator -(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle res = new Rectangle
            {
                A = rectangle1.A - rectangle2.A,
                B = rectangle1.B - rectangle2.B
            };
            return res;
        }
        public static Rectangle operator *(Rectangle rectangle1, Rectangle rectangle2)
        {
            Rectangle res = new Rectangle
            {
                A = rectangle1.A * rectangle2.A,
                B = rectangle1.B * rectangle2.B
            };
            return res;
        }
        public static Rectangle operator /(Rectangle rectangle1, Rectangle rectangle2)
        {
            if (rectangle2.A == 0 || rectangle2.B == 0)
            {
                throw new DivideByZeroException();
            }
            Rectangle res = new Rectangle
            {
                A = rectangle1.A / rectangle2.A,
                B = rectangle1.B / rectangle2.B
            };
            return res;
        }
        public static bool operator <(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.A + rectangle1.B < rectangle2.A + rectangle2.B;
        }
        public static bool operator >(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.A + rectangle1.B > rectangle2.A + rectangle2.B;
        }
        public static bool operator <=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.A + rectangle1.B <= rectangle2.A + rectangle2.B;
        }
        public static bool operator >=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.A + rectangle1.B >= rectangle2.A + rectangle2.B;
        }
        public static bool operator ==(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Equals(rectangle2);
        }
        public static bool operator !=(Rectangle rectangle1, Rectangle rectangle2)
        {
            return !(rectangle1 == rectangle2);
        }
        public static bool operator true(Rectangle rectangle)
        {
            return rectangle.A != 0 || rectangle.B != 0;
        }
        public static bool operator false(Rectangle rectangle)
        {
            return rectangle.A == 0 && rectangle.B == 0;
        }
        public static explicit operator Square(Rectangle rectangle)
        {
            return new Square(rectangle.A);
        }
        public static explicit operator int(Rectangle rectangle)
        {
            return rectangle.A + rectangle.B;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
