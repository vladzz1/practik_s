using System.Text;
using System.Xml.Linq;

namespace practik_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello");
            //cw + tab
            Console.WriteLine("Hello\n");
            Console.WriteLine("\tHello\n");
            Console.WriteLine("\t\tHello\n");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");

            object obj = new object();
            //Int32 a = 16;
            int a = 16;
            int b = 4;
            Console.WriteLine(b);

            short d = 41;
            Single g = 1.33f;//double ---> float
            float h = 8.23F;

            double pi = 3.14;
            double g2 = 8.8;

            decimal p = 5.54m;

            Console.WriteLine("enter number: ");
            string str = Console.ReadLine()!;//100
            Console.WriteLine(str + "!!!!");
            Console.WriteLine(str + 10 + "!!!!");
            int number = int.Parse(str);
            Console.WriteLine(number + 10 + "!!!!");
            Console.WriteLine("you entered: " + number + "!!!!");
            Console.WriteLine("you entered: " + number + 100 + " !!!!");
            Console.WriteLine("you entered: " + (number + 100) + " !!!!");
            Console.WriteLine($"you entered:  + {number + 100} + !!!!");
            //not null - value types
            int v;
            int u = 0;
            //Nullable<int> y = null;
            int? y = null;
            //NULLable
            string word = null;
            string word2 = "hello world";

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("привіт світ");

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Random random = new Random();
            for (short i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(10, 100));
                Console.WriteLine(random.Next(100));
                Console.WriteLine(random.Next(100, 500));
                Console.WriteLine(random.NextDouble());
            }

            Console.WriteLine(random.Next());//0....maxInt
            Console.WriteLine(random.Next(100));//0....99
            Console.WriteLine(random.Next(100, 500));//100....499
            Console.WriteLine(random.NextDouble());//0....1

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();

            Console.WriteLine((10).GetType());
            Console.WriteLine((10D).GetType());
            Console.WriteLine((10f).GetType());
            Console.WriteLine((10m).GetType());
            Console.WriteLine((10L).GetType());
            Console.WriteLine((10UL).GetType());
            Console.WriteLine(0xFF);

            Console.WriteLine($"ToShortTimeString : {now.ToShortTimeString()}");
            Console.WriteLine($"ToShortDateString : {now.ToShortDateString()}");
            Console.WriteLine($"ToLongTimeString : {now.ToLongTimeString()}");
            Console.WriteLine($"ToLongDateString : {now.ToLongDateString()}");
            Console.WriteLine($"Custom : {now.ToString("yyyy/MM/dd")}");

            //int a = 5;
            ////implicit
            //float d = a;//5.0000000
            ////explicit
            //int b = (int)3.14;
            ////Nullable<int> num2 = null;
            ////or
            //int? num2 = null;

            //string str = null;
            //string str3 = "Hello";
            //string str2 = str;

            //if (str != null)
            //    str.ToUpper();
            ////or   ---> ? - not null //? - null-conditional operator
            //str?.ToLower();

            //str2 = (str == null ? "Error" : str);
            ////or
            //if (str == null)
            //{
            //    str2 = "Error";
            //}
            //else
            //{
            //    str2 = str;
            //}
            ////or  //?? - null-conditional operator
            //str2 = str ?? "Error";

            //explicit
            //int i2 = (int)f2;

            //try
            //{
            //    numberStr = Console.ReadLine();
            //    float float_number = Convert.ToSingle(numberStr);
            //    Console.WriteLine($"Number float {numberStr}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Continue...............");
            //Console.WriteLine("Continue...............");
            //Console.WriteLine("Continue...............");
            //Console.WriteLine("Continue...............");
        }
    }
}
