namespace practik_s14_2
{
    class MyClass
    {
        int num;
        public MyClass(int number)
        {
            num = number;
        }
        public static implicit operator int(MyClass p)
        {
            return p.num;
        }

    }
    class Student
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            /*
           ArrayList arrayList1 = new ArrayList();
           ArrayList arrayList2 = new ArrayList(new int[] { 1, 2, 5, 8 });
           ArrayList arrayList3 = new ArrayList(10);

           Console.WriteLine($"Місткість по замовчуванню:{arrayList1.Capacity}");
           arrayList1.Add("one");
           arrayList1.Add(3.14f);
           arrayList1.Add(0.999);
           arrayList1.Add(3.36m);
           arrayList1.Add(false);

           Console.WriteLine($"Місткість після додавання одного елементу: {arrayList1.Capacity}");
           arrayList1.AddRange(new int[] { 2, 5, 48, 14 });
           Console.WriteLine($"Місткість після додавання колекції: {arrayList1.Capacity}");
           arrayList1.Capacity = 10;
           Console.WriteLine($"Місткість задана через властивість:{arrayList1.Capacity}   ");
           Console.WriteLine($"Фактична кількість елементів:{arrayList1.Count} ");
           arrayList1.TrimToSize();
           Console.WriteLine($"Місткість зменшена до дійсної кількості елементів:{arrayList1.Capacity}");
           Console.WriteLine($"Елемент з індексом 2:{arrayList1[2]}");
           Console.WriteLine("Всі елементи колекції:");
           //arrayList1.Sort();
           foreach (object item in arrayList1)
           {
               Console.WriteLine($"\t{item}");

                if (item is int)
                {
                    int a = (int)item;
                    a++;
                    Console.WriteLine(a);
                }
                if (item is float)
                {
                    float a = (float)item;
                    a--;
                    Console.WriteLine(a);
                }
            }

           Console.Write("И?х/rн?я колекція: ");
           ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
           foreach (int i in arrayList)
           {
               Console.Write($"{i} ");
           }
           Console.Write("\n\nВставка елементу: ");
           arrayList.Insert(2, "Hello");
           //arrayList.Sort();
           foreach (object item in arrayList)
           {
               Console.Write($"{item} ");
           }
           Console.Write("\n\nВидалення елементу: ");
           arrayList.RemoveAt(3);
           foreach (object item in arrayList)
           {
               Console.Write($"{item} ");
           }
           Console.WriteLine("\n\nІндекс елементу \"Hello\": " + arrayList.IndexOf("Hello"));
           Console.Write("\nОтримання діапазону: ");
           ArrayList days = new ArrayList(new string[]{ "Sunday", "Monday", "Tuesday","Wednesday", "Thursday",
               "Friday","Saturday" });
           ArrayList onlyWork = new ArrayList(days.GetRange(1, 5));
           foreach (string s in onlyWork)
           {
               Console.Write($"{s} ");
           }
           Console.Write("\n\nСортування колекції: ");
           onlyWork.Sort();
           foreach (string s in onlyWork)
           {
               Console.Write($"{s} ");
           }
           Console.WriteLine();
          */
            #endregion
            #region Stack
            /*
            Stack stack1 = new Stack(); // місткість по замовчуванню
            Stack stack2 = new Stack(7); // початкове значення ємності
                                         // елементи копіюються з вказаної колекції
            Stack stack3 = new Stack(new ArrayList { 3, 5 });

            Stack stack = new Stack();
            Console.Write("Метод Push(): ");
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n\nМетод Pop(): ");
            stack.Pop();
            foreach (string item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\n\nМетод Peek():{(string)stack.Peek()}");
            Console.WriteLine("\nЧи існує елемент \"ten\": " + stack.Contains("ten")); // false
            Console.WriteLine("\nЧи існує елемент \"two\": " + stack.Contains("two")); // true
            Console.Write("\nМетод CopyTo(): ");
            string[] strArr = new string[stack.Count];
            stack.CopyTo(strArr, 0);
            foreach (string item in strArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n\nКількість елементів: " + stack.Count); // 3
            stack.Clear();
            Console.WriteLine("\nКількість елементів виклику метода Clear(): " + stack.Count); // 0

            ///////////////////////////////////////
            var stackk = new Stack();
            stackk.Push("First");
            stackk.Push("Second");
            stackk.Push("Third");
            stackk.Push("Fourth");
            // Peek() - get first
            if (stackk.Peek() is string)
            {
                string str = (string)stackk.Pop();
                Console.WriteLine(str);
            }
            while (stackk.Count > 0)
            {
                Console.WriteLine(stackk.Pop());
            }
            Console.WriteLine(stackk.Pop());
            Console.ReadKey();
            */
            #endregion

