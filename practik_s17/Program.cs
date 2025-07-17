using System.Text.RegularExpressions;

namespace practik_s17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("file_s17", "якого 34.22 символу 22 / 4 23.2 - 22 - 45.7 всі дробові 2.332 або 15.1");
            string text = File.ReadAllText("file_s17");
            MatchCollection coll1 = Regex.Matches(text, @"\d+\.\d+|\d+\,\d+");
            foreach (Match item in coll1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n---------------------------");
            MatchCollection coll2 = Regex.Matches(text, @"\d+");
            foreach (Match item in coll2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n---------------------------");
            Console.Write("введіть email: ");
            string str = Console.ReadLine()!;
            Regex regex = new Regex(@"^([\w]|[\.]|[\-]){4}\@([a-z]|[A-Z]|[0-9]){2,}\.([a-z]|[A-Z]|[0-9]){2,}$");
            if (regex.IsMatch(str))
            {
                Console.WriteLine("email правильний");
            }
            else
            {
                Console.WriteLine("email не правильний");
            }
        }
    }
}
