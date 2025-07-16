using System.Reflection;

namespace practik_s16_2
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor |
        AttributeTargets.Class)]
    class CoderAttribute : Attribute
    {
        public string Name { get; set; } = "Olena";
        public DateTime Date { get; set; } = DateTime.Now;
        public CoderAttribute() { }
        public CoderAttribute(string n, string date)
        {
            try
            {
                Name = n;
                Date = Convert.ToDateTime(date);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public override string ToString()
        {
            return $"{Name} : {Date}";
        }
    }
    [Obsolete, Serializable]
    [Coder]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        [CoderAttribute]
        public Employee() { }
        [Coder("Dima", "2025-07-14")]
        public void IncreaseSalary(double sum)
        {
            Salary += sum;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attributes of class Employee");
            foreach (var item in typeof(Employee).GetCustomAttributes(true))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Attributes of members of class Employee");
            foreach (MemberInfo item in typeof(Employee).GetMembers())
            {
                Console.WriteLine("\t" + item.ToString());
                foreach (var attr in item.GetCustomAttributes<CoderAttribute>(true))
                {
                    Console.WriteLine("\t\t" + attr);
                }
            }
        }
    }
}