            #region BoxingUnboxing
            /*
            object obj = new object();//ref
            int number = 45;//value - stack

            //boxing
            obj = (object) number;//value - ref
            Console.WriteLine(obj);

            //unboxing
            number = (int)obj;
            Console.WriteLine(number);

            //boxing
            MyClass myClass = new MyClass(number);//value => ref

            //unboxing
            int res = (int)myClass;

            int a = 5;
            string str = "Hello";
            ArrayList arrayList1 = new ArrayList(new int[] { 1, 2, 5, 8 });
            ArrayList arrayList3 = new ArrayList(10);
            Console.WriteLine($"Місткість по замовчуванню:{arrayList1.Capacity}");
            arrayList1.Add("one");
            arrayList1.Add(3.14f);
            arrayList1.Add(0.999);
            arrayList1.Add(3.36m);
            arrayList1.Add(false);
          
            //List<Student> list = new List<Student>();   
            int b = (int)arrayList1[0];

         */
            #endregion
            #region SortedList HashTable
            /*
                SortedList sortedList = new SortedList();
                sortedList.Add(3, 6.7);
                sortedList.Add(2, new Student
                {
                    Name = "Jack"
                });
                sortedList.Add(1, "one");
                //sortedList.Add("one" ,1 );
                Console.WriteLine("----- Вивід ключ-значення ------\n");
                foreach (object item in sortedList.Keys)
                {
                    Console.WriteLine($"Ключ: {item}  Значення: {sortedList[item]}");
                }
                Console.WriteLine("\n------- Вивід ключ-значення по індексу--------\n");
                for (int i = 0; i < sortedList.Count; i++)
                {
                    Console.WriteLine($"Ключ: {sortedList.GetKey(i)} Значення: {sortedList.GetByIndex(i)}");

                }
                Console.WriteLine("\n---- Колекція значеннь -----\n");
                foreach (object item in sortedList.Values)
                    Console.WriteLine(item);
                Console.WriteLine("\n----- Видалення елементу по ключу 3------\n");
                sortedList.Remove(3);
            
            Console.WriteLine($"Чи існує елемент 3:{sortedList.ContainsKey(3)}"); // false
            */
            /*
          Hashtable hash = new Hashtable();
 
          hash.Add(1, "John");
          hash.Add("two", new Student { Name = "Jack" });
          hash.Add("Pi", 3.14159);
          hash.Add(true, 3.14159);
          hash.Add(3.14, "PI");
          Console.WriteLine("----- Вивід ключ-значення -------\n");

          foreach (object item in hash.Keys)
          {
              Console.WriteLine("Ключ: " + item + " Значення: " + hash[item]);
          }

          Console.WriteLine("\n----- Колекція значень після додавання елементу---- -\n");
          foreach (object item in hash.Values) Console.WriteLine(item);
          Console.WriteLine("\n----- Видалення елементу по ключу\"two\" ------\n");
          hash.Remove("two");
          Console.WriteLine($"Чи існує елемент \"two\":{hash.ContainsKey("two")}"); // false
            */
            #endregion
        }
    }
}
