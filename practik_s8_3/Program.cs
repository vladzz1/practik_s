namespace practik_s8_3
{
    class Laptop
    {
        public string Model { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Model : {Model}. Price : {Price}";
        }
    }
    class Shop
    {
        Laptop[] laptops;// null 
        public Shop(int size)//5
        {
            laptops = new Laptop[size];
        }
        public int Length
        {
            get { return laptops.Length; }
        }
        public void SetLaptop(Laptop laptop, int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                laptops[index] = laptop;
            }
        }
        public Laptop GetLaptop(int index)
        {
            if (index >= 0 && index < laptops.Length)
            {
                return laptops[index];
            }
            throw new IndexOutOfRangeException();
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
            }
        }
        public Laptop this[string name]
        {
            get
            {
                foreach (var l in laptops)
                {
                    if (l.Model == name)
                        return l;
                }
                return null;
            }
            // private set 
            //{
            //    for (var i = 0; i < laptops.Length; i++)
            //    {
            //        if(laptops[i].Model == name)
            //        {
            //            laptops[i] = value;
            //            break;
            //        }
            //    }
            //}
        }
        private int FindByPrice(double price)
        {
            for (int i = 0; i < laptops.Length; i++)
            {
                if (laptops[i].Price == price)
                    return i;
            }
            return -1;
        }
        public Laptop this[double price]
        {
            get
            {
                int index = FindByPrice(price);
                if (index != -1)
                    return laptops[index];
                throw new Exception("Incorrect price");

            }
            set
            {
                int index = FindByPrice(price);
                if (index != -1)
                    laptops[index] = value;

            }
        }

    }
    public class MultArray
    {
        private int[,] array;
        public int Rows { get; private set; }
        public int Cols { get; private set; }
        public MultArray(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            array = new int[rows, cols];
        }
        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultArray multArray = new MultArray(2, 3);

            for (int i = 0; i < multArray.Rows; i++)
            {
                for (int j = 0; j < multArray.Cols; j++)
                {
                    multArray[i, j] = i + j;//indexator - set
                    Console.Write($"{multArray[i, j]} ");//indexator - get
                }
                Console.WriteLine();
            }
            // []
            Shop shop = new Shop(3);
            //shop.SetLaptop(new Laptop() { Model = "HP", Price = 25000}, 0);
            //Console.WriteLine(shop.GetLaptop(0));
            //shop[0] = new Laptop() { Model = "HP", Price = 25000 }; //setter
            //Console.WriteLine(shop[0]);//getter

            try
            {
                shop[0] = new Laptop() { Model = "HP", Price = 45000.99 };//set
                shop[1] = new Laptop() { Model = "ASUS", Price = 32000.99 };//set
                shop[2] = new Laptop() { Model = "DELL", Price = 12000.99 };//set

                for (int i = 0; i < shop.Length; i++)
                {
                    Console.WriteLine(shop[i]);
                }
                Console.WriteLine("-----------------------");
                Console.WriteLine(shop["HP"]);
                //shop["HP"] = new Laptop() { Model = "Mac", Price = 120000 };
                //Console.WriteLine(shop["Mac"]);
                Console.WriteLine(shop[12000.99]);
                shop[12000.99] = new Laptop();
                for (int i = 0; i < shop.Length; i++)
                {
                    Console.WriteLine(shop[i]);
                }
                Console.WriteLine("-----------------------");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}