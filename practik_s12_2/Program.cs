namespace practik_s12_2
{
    //Call back function

    public delegate void FinishAction();
    public delegate void ExamDelegate(string t);//MulticastDelegate

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"Student : {LastName} {FirstName} pass the exam {task}");
        }
    }
    class Teacher
    {
        //private ExamDelegate ExamDelegate;//all students --> null
        //public ExamDelegate ExamDelegate;//all students --> null

        //private delegate + public event (as Auto property) 
        public event ExamDelegate ExamDelegate;//all students --> null

        //Full Delegate
        private ExamDelegate _examDelegate;
        public event ExamDelegate ExamEvent
        {
            add
            {
                _examDelegate += value;
                Console.WriteLine(value.Method.Name + " was added");
            }
            remove
            {
                _examDelegate -= value;
                Console.WriteLine(value.Method.Name + " was removed");
            }
        }
        public event Action TestEvent;
        public void CreateExam(string task)
        {
            //some task
            //create
            //call all students
            //ExamDelegate?.Invoke(task);
            _examDelegate?.Invoke(task);
        }
        public void StartAction()
        {
            TestEvent.Invoke();
        }
    }
    internal class Program
    {
        static void HardWork(FinishAction action)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} working.....");
                Thread.Sleep(1000);
                Console.WriteLine($"Operation {i + 1} finish.....");
            }
            //some message 
            action();
        }
        static void Action1()
        {
            Console.WriteLine("Excellent!!!!!");
        }
        static void Action2()
        {
            Console.WriteLine("Very good!!!!!");
        }
        static void Main(string[] args)
        {
            //HardWork(Action1);
            //HardWork(Action2);
            //HardWork(delegate () { Console.WriteLine("Good"); });
            List<Student> students = new List<Student>() {
                new Student()
                {
                     FirstName = " Olga",
                      LastName = "Oliunuk",
                       Birthdate = new DateTime(2000,12,4)
                },
                 new Student()
                {
                     FirstName = " Petro",
                      LastName = "Oliunuk",
                       Birthdate = new DateTime(2003,12,4)
                },
                  new Student()
                {
                     FirstName = " Mukola",
                      LastName = "Oliunuk",
                       Birthdate = new DateTime(2002,12,4)
                },
                   new Student()
                {
                     FirstName = " Ira",
                      LastName = "Oliunuk",
                       Birthdate = new DateTime(2001,12,4)
                },
                    new Student()
                {
                     FirstName = " Nikita",
                      LastName = "Oliunuk",
                       Birthdate = new DateTime(2000,12,4)
                }
            };

            Teacher teacher = new Teacher();
            foreach (Student student in students)
            {
                //teacher.ExamDelegate +=  new ExamDelegate(student.PassExam);
                teacher.ExamEvent += new ExamDelegate(student.PassExam);
            }
            //teacher.ExamDelegate = null;
            teacher.ExamEvent -= students[students.Count - 1].PassExam;

            teacher.CreateExam("Exam OOP C++");

            //teacher.TestEvent = null;///error
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent += Console.Clear;
            teacher.TestEvent -= Console.Clear;
            teacher.TestEvent += delegate () { Console.BackgroundColor = ConsoleColor.Green; };
            teacher.TestEvent -= delegate () { Console.BackgroundColor = ConsoleColor.Green; };
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent += Teacher_TestEvent;
            teacher.TestEvent -= Teacher_TestEvent;

            teacher.StartAction();
        }
        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto-Created method by pressing TAB!!! ");
        }
    }
}
