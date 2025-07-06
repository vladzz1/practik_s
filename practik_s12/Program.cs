namespace practik_s12
{
    public delegate void ExchangeDelegate();
    class Exchange
    {
        public int ExchangeRate { get; set; }
        public Exchange()
        {
            ExchangeRate = 42;
        }
        public void exchangeRateChange()
        {
            Random random = new Random();
            ExchangeRate = random.Next(35, 46);
            Console.WriteLine($"курс змінивсь {ExchangeRate}");
        }
    }
    class Buyers
    {
        public int Money { get; set; }
        public Buyers()
        {
            Money = 200;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buyers> buyers = new List<Buyers>()
            {
                new Buyers(),
                new Buyers(),
                new Buyers()
            };
            Exchange exchange = new Exchange();
            foreach (var item in buyers)
            {

            }
        }
    }
}
