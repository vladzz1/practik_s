using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace practik_s16
{
    [Serializable]
    class User
    {
        [Required(ErrorMessage = "id not setted")]
        [Range(1000, 9999, ErrorMessage = "wrong id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "login not setted")]
        public string? Login { get; set; }
        [Required(ErrorMessage = "password not setted")]
        [Length(8, 1000, ErrorMessage = "wrong password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "confirm password not setted")]
        [Length(8, 1000, ErrorMessage = "wrong confirm password")]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "email not setted")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage = "credit card not setted")]
        [Length(16, 16, ErrorMessage = "wrong credit card")]
        public string? CreditCard { get; set; }
        [Required(ErrorMessage = "phone not setted")]
        [Phone]
        public string? Phone { get; set; }
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
            bool isValid = true;
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
                                int count = 1;
                                int id;
                                string login, password, confirmPassword, email, creditCard, phone;
                                do
                                {
                                    Console.Clear();
                                    count = 1;
                                    Console.Write("\tвведіть id: ");
                                    id = int.Parse(Console.ReadLine()!);
                                    foreach (var item in users)
                                    {
                                        if (id == item.Value.Id)
                                        {
                                            Console.WriteLine("в словнику вже є користувач з таким id");
                                        }
                                        count++;
                                    }
                                    Console.Write("\tвведіть login: ");
                                    login = Console.ReadLine()!;
                                    Console.Write("\tвведіть password: ");
                                    password = Console.ReadLine()!;
                                    Console.Write("\tвведіть confirm password: ");
                                    confirmPassword = Console.ReadLine()!;
                                    Console.Write("\tвведіть email: ");
                                    email = Console.ReadLine()!;
                                    Console.Write("\tвведіть credit card: ");
                                    creditCard = Console.ReadLine()!;
                                    foreach (var item in users)
                                    {
                                        if (creditCard == item.Value.CreditCard)
                                        {
                                            Console.WriteLine("в словнику вже є користувач з таким credit card");
                                        }
                                    }
                                    Console.Write("\tвведіть phone: ");
                                    phone = Console.ReadLine()!;
                                    var result = new List<ValidationResult>();
                                    var context = new ValidationContext(users);
                                    if (!(isValid = Validator.TryValidateObject(users, context, result, true)))
                                    {
                                        foreach (ValidationResult error in result)
                                        {
                                            Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                                        }
                                    }
                                } while (!isValid);
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
