using System.Text;

namespace practik_s3
{
    internal class Program
    {
        static void printArr(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static void printArr(string array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //завдання 1

            string str1 = "вставити в задану позицію";
            string str2 = "рядка інший рядок ";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            str1 = str1.Insert(9, str2);
            Console.WriteLine(str1);
            Console.WriteLine("------------------------\n");

            //завдання 2

            Console.Write("введіть слово: ");
            string str3 = Console.ReadLine()!;
            char[] str4 = str3.ToCharArray();
            string reverse = "";
            for (int i = str4.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str4[i];
            }
            if (reverse == str3)
            {
                Console.WriteLine($"\"{str3}\" це паліндром");
            }
            else
            {
                Console.WriteLine($"\"{str3}\" це не паліндром");
            }
            Console.WriteLine("------------------------\n");

            //завдання 3

            string str5 = "Відсоткове ВіДноШення малиХ і вЕликих лІтеР до ЗагаЛьноЇ";
            char[] str6 = str5.ToCharArray();
            int nam_of_upper = 0;
            int nam_of_lower = 0;
            for (int i = 0; i < str6.Length; i++)
            {
                if (Char.IsUpper(str6[i]))
                {
                    nam_of_upper++;
                }
                if (Char.IsLower(str6[i]))
                {
                    nam_of_lower++;
                }
            }
            double inte_upper = nam_of_upper * 100 / str6.Length;
            double inte_lower = nam_of_lower * 100 / str6.Length;
            Console.WriteLine(str5);
            Console.WriteLine($"великих букв: {inte_upper}%, маленьких букв: {inte_lower}%\n------------------------\n");

            //завдання 4

            string[] arr_str = { "останні", "символ", "мають", "масив", "слів", "обрану", "довжину" };
            Console.Write("введіть довжину слова: ");
            int length = int.Parse(Console.ReadLine()!);
            printArr(arr_str);
            for (int i = 0; i < arr_str.Length; i++)
            {
                if (arr_str[i].Length == length)
                {
                    arr_str[i] = arr_str[i].Substring(0, length - 3);
                    arr_str[i] += '$';
                }
            }
            printArr(arr_str);
            Console.WriteLine("------------------------\n");

            //завдання 5

            string str7 = "1.стоїть 2.тексті 3.вивести 4.його 5.відношення 6.малих";
            char[] str8 = str7.ToCharArray();
            printArr(str7);
            Console.Write("введіть номер слова: ");
            char number = char.Parse(Console.ReadLine()!);
            for (int i = 0; i < str8.Length; i++)
            {
                if (str8[i] == number)
                {
                    Console.WriteLine(str8[i + 2]);
                }
                
            }
            Console.WriteLine("------------------------\n");

            //завдання 6

            string str9 = "   розділених пробілами кілька пробілів слова були ";
            printArr(str9);
            str9 = str9.Trim(new char[] { ' ' });
            string[] words = str9.Split(new char[] { ' ' });
            string str10 = string.Join('*', words);
            printArr(str10);
            Console.WriteLine("------------------------\n");

            //завдання 7

            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                Console.Write("введіть слово: ");
                stringBuilder.Append(Console.ReadLine()!);
                if (stringBuilder[stringBuilder.Length - 1] == '.')
                {
                    break;
                }
                stringBuilder.Append(", ");
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
