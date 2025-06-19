namespace practik_s5
{
    class Worker
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Lastname { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age >= 0 && age <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("error: неправильне введення");
                }
            }
        }
        private int salary;
        public int Salary
        {
            get { return salary; }
            set
            {
                if (salary > 0 && salary < 170000)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("error: неправильне введення");
                }
            }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date < DateTime.Now)
                {
                    date = value;
                }
                else
                {
                    throw new Exception("error: неправильне введення");
                }
            }
        }
    }
    class Calculator
    {
        public int A { get; set; }
        public int B { get; set; }
        public void setAB()
        {
            Console.Write("введіть перше число: ");
            A = int.Parse(Console.ReadLine()!);
            Console.Write("введіть друге число: ");
            B = int.Parse(Console.ReadLine()!);
        }
        public void add()
        {
            Console.WriteLine(A + B);
        }
        public void sub()
        {
            Console.WriteLine(A - B);
        }
        public void mul()
        {
            Console.WriteLine(A * B);
        }
        public void div()
        {
            if (B == 0)
            {
                throw new Exception("error: неправильне введення");
            }
            else
            {
                Console.WriteLine(A / B);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //завдання 1

                Worker[] worker = new Worker[5];
                for (int i = 0; i < worker.Length; i++)
                {
                    worker[i] = new Worker();
                    Console.Write("введіть ім'я: ");
                    worker[i].Name = Console.ReadLine()!;
                    Console.Write("введіть прізвище: ");
                    worker[i].Surname = Console.ReadLine()!;
                    Console.Write("введіть по батькові: ");
                    worker[i].Lastname = Console.ReadLine()!;
                    Console.Write("введіть по вік: ");
                    worker[i].Age = int.Parse(Console.ReadLine()!);
                    Console.Write("введіть зарплату: ");
                    worker[i].Salary = int.Parse(Console.ReadLine()!);
                    Console.Write("введіть рік-місяць-день: ");
                    worker[i].Date = DateTime.Parse(Console.ReadLine()!);
                }

                //завдання 2

                Calculator calculator = new Calculator();
                calculator.setAB();
                Console.Write("введіть дію: ");
                char key = char.Parse(Console.ReadLine()!);
                if (key == '+')
                {
                    calculator.add();
                }
                else if (key == '-')
                {
                    calculator.sub();
                }
                else if (key == '*')
                {
                    calculator.mul();
                }
                else if (key == '/')
                {
                    calculator.div();
                }
                else
                {
                    throw new Exception("error: неправильне введення");
                }
            }
            catch (Exception x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }
        }
    }

}
