namespace practik_s6
{
    class CreditCard
    {
        private string? cardNumber;
        public string? CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (cardNumber?.Length == 16)
                {
                    cardNumber = value;
                }
                else
                {
                    throw new Exception("в номері повинно бути 16 цифр");
                }
            }
        }
        private string? name;
        public string? Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception("error: empty line");
                }
                else
                {
                    name = value;
                }
            }
        }
        private string? surName;
        public string? SurName
        {
            get { return surName; }
            set
            {
                if (string.IsNullOrWhiteSpace(surName))
                {
                    throw new Exception("error: empty line");
                }
                else
                {
                    surName = value;
                }
            }
        }
        private string? lastName;
        public string? LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    throw new Exception("error: empty line");
                }
                else
                {
                    lastName = value;
                }
            }
        }
        private string? cvc;
        public string? Cvc
        {
            get { return cvc; }
            set
            {
                if (cvc?.Length == 3)
                {
                    cvc = value;
                }
                else
                {
                    throw new Exception("в номері повинно бути 3 цифри");
                }
            }
        }
        private DateTime completionDate;
        public DateTime CompletionDate
        {
            get { return completionDate; }
            set
            {
                if (completionDate > DateTime.Now)
                {
                    completionDate = value;
                }
                else
                {
                    throw new Exception("термін картки вийшов");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //завдання 1

            try
            {
                Console.Write("введіть число: ");
                int str1 = int.Parse(Console.ReadLine()!);
            }
            catch (Exception x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }
            Console.WriteLine("----------------------------\n");

            //завдання 2

            try
            {
                CreditCard creditCard = new CreditCard();
                Console.WriteLine("введіть номер картки: ");
                creditCard.CardNumber = Console.ReadLine()!;
                Console.WriteLine("введіть ім'я: ");
                creditCard.Name = Console.ReadLine()!;
                Console.WriteLine("введіть прізвище: ");
                creditCard.SurName = Console.ReadLine()!;
                Console.WriteLine("введіть по батькові: ");
                creditCard.LastName = Console.ReadLine()!;
                Console.WriteLine("введіть cvc: ");
                creditCard.Cvc = Console.ReadLine()!;
                Console.WriteLine("введіть дату завершення роботи картки: ");
                creditCard.CompletionDate = DateTime.Parse(Console.ReadLine()!);
                Console.WriteLine("----------------------------\n");
            }
            catch (Exception x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }

            //завдання 3

            try
            {
                Console.Write("введіть математичний вираз: ");
                string str2 = Console.ReadLine()!;
                string[] line1 = str2.Split(new char[] { '*' });
                int[] line2 = new int[line1.Length];
                for (int i = 0; i < line1.Length; i++)
                {
                    line2[i] = int.Parse(line1[i]);
                }
                int count = 1;
                for (int i = 0; i < line2.Length; i++)
                {
                    count = count * line2[i];
                }
                Console.WriteLine($"{str2} = {count}");
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
