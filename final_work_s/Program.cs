namespace final_work_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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
                        Console.WriteLine($"Directory: {d.Name,20}  time: {d.CreationTime,20} atr: {d.Attributes,10}");
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Files ------------------------------------------------------------------------------------------");
                    foreach (var file in dir.GetFiles())
                    {
                        Console.WriteLine($"File: {file.Name,30}  time:  {file.CreationTime,20} atr: {file.Attributes,25}");
                    }

                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(path + @"\");
                    string next = Console.ReadLine()!;
                    Console.ResetColor();

                    string nextPath = Path.Combine(path, next);

                    Console.WriteLine("1 - Delete\n" +
                                      "2 - Rename\n" +
                                      "3 - Create\n" +
                                      "* - Open");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                            Directory.Delete(nextPath);
                            break;
                        case ConsoleKey.D2:
                            Console.Write("\nEnter a new folder name: ");
                            string newName = Console.ReadLine()!;
                            Directory.Move(nextPath, Path.Combine(path, newName));
                            break;
                        case ConsoleKey.D3:
                            Directory.CreateDirectory(nextPath);
                            break;
                        default:
                            path = nextPath;
                            break;
                    }
                } while (true);
        }
    }
}