using System.Collections.Immutable;

namespace practik_s11
{
    public delegate void mainMenuDelegate();
    class Arr
    {
        public int[]? Array { get; set; }
        public Arr()
        {
            Array = new int[10];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-9, 10);
            }
        }
        public Arr(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException();
            }
            Array = new int[size];
            Random random = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(-9, 10);
            }
        }
        public void mainMenu()
        {
            showArr(Array!);
            Console.WriteLine("1. обчислення значення\n2. зміна масиву");
            int key = int.Parse(Console.ReadLine()!);
            if (key == 1)
            {
                Console.WriteLine(valueCalculation());
            }
            else if (key == 2)
            {
                arrayChange();
                showArr(Array!);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public int valueCalculation()
        {
            Console.WriteLine("1. обчислити кількість негативних елементів\n2. визначити суму всіх елементів");
            int key = int.Parse(Console.ReadLine()!);
            if (key == 1)
            {
                int count = 0;
                for (int i = 0; i < Array!.Length; i++)
                {
                    if (Array[i] < 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            else if (key == 2)
            {
                int count = 0;
                for (int i = 0; i < Array!.Length; i++)
                {
                    count += Array[i];
                }
                return count;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void arrayChange()
        {
            Console.WriteLine("1. змінити всі негативні елементи на 0\n2. відсортувати масив");
            int key = int.Parse(Console.ReadLine()!);
            if (key == 1)
            {
                for (int i = 0; i < Array!.Length; i++)
                {
                    if (Array[i] < 0)
                    {
                        Array[i] = 0;
                    }
                }
            }
            else if (key == 2)
            {
                for (int i = 0; i < Array!.Length - 1; i++)
                {
                    for (int j = 0; j < Array!.Length - i - 1; j++)
                    {
                        if (Array[j] > Array[j + 1])
                        {
                            int temp = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = temp;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void showArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Arr arr = new Arr();
                mainMenuDelegate mainMenu = arr.mainMenu;
                mainMenu();
            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
