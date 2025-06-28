namespace practik_s9_2
{
    class MyClass
    {
        public void Print() { }
    }
    //interface IWorkable
    //{
    //   // private string name; // error
    //    //public
    //    string Work();
    //    bool IsWorking { get; set; }
    //    event EventHandler workEnded;
    //}
    abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public void Print()
        {
            Console.WriteLine($"{LastName}. Name : {FirstName}.\n" +
                $"Birthdate : {Birthdate.ToLongDateString()}");
        }
        public override string ToString()
        {
            return $"{LastName}. Name : {FirstName}.\n" +
                $"Birthdate : {Birthdate.ToLongDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public double Salary { get; set; }
        public string Position { get; set; }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"\nPosition : {Position}" +
                $". Salary : {Salary}");
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPosition : {Position}" +
                $". Salary : {Salary}";
        }
    }
    interface IWorkable
    {
        string Work();
        bool IsWorking { get; }
    }
    interface IManager
    {
        List<Employee> ListOfWorker { get; set; }
        void Organize();
        void MakeBudgect();
        void Control();
    }
    class Director : Employee, IManager//implement/ realize
    {
        public List<Employee> ListOfWorker { get; set; }
        public void Control()
        {
            Console.WriteLine("Controling work!!!!");
        }
        public void MakeBudgect()
        {
            Console.WriteLine("Making money....");
        }
        public void Organize()
        {
            Console.WriteLine("I organize work....");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;
        public string Work()
        {
            return "I selling product!";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;
        public string Work()
        {
            return "I get pay for product";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking => true;
        public List<Employee> ListOfWorker { get; set; }
        public void Control()
        {
            Console.WriteLine("I am a BOSS. You must comply me!!!");
        }
        public void MakeBudgect()
        {
            Console.WriteLine("I have many money!!!!");
        }
        public void Organize()
        {
            Console.WriteLine("I organize work today");
        }
        public string Work()
        {
            return "I do my work(((((((";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Director director = new Director
            //Interfaces reference
            IManager director = new Director
            {
                FirstName = "Jeff",
                LastName = "Bezos",
                Birthdate = new DateTime(1964, 12, 4),
                Position = "Ceo",
                Salary = 5000000
            };
            // director.Salary = 1000000000;
            Console.WriteLine(director);
            director.Organize();
            director.Control();
            director.MakeBudgect();
            director.ListOfWorker = new List<Employee>()
            {
                new Seller
                {
                    FirstName = "Tanya",
                    LastName = "Oliunuk",
                    Birthdate = new DateTime(2000, 12, 4),
                    Position = "Seller",
                    Salary = 8000
                },
                new Cashier
                {
                    FirstName = "Olga",
                    LastName = "Oliunuk",
                    Birthdate = new DateTime(2000, 12, 4),
                    Position = "Seller",
                    Salary = 9000
                }
            };

            (director as Director)!.Salary = 30000000;
            Console.WriteLine(director);

            //Seller seller = new Seller
            IWorkable seller = new Seller
            {
                FirstName = "Tanya",
                LastName = "Oliunuk",
                Birthdate = new DateTime(2000, 12, 4),
                Position = "Seller",
                Salary = 8000
            };
            //seller.Salary = 10000000000;
            Console.WriteLine(seller);
            seller.Work();

            Administrator admin = new Administrator();

            IManager manager = admin;
            manager.Organize();

            IWorkable worka = admin;
            worka.Work();
            //Example interfaces
            //https://github.com/IliushynOlena/cs_interfaces
        }
    }
}