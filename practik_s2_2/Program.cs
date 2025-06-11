namespace practik_s2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //завдання 1

            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(10);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            int min1 = arr1[0];
            int max1 = arr1[0];
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min1)
                {
                    min1 = arr1[i];
                }
                if (arr1[i] > max1)
                {
                    max1 = arr1[i];
                }
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine($"унікальних чисел: {count}\n-------------------------\n");

            //завдання 2

            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(10);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.Write("\nвведіть число: ");
            int number = int.Parse(Console.ReadLine()!);
            count = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < number)
                {
                    count++;
                }
            }
            Console.WriteLine($"кількість чисел менших за {number}: {count}");
        }
    }
}
