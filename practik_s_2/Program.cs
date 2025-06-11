using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practik_s_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1

            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup\n");
            Console.WriteLine("---------------------------\n");

            //завдання 2

            Console.WriteLine("введіть перше число");
            string str1 = Console.ReadLine()!;
            Console.WriteLine("введіть друге число");
            string str2 = Console.ReadLine()!;
            Console.WriteLine("введіть третє число");
            string str3 = Console.ReadLine()!;
            Console.WriteLine("введіть четверте число");
            string str4 = Console.ReadLine()!;
            Console.WriteLine("введіть п'яте число");
            string str5 = Console.ReadLine()!;
            int a1 = int.Parse(str1);
            int a2 = int.Parse(str2);
            int a3 = int.Parse(str3);
            int a4 = int.Parse(str4);
            int a5 = int.Parse(str5);
            Console.WriteLine($"{a1} + {a2} + {a3} + {a4} + {a5} = {a1 + a2 + a3 + a4 + a5}");
            if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            {
                Console.WriteLine($"максимальне: {a1}");
            }
            else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            {
                Console.WriteLine($"максимальне: {a2}");
            }
            else if (a3 > a1 && a3 > a2 && a3 > a4 && a3 > a5)
            {
                Console.WriteLine($"максимальне: {a3}");
            }
            else if (a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            {
                Console.WriteLine($"максимальне: {a4}");
            }
            else if (a5 > a1 && a5 > a2 && a5 > a3 && a5 > a4)
            {
                Console.WriteLine($"максимальне: {a5}");
            }
            if (a1 < a2 && a1 < a3 && a1 < a4 && a1 < a5)
            {
                Console.WriteLine($"мінімальне: {a1}");
            }
            else if (a2 < a1 && a2 < a3 && a2 < a4 && a2 < a5)
            {
                Console.WriteLine($"мінімальне: {a2}");
            }
            else if (a3 < a1 && a3 < a2 && a3 < a4 && a3 < a5)
            {
                Console.WriteLine($"мінімальне: {a3}");
            }
            else if (a4 < a1 && a4 < a2 && a4 < a3 && a4 < a5)
            {
                Console.WriteLine($"мінімальне: {a4}");
            }
            else if (a5 < a1 && a5 < a2 && a5 < a3 && a5 < a4)
            {
                Console.WriteLine($"мінімальне: {a5}");
            }
            Console.WriteLine($"{a1} * {a2} * {a3} * {a4} * {a5} = {a1 * a2 * a3 * a4 * a5}\n");
            Console.WriteLine("---------------------------\n");

            //завдання 3

            Console.WriteLine("введіть перше число");
            str1 = Console.ReadLine()!;
            Console.WriteLine("введіть друге число");
            str2 = Console.ReadLine()!;
            Console.WriteLine("введіть третє число");
            str3 = Console.ReadLine()!;
            Console.WriteLine("введіть четверте число");
            str4 = Console.ReadLine()!;
            Console.WriteLine("введіть п'яте число");
            str5 = Console.ReadLine()!;
            int a = int.Parse(str1 + str2 + str3 + str4 + str5);
            Console.WriteLine(a);
            a1 = a % 10;
            a2 = a / 10 % 10;
            a3 = a / 100 % 10;
            a4 = a / 1000 % 10;
            a5 = a / 10000 % 10;
            Console.WriteLine($"{a1}{a2}{a3}{a4}{a5}\n");
            Console.WriteLine("---------------------------\n");

            //завдання 4

            Console.WriteLine("введіть початок діапазону");
            str1 = Console.ReadLine()!;
            Console.WriteLine("введіть кінець діапазону");
            str2 = Console.ReadLine()!;
            int start = int.Parse(str1);
            int end = int.Parse(str2);
            for (int i = start; i + start < end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------------------------\n");
            
            //завдання 5

            Console.WriteLine("введіть перше число");
            str1 = Console.ReadLine()!;
            Console.WriteLine("введіть друге число");
            str2 = Console.ReadLine()!;
            a1 = int.Parse(str1);
            a2 = int.Parse(str2);
            for (int i = a1; i <= a2; i++)
            {
                end = i;
                for (int j = 0; j < end; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------\n");

            //завдання 6

            int key;
            Console.WriteLine("введіть довжину лінії");
            str1 = Console.ReadLine()!;
            Console.WriteLine("введіть символ");
            str2 = Console.ReadLine()!;
            Console.WriteLine("введіть 1. горизонтальна лінія 2. вертикальна лінія");
            str3 = Console.ReadLine()!;
            a1 = int.Parse(str1);
            key = int.Parse(str3);
            if (key == 1)
            {
                for (int i = 0; i < a1; i++)
                {
                    Console.Write(str2);
                }
            }
            else if (key == 2)
            {
                for (int i = 0; i < a1; i++)
                {
                    Console.WriteLine(str2);
                }
            }
            else
            {
                Console.WriteLine($"в меню немає {key}");
            }
        }
    }
}
