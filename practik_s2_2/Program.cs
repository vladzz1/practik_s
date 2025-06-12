namespace practik_s2_2
{
    internal class Program
    {
        static void printArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            //завдання 1

            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(10);
            }
            printArr(arr1);
            Console.WriteLine();
            int min1 = arr1[0];
            int max1 = arr1[0];
            int num_uni = 0;
            int count;
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
                count = 0;
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] != arr1[j] && i != j)
                    {
                        count++;
                    }
                }
                if (count == 9)
                {
                    num_uni++;
                }
            }
            Console.WriteLine($"мінімальне число: {min1}");
            Console.WriteLine($"максимальне число: {max1}");
            Console.WriteLine($"унікальних чисел: {num_uni}\n-------------------------\n");

            //завдання 2

            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(10);
            }
            printArr(arr2);
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
            Console.WriteLine($"кількість чисел менших за {number}: {count}\n-------------------------\n");

            //завдання 3

            int[] A = new int[5];
            double[,] B = new double[3, 4];
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{i + 1} введіть число: ");
                A[i] = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.Next(10, 51) + random.NextDouble();
                    B[i, j] = Math.Round(B[i, j], 2);
                }
            }
            printArr(A);
            Console.WriteLine();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------\n");

            //завдання 4

            int[,] matrix1 = new int[5, 5];
            count = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = random.Next(-100, 101);
                }
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    count += matrix1[i, j];
                }
            }
            Console.WriteLine($"сума всіх елементів матриці: {count}\n-------------------------\n");

            //завдання 5

            count = 0;
            int min2 = matrix1[0, 0];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] < min2)
                    {
                        min2 = matrix1[i, j];
                    }
                }
            }
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] == min2 + 5)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"кількість елементів що відрізняються від мінімального на 5: {count}");
        }
    }
}
