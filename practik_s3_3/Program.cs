using System.Text;

namespace practik_s3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            str += "word ";
            Console.WriteLine(str);

            StringBuilder stringBuilder = new StringBuilder();
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);
            stringBuilder.Append("Hello");
            stringBuilder.Append("Hello");
            stringBuilder.Append("Hello");
            stringBuilder.Append("Hello");
            Console.WriteLine("Length : " + stringBuilder.Length);
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);

            stringBuilder.AppendLine("Hello");
            stringBuilder.Append("Hello");
            stringBuilder.Append("Hello");
            stringBuilder.Append("Hello");
            Console.WriteLine("Length : " + stringBuilder.Length);
            Console.WriteLine("Capacity : " + stringBuilder.Capacity);
            Console.WriteLine(stringBuilder);
            string str3 = "This is testing";
            if (str3.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }
        }
    }
}
