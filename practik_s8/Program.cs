using System;
using System.Drawing;

namespace practik_s8
{
    abstract class GeometricFigure : FoldedFigure
    {
        public abstract void GetArea();
        public abstract void GetPerimeter();
    }
    class Triangle : GeometricFigure
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int c;
        public int C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Triangle()
        {
            A = B = C = 1;
        }
        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу трикутниуа");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр трикутниуа");
        }
        public override string ToString()
        {
            return $"a = {A}, b = {B}, c = {C}";
        }
    }
    class Square : GeometricFigure
    {
        private int side;
        public int Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                {
                    side = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Square()
        {
            Side = 1;
        }
        public Square(int side)
        {
            Side = side;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу квадрата");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр квадрата");
        }
        public override string ToString()
        {
            return $"side = {Side}";
        }
    }
    class Romb : GeometricFigure
    {
        private int side;
        public int Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                {
                    side = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int diagonal;
        public int Diagonal
        {
            get { return diagonal; }
            set
            {
                if (value > 0)
                {
                    diagonal = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Romb()
        {
            side = diagonal = 1;
        }
        public Romb(int side, int diagonal)
        {
            Side = side;
            Diagonal = diagonal;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу ромба");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр ромба");
        }
        public override string ToString()
        {
            return $"side = {Side}, diagonal = {Diagonal}";
        }
    }
    class Rectangle : GeometricFigure
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Rectangle()
        {
            A = B = 1;
        }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу прямокутника");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр прямокутника");
        }
        public override string ToString()
        {
            return $"a = {A}, b = {B}";
        }
    }
    class Parallelogram : GeometricFigure
    {
        private int a;
        public int A
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int b;
        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int c;
        public int C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int d;
        public int D
        {
            get { return d; }
            set
            {
                if (value > 0)
                {
                    d = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Parallelogram()
        {
            A = B = 1;
            C = D = 2;
        }
        public Parallelogram(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу паралелограма");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр паралелограма");
        }
        public override string ToString()
        {
            return $"a = {A}, b = {B}, c = {C}, d = {D}";
        }
    }
    class Trapeze : GeometricFigure
    {
        private int downside;
        public int Downside
        {
            get { return downside; }
            set 
            {
                if (value > 0)
                {
                    downside = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int sides;
        public int Sides
        {
            get { return sides; }
            set
            {
                if (value > 0)
                {
                    sides = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private int topSide;
        public int TopSide
        {
            get { return topSide; }
            set
            {
                if (value > 0)
                {
                    topSide = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Trapeze()
        {
            Downside = 3;
            Sides = 2;
            TopSide = 1;
        }
        public Trapeze(int downside, int sides, int topSide)
        {
            Downside = downside;
            Sides = sides;
            TopSide = topSide;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу трапеції");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр трапеції");
        }
        public override string ToString()
        {
            return $"downside = {Downside}, sides = {Sides}, top side = {TopSide}";
        }
    }
    class Circle : GeometricFigure
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set 
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Circle()
        {
            Radius = 1;
        }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу кола");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр кола");
        }
        public override string ToString()
        {
            return $"radius = {Radius}";
        }
    }
    class Ellipse : GeometricFigure
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Ellipse()
        {
            Radius = 1;
        }
        public Ellipse(int radius)
        {
            Radius = radius;
        }
        public override void GetArea()
        {
            Console.WriteLine("шукаю площу еліпса");
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("шукаю периметр еліпса");
        }
        public override string ToString()
        {
            return $"radius = {Radius}";
        }
    }
    class FoldedFigure
    {
        public GeometricFigure[]? Figures { get; set; }
        public FoldedFigure(params GeometricFigure[] figures)
        {
            for (int i = 0; i < Figures?.Length; i++)
            {
                Figures[i] = figures[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(2, 5, 6);
            FoldedFigure[] ge = { tr, new Square(4), new Romb(2, 4), new Rectangle(3, 5), new Parallelogram(3, 5, 2, 5) };
            for (int i = 0; i < ge.Length; i++)
            {
                Console.WriteLine(ge[i]);
            }
        }
    }
}
