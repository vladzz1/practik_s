namespace practik_s5_2
{
    partial struct MyStruct
    {
        //public
        public int MyProperty { get; set; }
    }
    partial struct MyStruct
    {
        public int MyProperty1 { get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X = {X}. Y = {Y}";
        }
    }
    struct Time
    {
        public int H { get; set; }
        public int M { get; set; }
        public int S { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            static void MethodWithParams(string name, params int[] marks)
            {

                Console.WriteLine("------------- " + name + " --------------");
                foreach (var mark in marks)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
            static void Modify(ref int num, ref string str, ref Point point)
            {
                num += 1;
                str += "!!!";
                point.X++;
                point.Y++;
            }
            static void GetCurrentTime(out int hour, out int minute, out int second)
            {
                hour = DateTime.Now.Hour;
                minute = DateTime.Now.Minute;
                second = DateTime.Now.Second;
                //return hour + minute + second;          
            }
            static void Main(string[] args)
            {
                Point point1 = new Point(); //new - create dynamic memory

                Time time = new Time();//invoke default constructor

                Point point2;
                Time t;
                int a;



                // Out 
                int h = 0, m = 0, s = 0;
                //Console.WriteLine($"{h}:{m}:{s}");
                GetCurrentTime(out h, out m, out s);
                //GetCurrentTime(out int h,out int m, out int s);
                Console.WriteLine($"{h}:{m}:{s}");



                //Ref - references  ( ref == & )
                int num = 10;
                string str = "Hello academy";
                Point point = new Point() { X = 10, Y = 15 };
                Console.WriteLine($"Num = {num}");
                Console.WriteLine($"Str = {str}");
                Console.WriteLine($"Point  {point}");
                Modify(ref num, ref str, ref point);
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Num = {num}");
                Console.WriteLine($"Str = {str}");
                Console.WriteLine($"Point  {point}");



                //MethodWithParams
                //int[] marks = { 11, 10, 8, 5, 6, 7, 4, 1 };
                //MethodWithParams("Olga", marks);
                //MethodWithParams("Petro", [7, 7, 7, 7, 7, 7, 7, 7]);
                //MethodWithParams("Bob", 11,11,11,11,11,11,11,12,12);
                //new CompositeFigures(new Cycle(), new Rec(), new Square());
                //Point point = new Point();
                //point.X = 1;    
                //point.Y = 2;
                //Console.WriteLine($"X : {point.X}, Y : {point.Y}");

                //_2D_Object.Point p = new _2D_Object.Point();
                //p.X = 10; 
                //p.Y =10;
                //p.Z = 10;
            }
        }
    }
}

namespace _2D_Object
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
}