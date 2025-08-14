namespace practik_s18_2
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return "Product " + Name + " : " + Category;
        }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Select

            //LINQ (Language Integrated Query (LINQ))
            // інтерфейс IEnumerable.

            // Існує кілька різновидів LINQ:
            /*
                LINQ to Objects:        застосовується для роботи з масивами та колекціями    
                LINQ to Entities:       використовується при зверненні до баз даних через 
                                        технологію Entity Framework
                LINQ to Sql:            технологія доступу до даних в MS SQL Server
                LINQ to XML:            застосовується під час роботи з файлами XML
                LINQ to DataSet:        застосовується під час роботи з об'єктом DataSet
                Parallel LINQ (PLINQ):  використовується для виконання паралельних запитів    
            */

            /*
             * --select Query
              res = from elem in source
                    select elem;         
             */
            /*Синтаксис запиту */
            int[] arr = { 5, 34, -78, 25, 46, -96, 23 };

            var query = from i in arr select i * -1;
            //IEnumerable<int> query = from i in arr select i*-1;
            foreach (int i in query)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            /*Синтаксис методу */
            // Список використовуваних методів розширення LINQ
            /*
                Select: визначає проекцію вибраних значень

                Where: визначає фільтр вибірки

                OrderBy: впорядковує елементи по зростанню

                OrderByDescending: впорядковує елементи по спаданню

                ThenBy: задає додаткові критерії для упорядкування елементів по зростанню

                ThenByDescending: задає додаткові критерії для упорядкування елементів по спаданню

                Join: поєднує дві колекції за певною ознакою

                GroupBy: групує елементи за ключем

                ToLookup: групує елементи за ключем, при цьому всі елементи
                          додаються до словника

                GroupJoin: виконує одночасно з'єднання колекцій та групування елементів за ключом

                Reverse: має в своєму розпорядженні елементи у зворотному порядку

                All: визначає, чи всі елементи колекції задовольняють певну умову

                Any: визначає, чи задовольняє хоча б один елемент колекції певній умові

                Contains: визначає, чи містить колекція певний елемент

                Distinct: видаляє елементи, що дублюються, з колекції

                Except: повертає різницю двох колекцій, тобто ті елементи, які містяться тільки в одній колекції

                Union: поєднує дві однорідні колекції

                Intersect: повертає перетин двох колекцій, тобто ті елементи,
                           які зустрічаються в обох колекціях

                Count: підраховує кількість елементів колекції, які задовольняють певну умову

                Sum: підраховує суму числових значень у колекції

                Average: підраховує середнє значення числових значень у колекції

                Min: знаходить мінімальне значення

                Max: знаходить максимальне значення

                Take: вибирає певну кількість елементів

                Skip: пропускає певну кількість елементів

                TakeWhile: повертає ланцюжок елементів послідовності, доки умова істинна

                SkipWhile: пропускає елементи в послідовності, поки вони задовольняють задану умову, і потім повертає елементи, що залишилися

                Concat: об'єднує дві колекції

                Zip: об'єднує дві колекції відповідно до певної умови

                First: обирає перший елемент колекції

                FirstOrDefault: обирає перший елемент колекції або 
                                повертає значення за замовчуванням

                Single: вибирає єдиний елемент колекції, якщо колекція містить більше або менше одного елемента, то генерується виняток

                SingleOrDefault: обирає перший елемент колекції або повертає значення за замовчуванням

                ElementAt: вибирає елемент послідовності за певним індексом

                ElementAtOrDefault: вибирає елемент колекції за певним індексом або повертає значення за замовчуванням, якщо індекс поза допустимим діапазоном

                Last: вибирає останній елемент колекції

                LastOrDefault: вибирає останній елемент колекції 
                       або повертає значення за замовчуванням
             */
            var res = arr.Select(SelectInt);
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //var res2 = arr.Select(Change);
            //var res2 = arr.Select(delegate(int item) { return item * -1; });
            var res2 = arr.Select(item => item * -1);
            foreach (var item in res2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion
            #region Where
            int[] arrInt = { 15, 7, 8, 9, 12, 14, 78, 95, 36, 15 };
            var Query = from i in arrInt
                        where i % 2 == 0
                        select i * -1;
            foreach (var item in Query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Query = arrInt.Where(item => item % 2 == 0).Select(i => i * -1);
            foreach (var item in Query)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Фільтрація слів по кількості символів
            string[] words = { "jello", "faee", "tyytik", "erte",
                "qwe", "bvnv", "fhjfhj" };

            var result = from word in words
                         where word.Length == 4
                         select word;
            //var result2 = words.Where(word => word.Length == 4).Select(w=>w);
            var result2 = words.Where(word => word.Length == 4);

            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            #endregion
            #region Order By
            int[] arrInt2 = { 15, 7, 8, 9, 12, 14, 78, 95, 36, 15 };
            var sortedQuery = from i in arrInt2
                              where i % 2 == 0
                              orderby i descending //ascending(default)
                              select i;
            foreach (var item in sortedQuery)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //var sortedQuery2 = arrInt2.Where(i=>i%2 == 0).OrderBy(i=>i);
            var sortedQuery2 = arrInt2.Where(i => i % 2 == 0).OrderByDescending(i => i);
            foreach (var item in sortedQuery2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            #endregion

            #region Group By
            int[] arrGroup = { 5, 34, 65, 12, 94, 42, 365, 15 };
            IEnumerable<IGrouping<int, int>> queryGroup = from i in arrGroup
                                                          where i > 10
                                                          group i by i % 10;

            foreach (IGrouping<int, int> item in queryGroup)
            {
                Console.Write(item.Key + " - ");
                foreach (var elem in item)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

            //var gueryGroup2 = arrGroup.Where(i=> i> 10).GroupBy(i=>i%10).Select(i=>i);   
            var gueryGroup2 = arrGroup.Where(i => i > 10).GroupBy(i => i % 10).OrderBy(g => g.Key);
            foreach (IGrouping<int, int> item in gueryGroup2)
            {
                Console.Write(item.Key + " - ");
                foreach (var elem in item)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }
            Product[] products = {
                new Product(){ Name = "Apple", Category ="Food"},
                new Product(){ Name = "Phone", Category ="Tech"},
                new Product(){ Name = "Laptop", Category ="Tech"},
                new Product(){ Name = "Banana", Category ="Food"},
                new Product(){ Name = "Pelmen", Category ="Food"}
            };
            var results = products.GroupBy(p => p.Category);
            foreach (IGrouping<string, Product> item in results)
            {
                Console.Write(item.Key + " - ");
                foreach (Product elem in item)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

            #endregion
            #region Agregation function
            // Count-------------------- -
            //int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            //int size = (from i in numbers
            //            where i % 2 == 0 && i > 10
            //            select i).Count();
            //Console.WriteLine(size);

            //size = numbers.Where(i => i % 2 == 0 && i > 10).Count();
            //size = numbers.Count(i => i % 2 == 0 && i > 10);
            //Console.WriteLine(size);

            // Sum, Min, Max, Average ---------------------------
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            List<User> users = new List<User>()
            {
                new User { Name = "Tom", Age = 23 },
                new User { Name = "Sam", Age = 43 },
                new User { Name = "Bill", Age = 35 }
            };

            int sum1 = numbers.Sum();
            decimal sum2 = users.Sum(u => u.Age);
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            int min1 = numbers.Min();
            //string min2 = users.Min(u=>u.Name); // мінімальний вік
            int min2 = users.Min(u => u.Age); // мінімальний вік
            Console.WriteLine(min1);
            Console.WriteLine(min2);
            int max1 = numbers.Max();
            int max2 = users.Max(u => u.Age); // максимальний вік
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            double avr1 = numbers.Average();
            double avr2 = users.Average(u => u.Age); //максимальний вік
            Console.WriteLine(avr1);
            Console.WriteLine(avr2);

            #endregion

            #region MyRegion
            string[] soft = { "Blue", "Grey", "Yellow", "Cyan", "Grey", "Yellow" };
            string[] hard = { "Yellow", "Magenta", "White", "Blue" };

            IEnumerable<string> result3;

            // Except -----------------------        
            // знаходимо різницю між двома колекціями
            //чим колекція hard відрізняється від soft
            //result3 = soft.Except(hard);           
            //result3 = hard.Except(soft);
            // Intersect ---------------------------
            // отримуємо елементи колекції А, які присутні в колекції В (без дублікатів)
            //result3 = soft.Intersect(hard);           

            // Union ---------------------------
            // з'єднує елементи двох колекцій (без дублікатів)
            //result3 = soft.Union(hard);

            // Concat -------------
            // з'єднує елементи двох колекцій
            //result3 = soft.Concat(hard);

            // Distinct ----------------
            // видаляє дублікати
            result3 = soft.Distinct();

            foreach (string s in result3)
                Console.WriteLine(s);
            #endregion
        }
        static int SelectInt(int elem)
        {
            return elem;
        }
        static int Change(int elem)
        {
            return elem * -1;
        }
    }
}
