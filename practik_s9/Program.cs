namespace practik_s9
{
    interface IOutput
    {
        void show();
        void show(string info);
    }
    interface IMath
    {
        int max();
        int min();
        float avg();
        bool search(int valueToSearch);
    }
    interface ISort
    {
        void sortAsc();
        void sortDesc();
        void sortByParam(bool isAsc);
    }
    class Array : IOutput, IMath, ISort
    {
        public int[]? Arr { get; set; }
        public Array()
        {
            Arr = new int[10];
            Random random = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(0, 10);
            }
        }
        public Array(int size)
        {
            Arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = random.Next(0, 10);
            }
        }
        public float avg()
        {
            int count = 0;
            for (int i = 0; i < Arr!.Length; i++)
            {
                count += Arr[i];
            }
            return count / Arr.Length;
        }
        public int max()
        {
            int count = Arr![0];
            for (int i = 0; i < Arr!.Length; i++)
            {
                if (Arr[i] > count)
                {
                    count = Arr[i];
                }
            }
            return count;
        }
        public int min()
        {
            int count = Arr![0];
            for (int i = 0; i < Arr!.Length; i++)
            {
                if (Arr[i] < count)
                {
                    count = Arr[i];
                }
            }
            return count;
        }
        public bool search(int valueToSearch)
        {
            for (int i = 0; i < Arr!.Length; i++)
            {
                if (Arr[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
        public void show()
        {
            for (int i = 0; i < Arr?.Length; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
            Console.WriteLine();
        }
        public void show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < Arr?.Length; i++)
            {
                Console.Write($"{Arr[i]} ");
            }
            Console.WriteLine();
        }
        public void sortAsc()
        {
            for (int i = 0; i < Arr!.Length - 1; i++)
            {
                for (int j = 0; j < Arr!.Length - i - 1; j++)
                {
                    if (Arr[j] > Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
        }
        public void sortDesc()
        {
            for (int i = 0; i < Arr!.Length - 1; i++)
            {
                for (int j = 0; j < Arr!.Length - i - 1; j++)
                {
                    if (Arr[j] < Arr[j + 1])
                    {
                        int temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                    }
                }
            }
        }
        public void sortByParam(bool isAsc)
        {
            if(isAsc == true)
            {
                sortAsc();
            }
            else
            {
                sortDesc();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.show();
            arr.show("ще один масив");
            Console.WriteLine(arr.max());
            Console.WriteLine(arr.min());
            Console.WriteLine(arr.avg());
            Console.WriteLine(arr.search(4));
            arr.sortAsc();
            arr.show();
            arr.sortDesc();
            arr.show();
            arr.sortByParam(true);
            arr.show();
        }
    }
}
