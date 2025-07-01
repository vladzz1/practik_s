using System.Collections;

namespace practik_s10
{
    enum Genre { Comedy, Horror, Adventure, Drama }
    class Director : ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Director()
        {
            FirstName = LastName = "no data";
        }
        public Director(string? FirstName, string? LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"first name : {FirstName}\nlast name : {LastName}";
        }
    }
    class Movie : ICloneable, IComparable<Movie>
    {
        public string? Title { get; set; }
        public Director? Director { get; set; }
        public string? Country { get; set; }
        public Genre Genre { get; set; }
        private int year;
        public int Year
        {
            get { return year; }
            set 
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        private short rating;
        public short Rating
        {
            get { return rating; }
            set
            {
                if (value > 0)
                {
                    rating = value; 
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Movie()
        {
            Title = Country = "no data";
            Year = Rating = 0;
            Director = new Director();
        }
        public Movie(string? Title, string? FirstName, string? LastName, string? Country, Genre Genre, int Year, short Rating)
        {
            this.Title = Title;
            Director = new Director(FirstName, LastName);
            this.Country = Country;
            this.Genre = Genre;
            this.Year = Year;
            this.Rating = Rating;
        }
        public object Clone()
        {
            Movie temp = (Movie)MemberwiseClone();
            temp.Director = (Director)Director!.Clone();
            return temp;
        }
        public int CompareTo(Movie? other)
        {
            return Title!.CompareTo(other!.Title);
        }

        public override string ToString()
        {
            return $"title : {Title}\ndirector : {Director}\ncountry : {Country}\ngenre : {Genre}\nyear : {Year}\nrating : {Rating}";
        }
    }
    class Cinema : IEnumerable
    {
        public Movie[]? Movies { get; set; }
        public string? Address { get; set; }
        public Cinema()
        {
            Movies = null;
            Address = "no data";
        }
        public Cinema(Movie[] movies, string? address)
        {
            Movies = movies;
            Address = address;
        }
        public Cinema(string? address, params Movie[] movies)
        {
            Address = address;
            Movies = movies;
        }
        public IEnumerator GetEnumerator()
        {
            return Movies!.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(Movies!);
        }
        public void Sort(IComparer<Cinema> comparer)
        {
            Array.Sort(Movies!, (Array)comparer);
        }
    }
    internal class Program
    {
        static void showCinema(Cinema cinema)
        {
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Movie movie1 = new Movie("title1", "Oleg", "Topola", "country1", Genre.Comedy, 2002, 134);
                Movie movie2 = new Movie("title2", "Vova", "Bobr", "country2", Genre.Adventure, 2003, 99);
                Movie movie3 = new Movie("title3", "Polihuk", "Mister", "country3", Genre.Comedy, 1995, 120);
                Movie movie4 = new Movie("title4", "Bob", "Rat", "country4", Genre.Adventure, 1994, 145);
                Movie movie5 = new Movie("title5", "Oleg", "Mul", "country5", Genre.Drama, 2012, 122);
                Cinema cinema1 = new Cinema("addres1", [movie1, movie2, movie3, movie4, movie5]);
                showCinema(cinema1);
                cinema1.Sort();
                Console.WriteLine("- - - - - - - -");
                showCinema(cinema1);
                Movie movie6 = (Movie)movie5.Clone();
                Movie movie7 = (Movie)movie2.Clone();
                Movie movie8 = (Movie)movie3.Clone();
                Movie movie9 = (Movie)movie4.Clone();
                movie9.CompareTo(movie4);
                Cinema cinema2 = new Cinema("address2", [movie6, movie7, movie8, movie9]);
                Console.WriteLine("- - - - - - - -");
                showCinema(cinema2);
            }
            catch (ArgumentException x)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x.Message);
                Console.ResetColor();
            }
        }
    }
}
