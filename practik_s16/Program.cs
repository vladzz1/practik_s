using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace practik_s16
{
    [Serializable]
    class User
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 1000 && value <= 9999)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private string? login;
        public string? Login
        {
            get { return login; }
            set
            {
                int count = 0;
                for (int i = 0; i < value?.Length; i++)
                {
                    if (Char.IsLetter(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value?.Length)
                {
                    login = value;
                }
                else
                {
                    throw new Exception("login повинен бути з букв");
                }
            }
        }
        private string? password;
        public string? Password
        {
            get { return password; }
            set
            {
                int count = 0;
                for (int i = 0; i < value?.Length; i++)
                {
                    if (Char.IsLetter(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value?.Length && value?.Length >= 8)
                {
                    password = value;
                }
                else
                {
                    throw new Exception("password повинен бути з букв і мінімум з 8 букв");
                }
            }
        }
        private string? confirmPassword;
        public string? ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                int count = 0;
                for (int i = 0; i < value?.Length; i++)
                {
                    if (Char.IsLetter(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value?.Length && value?.Length >= 8)
                {
                    confirmPassword = value;
                }
                else
                {
                    throw new Exception("confirm password повинен бути з букв і мінімум з 8 букв");
                }
            }
        }
        private string? email;
        public string? Email
        {
            get { return email; }
            set
            {
                int count1 = 0, count2 = 0;
                for (int i = 0; i < value?.Length - 10; i++)
                {
                    if (Char.IsLetter(value![i]) || Char.IsDigit(value[i]) || value[i] == '.')
                    {
                        if (value[i] == '.' && value[i + 1] == '.')
                        {
                            throw new Exception("в email до @ не може бути дві . підряд");
                        }
                        else
                        {
                            count1++;
                        }
                    }
                } 
                string str = "@gmail.com";
                int k = 0;
                for (int j = value!.Length - 10; j < value!.Length; j++)
                {
                    if (value[j] == str[k])
                    {
                        count2++;
                    }
                    k++;
                }
                if (count1 == value?.Length - 10 && count2 == 10)
                {
                    email = value;
                }
                else
                {
                    throw new Exception("не правильнмй email");
                }
            }
        }
        private string? creditCard;
        public string? CreditCard
        {
            get { return creditCard; }
            set
            {
                int count = 0;
                for (int i = 0; i < value?.Length; i++)
                {
                    if (Char.IsDigit(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value?.Length && value?.Length == 16)
                {
                    creditCard = value;
                }
                else
                {
                    throw new Exception("credit card має складатись з цифр і з 16 цифр");
                }
            }
        }
        private string? phone;
        public string? Phone
        {
            get { return phone; }
            set
            {
                int count = 0;
                for (int i = 0; i < value?.Length; i++)
                {
                    if (Char.IsDigit(value[i]))
                    {
                        count++;
                    }
                }
                if (count == value?.Length && value?.Length == 12 && value[0] == '3' && value[1] == '8' && value[2] == '0')
                {
                    confirmPassword = value;
                }
                else
                {
                    throw new Exception("не правильний phone");
                }
            }
        }
        public User()
        {
            Random random = new Random();
            Id = random.Next(1000, 10000);
            Login = "nologin";
            Password = "nopassword";
            ConfirmPassword = "noconfirmpassword";
            Email = "noemail@gmail.com";
            Phone = "380" + random.Next(100000000, 1000000000);
        }
        public User(int id, string login, string password, string confirmPassword, string email, string creditCard, string phone)
        {
            Id = id;
            Login = login;
            Password = password;
            ConfirmPassword = confirmPassword;
            Email = email;
            Phone = phone;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, User> users = new Dictionary<int, User>();
            int key;
                while (true)
                {
                    try
                    {
                        Console.Write("\t1. додати користувача\n\t2. записати словник в файл\n\t3. прочитати словник з файлу\n\t0. вийти\n\t");
                        key = int.Parse(Console.ReadLine()!);
                        switch (key)
                        {
                            case 0:
                                Console.Clear();
                                return;
                            case 1:
                                Console.Clear();
                                int count = 1;
                                Console.Write("\tвведіть id: ");
                                int id = int.Parse(Console.ReadLine()!);
                                foreach (var item in users)
                                {
                                    if (id == item.Value.Id)
                                    {
                                        throw new Exception("в словнику вже є користувач з таким id");
                                    }
                                    count++;
                                }
                                Console.Write("\tвведіть login: ");
                                string login = Console.ReadLine()!;
                                Console.Write("\tвведіть password: ");
                                string password = Console.ReadLine()!;
                                Console.Write("\tвведіть confirm password: ");
                                string confirmPassword = Console.ReadLine()!;
                                Console.Write("\tвведіть email: ");
                                string email = Console.ReadLine()!;
                                Console.Write("\tвведіть credit card: ");
                                string creditCard = Console.ReadLine()!;
                                foreach (var item in users)
                                {
                                    if (creditCard == item.Value.CreditCard)
                                    {
                                        throw new Exception("в словнику вже є користувач з таким credit card");
                                    }
                                }
                                Console.Write("\tвведіть phone: ");
                                string phone = Console.ReadLine()!;
                                User user = new User(id, login, password, confirmPassword, email, creditCard, phone);
                                users.Add(count, user);
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                File.WriteAllText("file_s16", JsonSerializer.Serialize(users));
                                break;
                            case 3:
                                Console.Clear();
                                users = JsonSerializer.Deserialize<Dictionary<int, User>>(File.ReadAllText("file_s16"))!;
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                    }
                    catch (ArgumentOutOfRangeException x)
                    {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                    }
                    catch (Exception x)
                    {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(x.Message);
                    Console.ResetColor();
                    }
                }
        }
    }
}
