namespace practik_s18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1

            int[] arr1 = { 21, -5, 2, 34, -45, -22, 33, 3, 6, -12 };
            var sort1Arr1 = from i in arr1 where i >= 0 orderby i select i;
            foreach (var i in sort1Arr1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            var sort2Arr1 = arr1.Where(i => i >= 0).OrderBy(i => i);
            foreach (var i in sort2Arr1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n------------------");

            //завдання 2

            int[] arr2 = { 21, 3, 2, -34, -30, -22, 6, -14, 6, 24, 45, -3 };
            var sort1Arr2 = (from i in arr2 where i >= 0 && i > 9 && i < 100 select i).Average();
            Console.WriteLine(sort1Arr2);
            var sort2Arr2 = arr2.Where(i => i >= 0 && i > 9 && i < 100).OrderBy(i => i);
            Console.WriteLine(sort1Arr2);
        }
    }
}
