namespace final_work_s
{
    class MyTotalComander
    {
        string path { get; set; }
        string nextPath { get; set; }
        public MyTotalComander()
        {
            path = new string(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            nextPath = new string("");
        }
        public void start()
        {
            do
            {
                Console.Clear();
                DirectoryInfo dir = new DirectoryInfo(path);

                Console.WriteLine($"Directory: \t{dir.FullName}");
                Console.WriteLine($"CreationTime: \t{dir.CreationTime}");
                Console.WriteLine($"Extension: \t{dir.Extension}");
                Console.WriteLine($"LastAccessTime: {dir.LastAccessTime}");
                Console.WriteLine($"LastWriteTime: \t{dir.LastWriteTime}");
                Console.WriteLine($"Name: \t\t{dir.Name}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Directories ------------------------------------------------------------------------------------");
                foreach (var d in dir.GetDirectories())
                {
                    Console.WriteLine($"Directory: {d.Name,25}  time: {d.CreationTime,20} atr: {d.Attributes,10}");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Files ------------------------------------------------------------------------------------------");
                foreach (var file in dir.GetFiles())
                {
                    Console.WriteLine($"File: {file.Name,30}  time:  {file.CreationTime,19} atr: {file.Attributes,25}");
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(path + @"\");
                string next = Console.ReadLine()!;
                Console.ResetColor();

                nextPath = Path.Combine(path, next);

                Console.WriteLine("1 - Delete\n2 - Rename\n3 - Create\n* - Open");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        delete();
                        break;
                    case ConsoleKey.D2:
                        rename();
                        break;
                    case ConsoleKey.D3:
                        create();
                        break;
                    default:
                        path = nextPath;
                        break;
                }
            } while (true);
        }
        void delete()
        {
            Console.WriteLine("are you sure you want to delete this object?\n1 - yes\n2 - no");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    return;
                default:
                    break;
            }
            Directory.Delete(nextPath);
        }
        void rename()
        {
            Console.Write("\nEnter a new folder name: ");
            string newName = Console.ReadLine()!;
            Directory.Move(nextPath, Path.Combine(path, newName));
        }
        void create()
        {
            Directory.CreateDirectory(nextPath);
        }
    }
}