using System.Text;

namespace practik_s15_2
{
    internal class Program
    {
        static void WriteFile(string path)
        {
            //FileStream fileStream = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write,
            //     FileShare.Read | FileShare.Write);
            //fileStream.Write();
            ////throw ex;
            //fileStream.Read();
            //fileStream.Close();

            //FileStream fileStream = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write,
            //     FileShare.Read | FileShare.Write);
            //try
            //{
            //    //Doing.....
            //}
            //finally
            //{
            //    fileStream.Close();
            //}

            using (FileStream fs = new FileStream(path, FileMode.Create,
                FileAccess.Write, FileShare.None))
            {

                Console.WriteLine("Enter some text : ");
                string writeText = Console.ReadLine();

                byte[] writeBites = Encoding.Default.GetBytes(writeText);
                fs.Write(writeBites, 0, writeBites.Length);

                Console.WriteLine("File was recorded!!!!");

            }//fileStream.Dispose();

        }
        static string ReadFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open,
                FileAccess.Read))
            {
                byte[] readBytes = new byte[fs.Length];
                fs.Read(readBytes, 0, readBytes.Length);
                return Encoding.Default.GetString(readBytes);
            }
        }
        static void WriteTextFormat(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write("Hello!");
                sw.Write("Hello!");
                sw.Write("Hello!");
                sw.Write("Hello!");
                sw.WriteLine("How are you?");
                sw.WriteLine("How are you?");
                sw.WriteLine("How are you?");
            }
        }
        static void ReadTextFormat(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                //sr.Read();
                //sr.ReadBlock();
                //sr.ReadLine();
                //sr.ReadToEnd();

                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine() + "!!!");
                }
            }
        }
        static void Main(string[] args)
        {
            //string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\text.txt";
            //WriteFile(path);
            //Console.WriteLine(ReadFile(path));

            string path1 = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Stringtext.txt";
            WriteTextFormat(path1);
            ReadTextFormat(path1);

            //FileStream file = null;
            ////file = new FileStream(@"test.txt", FileMode.Create);
            ////file = File.Open(@"test.txt", FileMode.Open, FileAccess.Write, FileShare.Write);                      
            //file = File.Create(@"test1.txt");

            //// 1.
            //var writer = new StreamWriter(file);
            //writer.Write("Hello");
            //writer.WriteLine("\tworld");
            //writer.Close();
            //file?.Close(); // null-conditional operator

            //// 2.
            //writer = File.CreateText(@"test2.txt");
            //writer.WriteLine("Hello");
            //writer.Close();

            //// 3.
            //File.WriteAllText(@"test3.txt", "Hello");

            #region StreamReader and StreamWriter
            /*
             *  string path = @"test.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                   
                    Console.WriteLine(sr.ReadToEnd());
                }

                Console.WriteLine();

                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line;                    
                    while ((line = sr.ReadLine()) != null)
                    {                        
                        Console.WriteLine($"<{line}>");
                    }
                }

                Console.WriteLine();
 
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    char[] array = new char[4];
                    sr.Read(array, 0, 4);
                    Console.WriteLine(array);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

              string readPath = @"read.txt";
            string writePath = @"write.txt";
            string text = "";
            try
            {
                using (StreamReader sr = new StreamReader(readPath, Encoding.Default))
                {
                    text = sr.ReadToEnd();
                }
                using (StreamWriter sw = new StreamWriter(writePath, false, Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                {
                    sw.WriteLine("Append");
                    sw.Write(454875);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var reader = File.OpenText(@"test.txt");
          

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line != null && line.Contains("Andrew"))
                {
                    Console.WriteLine("Found:");
                    Console.WriteLine(line);
                    break;
                }
            }

            reader.Close();
            Console.ReadKey();
             
             */
            #endregion

            #region Binary Writer , Binary Reader

            //FileStream file = File.Create(@"info.bin");

            //BinaryWriter writer = new BinaryWriter(file);

            //long number = 100;
            //var bytes = new byte[] { 10, 20, 50, 100 };
            //var ints = new int[] { 10, 20, 50, 100 };
            //string s = "hunger";

            //writer.Write(number);
            //writer.Write(bytes);
            //writer.Write(s);

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    writer.Write(ints[i]);
            //}

            //writer.Close();

            //Console.ReadKey();

            FileStream file = File.Open(@"info.bin", FileMode.Open);

            var reader = new System.IO.BinaryReader(file);

            long number = reader.ReadInt64();
            byte[] bytes = reader.ReadBytes(4);
            string s = reader.ReadString();
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = reader.ReadInt32();
            }

            reader.Close();

            Console.WriteLine(number);
            foreach (byte b in bytes)
            {
                Console.Write("[{0}]", b);
            }

            Console.WriteLine();
            Console.WriteLine(s);
            foreach (var item in arr)
            {
                Console.WriteLine(item + " ");
            }

            Console.ReadKey();
            #endregion
        }
    }
}
