namespace practik_s11_2
{
    //public class VoidDelegate :  MulticastDelegate :Delegate
    //{
    //    public MyDelegate()
    //    {
    //    }
    //}

    public delegate int IntDelegate(double a);

    public delegate void SetStringDelegate(string s);
    public delegate double DoubleDelegate();
    public delegate void VoidDelegate();
    class SuperClass
    {
        public void Print(string str)//proptype 
        {
            Console.WriteLine("String : " + str);
        }
        public static double GetKoef()
        {
            return new Random().NextDouble();
        }
        public double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("Doing some work");
        }
        public void Test()
        {
            Console.WriteLine("Testing");
        }
    }
    public delegate double CalculatorDelegate(double a, double b);
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Multy(double a, double b)
        {
            return a * b;
        }
        public double Div(double a, double b)
        {
            return a / b;
        }
    }
    public delegate int ChangeDelegate(int a);
    internal class Program
    {
        public static void DoOperation(double a, double b, CalculatorDelegate operation)
        {
            Console.WriteLine(operation.Invoke(a, b));
        }
        static void ChangeArr(int[] arr, ChangeDelegate change)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = change(arr[i]);
            }
        }
        static int SQRT(int n)
        {
            return n * n;
        }
        static int Increment(int n)
        {
            return ++n;
        }
        //--------------1----------
        //static int Decrement(int n)
        //{
        //    return --n;
        //}
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            foreach (int i in arr) Console.Write(i + " ");
            ChangeArr(arr, SQRT);
            Console.WriteLine();
            foreach (int i in arr) Console.Write(i + " ");

            ChangeArr(arr, Increment);
            Console.WriteLine();
            foreach (int i in arr) Console.Write(i + " ");
            //anonymus delegate -------- 2 ---------
            //ChangeArr(arr, delegate (int n) { return --n; });
            //lambda expresion  ---------- 3 --------- 
            ChangeArr(arr, (n) => --n);
            Console.WriteLine();
            foreach (int i in arr) Console.Write(i + " ");

            //Calculator calculator = new Calculator();
            //CalculatorDelegate calcDelegate = calculator.Add;
            //calcDelegate += calculator.Sub;
            //calcDelegate += calculator.Multy;
            //calcDelegate += calculator.Div;
            //calcDelegate -= calculator.Div;
            //foreach (var d in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(((CalculatorDelegate)d).Invoke(100,2));
            //}

            //DoOperation(100, 5, calculator.Add);
            //DoOperation(100, 5, calculator.Sub);
            //DoOperation(100, 5, calculator.Multy);
            /*
            Calculator calculator = new Calculator();
            double x, y;
            int key;
            do
            {
                CalculatorDelegate calcDelegate = null;
                Console.WriteLine("Enter first number ");
                x = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter second number ");
                y = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Add  - 1 ");
                Console.WriteLine("Sub  - 2 ");
                Console.WriteLine("Mult  - 3 ");
                Console.WriteLine("Divide  - 4 ");
                Console.WriteLine("Exit  - 0 ");
                key = int.Parse(Console.ReadLine()!);
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalculatorDelegate(calculator.Add);
                        break;
                    case 2:
                        calcDelegate = new CalculatorDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multy;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good  Buy");
                        break;
                    default:
                        Console.WriteLine("Error choice......");
                        break;
                }

                Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            } while (key != 0);
            */
            Console.WriteLine("..........................");
            // SuperClass superClass = new SuperClass();
            // //superClass.Print("Hello");

            // //Console.WriteLine(SuperClass.GetKoef()); 
            // //DoubleDelegate deleg = new DoubleDelegate(SuperClass.GetKoef);
            // DoubleDelegate deleg =  SuperClass.GetKoef;

            // Console.WriteLine(SuperClass.GetKoef());;

            // Console.WriteLine(deleg?.Invoke());
            // Console.WriteLine(deleg());

            //DoubleDelegate[] doubleDelegate = new DoubleDelegate[2] {
            //     SuperClass.GetKoef,
            //     superClass.GetNumber
            //};

            // Console.WriteLine(doubleDelegate[0]?.Invoke());
            // Console.WriteLine(doubleDelegate[1]?.Invoke());

            // SetStringDelegate setString = new SetStringDelegate(superClass.Print);
            // setString.Invoke("Hello");

            // VoidDelegate voidDelegate = superClass.DoWork;
            // voidDelegate.Invoke();

            // //voidDelegate = superClass.Test;
            // //voidDelegate.Invoke();
            // Console.WriteLine("----------- Multydelegates------------- ");
            // //Delegate.Combine(voidDelegate, new VoidDelegate(superClass.Test));
            // //voidDelegate += new VoidDelegate(superClass.Test);
            // voidDelegate += superClass.Test;

            // foreach (var item in voidDelegate.GetInvocationList())
            // {
            //     (item as VoidDelegate)?.Invoke();
            // }
            // Console.WriteLine("---------------------------");
            // voidDelegate.Invoke();
        }
    }
}
