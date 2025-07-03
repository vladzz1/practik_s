using System.Collections;

namespace practik_s10_2
{
    class StudentCard : ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public override string ToString()
        {
            return $"Students Card : {Number} . {Series}";
        }
    }
    class Student : IComparable<Student>, ICloneable //IComparable
    {
        public string FirstName { get; set; }//0x111 --->  0x111
        public string LastName { get; set; }//0x222  ---> 0x222
        public DateTime Birthdate { get; set; }//2000.02.03  ---> 2000.02.03 
        public StudentCard StudentCard { get; set; }//0x3333 ---> 0x33333
        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone(); //shallow copy
            //глибоке копіювання
            //temp.StudentCard = new StudentCard() 
            //{ 
            //    Number = this.StudentCard.Number, 
            //    Series = this.StudentCard.Series };
            temp.StudentCard = (StudentCard)this.StudentCard.Clone();
            return temp;
        }
        //public int CompareTo(object? obj)
        //{
        //    if( obj is Student)
        //    {

        //     return this.FirstName.CompareTo((obj as Student)!.FirstName);
        //    }
        //    else
        //    {
        //        throw new Exception("Error obj");
        //    }
        //}
        public int CompareTo(Student? other)
        {
            return FirstName.CompareTo(other!.FirstName);
        }
        public override string ToString()
        {
            return $"Fullname : {FirstName} {LastName}. Birthdate : " +
                $"{Birthdate.ToLongDateString()}. {StudentCard.ToString()}";
        }
    }
    class Auditory : IEnumerable
    {

        Student[] students;//null
        public Auditory()
        {
            students = [
                new Student
                {
                     FirstName = "Ivan",
                     LastName = "Popchuk",
                     Birthdate = new DateTime(2000,12,7),
                     StudentCard = new StudentCard { Number = 123456, Series = "AAA" }
                },
                 new Student
                {
                     FirstName = "Olga",
                     LastName = "Oliunuk",
                     Birthdate = new DateTime(2005,12,7),
                     StudentCard = new StudentCard { Number = 111111, Series = "BB" }
                },
                  new Student
                {
                     FirstName = "Mukola",
                     LastName = "Ivanchuk",
                     Birthdate = new DateTime(1999,8,17),
                     StudentCard = new StudentCard { Number = 222222, Series = "CC" }
                },
                   new Student
                {
                     FirstName = "Mira",
                     LastName = "Polishuk",
                     Birthdate = new DateTime(2002,12,7),
                     StudentCard = new StudentCard { Number = 333333, Series = "DD" }
                },
                    new Student
                {
                     FirstName = "Yura",
                     LastName = "Popchuk",
                     Birthdate = new DateTime(2001,12,7),
                     StudentCard = new StudentCard { Number = 444444, Series = "FF" }
                }
            ];
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Print()
        {
            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students, comparer);
        }
    }
    class LastNameComparer : IComparer<Student>
    {
        //public int Compare(object? x, object? y)
        //{
        //    if(x is Student && y is Student)
        //    {
        //        return (x as Student)!.LastName.CompareTo( (y as Student)!.LastName);
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x!.LastName.CompareTo(y!.LastName);
        }
    }
    class BirthdateComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x!.Birthdate.CompareTo(y!.Birthdate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Auditory auditory = new Auditory();
            //auditory.Print();
            //for (int i = 0; i < length; i++)
            //{

            //}
            //Smart pointer
            foreach (Student st in auditory)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("-------------- Sort array -------------");
            auditory.Sort();
            foreach (Student st in auditory)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("-------------- Sort array by last name -------------");
            auditory.Sort(new LastNameComparer());
            foreach (Student st in auditory)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("-------------- Sort array by Birthdate -------------");
            auditory.Sort(new BirthdateComparer());
            foreach (Student st in auditory)
            {
                Console.WriteLine(st.ToString());
            }
            */
            Student st = new Student
            {
                FirstName = "Ivan",
                LastName = "Popchuk",
                Birthdate = new DateTime(2000, 12, 7),
                StudentCard = new StudentCard { Number = 123456, Series = "AAA" }
            };
            Console.WriteLine(st);

            Student copy = (st.Clone() as Student)!;//0x2588  = 0x2588
            //Student copy =(Student) st.Clone();//0x2588  = 0x2588
            Console.WriteLine(copy);

            copy.FirstName = "Oleg";
            copy.StudentCard.Number = 9999999;
            Console.WriteLine(st);
            Console.WriteLine(copy);
        }
    }
}
