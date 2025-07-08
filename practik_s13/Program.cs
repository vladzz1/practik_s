namespace practik_s13
{
    class PhoneBook
    {
        private Dictionary<string, int> phoneBook;
        public PhoneBook()
        {
            phoneBook = new Dictionary<string, int>();
        }
        public void addPhone(string key, int phone)
        {
            if (!phoneBook.ContainsKey(key))
            {
                phoneBook.Add(key, phone);
            }
            else
            {
                throw new ArgumentException("в PhoneBook вже є такий телефон");
            }
        }
        public void changePhone(string key, int phone)
        {
            if (phoneBook.ContainsKey(key))
            {
                phoneBook[key] = phone;
            }
            else
            {
                throw new ArgumentException("в PhoneBook немає такого телефону");
            }
        }
        public void showPhone(string key)
        {
            if (phoneBook.ContainsKey(key))
            {
                Console.WriteLine(phoneBook[key]);
            }
            else
            {
                throw new ArgumentException("в PhoneBook немає такого телефону");
            }
        }
        public void deletePhone(string key)
        {
            if (phoneBook.ContainsKey(key))
            {
                phoneBook.Remove(key);
            }
            else
            {
                throw new ArgumentException("в PhoneBook немає такого телефону");
            }
        }
    }
    class Statistics
    {
        private Dictionary<string, int> statistics;
        public Statistics()
        {
            statistics = new Dictionary<string, int>();
        }
        public void createStatistics(string[] text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!statistics.ContainsKey(text[i]))
                {
                    statistics.Add(text[i], 1);
                }
                else
                {
                    statistics[text[i]]++;
                }
            }
        }
        public void showStatistics()
        {
            Console.WriteLine("\t\t\tСлово:\t\t\t\tКількість:");
            int i = 1;
            int count = 0;
            foreach (KeyValuePair<string, int> item in statistics)
            {
                Console.WriteLine($"{i, 2}.\t\t\t{item.Key, 10}\t\t\t\t{item.Value}");
                i++;
                if (item.Value == 1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Всього слів: {statistics.Count} з них унікальних: {count}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PhoneBook book = new PhoneBook();
                book.addPhone("fff", 33455);
                book.addPhone("ddd", 33665);
                book.addPhone("aaa", 33755);
                book.addPhone("iii", 33255);
                book.showPhone("fff");
                book.showPhone("ddd");
                book.showPhone("aaa");
                book.showPhone("iii");
                book.deletePhone("ddd");
                book.showPhone("fff");
                book.showPhone("aaa");
                book.showPhone("iii");
            }
            catch (ArgumentException x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }

            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            string text = "Ось будинок, який збудував Джек. А це пшениця, яка у темній коморі зберігається у будинку, який збудував Джек. А це веселий птах-синиця, який часто краде пшеницю, яка в темній коморі зберігається у будинку, який збудував Джек.";
            string[] words = text.Split([' ', ',', '.'], StringSplitOptions.RemoveEmptyEntries);
            Statistics statistics = new Statistics();
            statistics.createStatistics(words);
            statistics.showStatistics();
        }
    }
}
