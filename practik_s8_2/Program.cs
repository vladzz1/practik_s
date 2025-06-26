namespace practik_s8_2
{
    abstract class Person : Object
    {
        protected string name;
        protected readonly DateTime birthdate;
        public Person()
        {
            name = "No name";
            birthdate = new DateTime();
        }
        public Person(string name, DateTime b)
        {
            this.name = name;
            if (b < DateTime.Now)
            {
                birthdate = b;
            }
            else
                birthdate = new DateTime();
        }
        //abstract method the same  void DoWork() = 0;
        public abstract void DoWork();
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}.\nBirthdate :" +
                $" {birthdate.ToLongDateString()} ");
        }
        public override string ToString()
        {
            return $"Name : {name}.\nBirthdate :" +
                $" {birthdate.ToLongDateString()} ";
        }
    }

    //class Name : BaseClass, Interface1, Interface2, Interface3
    class Worker : Person
    {
        private int salary;

        public int Salary
        {
            get { return salary; }
            private set
            {
                //if (value < 0)
                //    salary = 0;
                //else
                //    salary = value; 
                //this.salary = value < 0 ? 0 : value;
                this.salary = value >= 0 ? value : 0;
            }
        }
        public Worker() : base()
        {
            Salary = 0;
        }
        public Worker(string name, DateTime b, int salary) : base(name, b)
        {
            Salary = salary;
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work....");
        }
        // new  - create new member and stop virtual
        //override - перевизначаємо метод батьківського класу
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    //sealed - запакований - ми забороняємо перевизначати метод
    //в наступних наслідниках
    //sealed - запакований - ми забороняємо наслідування

    class Programmer : Worker
    {
        public int CodeLines { get; set; }
        public Programmer() : base()
        {
            CodeLines = 0;
        }
        public Programmer(string name, DateTime b, int salary) :
            base(name, b, salary)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            Console.WriteLine("Write code in C#");
        }
        public void WriteLine()
        {
            CodeLines++;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines : {CodeLines}");
        }
    }
    class TeamLead : Programmer
    {
        public int ProjectCount { get; set; }
        public TeamLead() : base()
        {
            ProjectCount = 0;
        }
        public TeamLead(string name, DateTime b, int salary) : base(name, b, salary)
        {
            ProjectCount = 0;
        }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project!!!");
        //}
    }
    internal class Program
    {
        static void Print()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Print();

            Worker worker = new Worker("Vova", new DateTime(2000, 3, 5), 5000);
            worker.DoWork();
            worker.Print();

            Person[] persons = new Person[]
            {
                //new Person(),
                worker,
                new Programmer("Ivan",new DateTime(1995,12,3),5500),
                new TeamLead("Bob",new DateTime(1969,8,14),55000)
            };

            foreach (Person person in persons)
            {
                Console.WriteLine("-------------- Info -----------------");
                //person.Print();
                person.DoWork();
            }

            Programmer pr = null;
            //------ 1 use cast() -----
            try
            {
                pr = (Programmer)persons[0];
                pr.DoWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //--------- 2 - use as
            pr = persons[0] as Programmer;
            if (pr != null)
            {
                pr.DoWork();
            }
            else
            { Console.WriteLine("Object is null"); }
            // ----------- 3 - use IS and AS

            if (persons[1] is Programmer)
            {
                pr = persons[1] as Programmer;
                pr.DoWork();
            }
            else
            { Console.WriteLine("Object is null"); }
        }
    }
}
