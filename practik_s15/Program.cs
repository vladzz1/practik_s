namespace practik_s15
{
    internal class Program
    {
        static void writeFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }
        static void writeFile(string path, int[] content)
        {
            string text = "";
            for (int i = 0; i < content.Length; i++)
            {
                text += content[i] + " ";
            }
            File.WriteAllText(path, text);
        }
        static void writeFileNumbers(string path1, string path2, int[] content)
        {
            if (path1 == path2)
            {
                throw new Exception("посилання повинні бути різні");
            }
            string text1 = "";
            string text2 = "";
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] % 2 == 0)
                {
                    text1 += content[i] + " ";
                    count1++;
                }
                else
                {
                    text2 += content[i] + " ";
                    count2++;
                }
            }
            Console.WriteLine($"парних чисел: {count1}\nне парних чисел: {count2}");
            File.WriteAllText(path1, text1);
            File.WriteAllText(path2, text2);
        }
        static void readFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                throw new Exception($"файл: {path} не було знайдено");
            }
        }
        static string[] readFileArr(string path)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                string[] textArr = text.Split([' ', '!', '?', '.', ','], StringSplitOptions.RemoveEmptyEntries);
                return textArr;
            }
            else
            {
                throw new Exception($"файл: {path} не було знайдено");
            }
        }
        static void searchWord(string path, string word)
        {
            string[] text = readFileArr(path);
            int count = 0;
            int position = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == word)
                {
                    count++;
                    position = i + 1;
                    Console.WriteLine($"слово знайдено на позиції: {position}");
                }
            }
            Console.WriteLine($"кількість слів: {count}");
        }
        static void fileStatistics(string path)
        {
            string text = File.ReadAllText(path);
            string[] textArr = text.Split([' '], StringSplitOptions.RemoveEmptyEntries);
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            char[] word;
            for (int i = 0; i < textArr.Length; i++)
            {
                word = textArr[i].ToCharArray();
                if (word[word.Length - 1] == '.')
                {
                    count1++;
                }
                for (int j = 0; j < word.Length; j++)
                {
                    if (Char.IsUpper(word[j]))
                    {
                        count2++;
                    }
                    if (Char.IsLower(word[j]))
                    {
                        count3++;
                    }
                    if (word[j] == 'а' || word[j] == 'А' || word[j] == 'я' || word[j] == 'Я' || word[j] == 'о' || word[j] == 'О' || word[j] == 'у' || word[j] == 'У' || word[j] == 'ю' || word[j] == 'Ю' || word[j] == 'е' || word[j] == 'Е' || word[j] == 'є' || word[j] == 'Є' || word[j] == 'и' || word[j] == 'И' || word[j] == 'і' || word[j] == 'І' || word[j] == 'ї' || word[j] == 'Ї')
                    {
                        count4++;
                    }
                    if (word[j] == 'б' || word[j] == 'Б' || word[j] == 'в' || word[j] == 'г' || word[j] == 'Г' || word[j] == 'ґ' || word[j] == 'Ґ' || word[j] == 'д' || word[j] == 'Д' || word[j] == 'ж' || word[j] == 'Ж' || word[j] == 'з' || word[j] == 'З' || word[j] == 'к' || word[j] == 'К' || word[j] == 'л' || word[j] == 'Л' || word[j] == 'м' || word[j] == 'М' || word[j] == 'н' || word[j] == 'Н' || word[j] == 'п' || word[j] == 'П' || word[j] == 'р' || word[j] == 'Р' || word[j] == 'с' || word[j] == 'С' || word[j] == 'т' || word[j] == 'Т' || word[j] == 'ф' || word[j] == 'Ф' || word[j] == 'х' || word[j] == 'Х' || word[j] == 'ц' || word[j] == 'Ц' || word[j] == 'ч' || word[j] == 'Ч' || word[j] == 'ш' || word[j] == 'Ш' || word[j] == 'щ' || word[j] == 'Щ')
                    {
                        count5++;
                    }
                    if (Char.IsDigit(word[j]))
                    {
                        count6++;
                    }
                }
            }
            Console.WriteLine($"кількість речень: {count1}\nкількість великих літер: {count2}\nкількість маленьких літер: {count3}\nкількість голосних літер: {count4}\nкількість приголосних літер: {count5}\nкількість цифр: {count6}");
        }
        static void Main(string[] args)
        {
            writeFile("file_s15.txt", "hello");
            readFile("file_s15.txt");
            Console.WriteLine("\n-----------------------------");
            int[] arr1 = new int[5];
            Console.WriteLine("введіть 5 чисел");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine()!);
            }
            writeFile("file_s15.txt", arr1);
            readFile("file_s15.txt");
            Console.WriteLine("\n-----------------------------");
            string[] arr2 = readFileArr("file_s15.txt");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            Console.WriteLine("\n-----------------------------");
            int[] arr3 = new int[1000];
            Random random = new Random();
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = random.Next(10, 51);
            }
            writeFileNumbers("file_number1_s15.txt", "file_number2_s15.txt", arr3);
            Console.WriteLine("\n-----------------------------");
            string str = "Пошук кількості 23 слова у файл. Відображає кількість знайденого слова. Пошук заданого слова у порядку. Наприклад, шукає слово. Це означає, що шукає слово 256 у напрямку. За результатами пошуку, відображає кількість.";
            writeFile("file_s15.txt", str);
            searchWord("file_s15.txt", "кількість");
            Console.WriteLine("\n-----------------------------");
            fileStatistics("file_s15.txt");
        }
    }
}
