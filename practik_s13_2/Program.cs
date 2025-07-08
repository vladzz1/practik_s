namespace practik_s13_2
{
    class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            countries.Add("UA", "Ukraine");
            countries.Add("PL", "Poland");
            countries.Add("USA", "United States");
            countries.Add("GB", "Great Britain");
            countries.Add("FR", "France");
            //countries.Add("FR", "Canada"); //error

            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine($"Key : {country.Key,5}. Value {country.Value,20}");
            }

            string c = countries["USA"];//get
            Console.WriteLine(c);

            countries["USA"] = "India";

            c = countries["USA"];//get
            Console.WriteLine(c);

            countries.Remove("USA");
            countries["CA"] = "Canada";
            foreach (KeyValuePair<string, string> country in countries)
            {
                Console.WriteLine($"Key : {country.Key,5}. Value {country.Value,20}");
            }
            Console.WriteLine("--------------------------------------------");
            Dictionary<char, Person> people = new Dictionary<char, Person>();

            people.Add('A', new Person() { Name = "Andriy" });
            people.Add('O', new Person() { Name = "Olga" });
            people.Add('Y', new Person() { Name = "Yura" });
            people.Add('M', new Person() { Name = "Muroslava" });

            foreach (KeyValuePair<char, Person> p in people)
            {
                Console.WriteLine($"Key : {p.Key,5}. Value {p.Value.Name,20}");
            }
            if (people.ContainsKey('T'))
            {
                people['T'] = new Person() { Name = "Tanya" };

            }
            else
            {
                Console.WriteLine("Error key...");
            }

            foreach (KeyValuePair<char, Person> p in people)
            {
                Console.WriteLine($"Key : {p.Key,5}. Value {p.Value.Name,20}");
            }

            foreach (char letter in people.Keys)
            {
                Console.WriteLine(letter);
            }

            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
