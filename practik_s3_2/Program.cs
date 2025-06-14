namespace practik_s3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //0 ... false ... null
            string fname, lname;
            fname = "Roman";
            lname = "Polishchuk";

            string fullname = fname + " " + lname;
            Console.WriteLine($"Full name : {fullname}");

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            
            Console.WriteLine(letters.Length);
            Console.WriteLine(fullname.Length);
            string str = new string("letters");//string str = "letters";
            //string greeting = new string(letters, 0, letters.Length);
            //Console.WriteLine($"Greeting : {greeting}");
            Console.WriteLine($"Greeting : {str}");

            string[] array = { "Hello", "From", "Summer", "Sun", "Tree", "Lake" };
            
            string message = string.Join(" - ", array);
            Console.WriteLine("My message : " + message);

            Console.WriteLine($"Message : {message}");

            Console.WriteLine("Message : {0}, {1}, {2}", message, 45, 12);

            string []splictArr = message.Split(new string[] {" - "}, 
                StringSplitOptions.None);
            foreach (string s in splictArr)
            {
                Console.WriteLine(s);
            }

            string htmlMessage = "HTML is a standardized document markup language for viewing " +
               "web pages in a browser. Browsers receive an HTML document from the " +
               "server using HTTP/HTTPS protocols or open it from a local disk, " +
               "then interpret the code into the interface that will be displayed " +
               "on the monitor screen. ";
           string []words = htmlMessage.Split(new char[] { ' ', '.', ',', '!', '/', '-', '?' },
               StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Count of words : " + words.Length);
            foreach (string s in words)
            {
                Console.WriteLine(s);   
            }

            //ConsoleKeyInfo key =  Console.ReadKey();
            //if(key.Key == ConsoleKey.F12)
            //{
            //    Console.WriteLine("F12 - Have a nice day!!!");
            //}
            //else
            //{
            //    Console.WriteLine("Do your homework!!!");
            //}

            DateTime dateNow = DateTime.Now;
       
            Console.WriteLine(dateNow);
            Console.WriteLine(dateNow.ToString());
            Console.WriteLine(dateNow.ToLongDateString());
            Console.WriteLine(dateNow.ToShortDateString());
            Console.WriteLine(dateNow.ToLongTimeString());
            Console.WriteLine(dateNow.ToShortTimeString());
            Console.WriteLine(dateNow.ToString("yyyy-MM-dd"));
            //Console.ReadKey();

            //DateTime dateEvent = dateNow;           
            //dateEvent = dateEvent.AddDays(7);
            //dateEvent = dateEvent.AddHours(1.5);
         
            DateTime dateEvent = new DateTime(2025, 7, 21);

            TimeSpan timeSpan = dateEvent - dateNow;

            Console.WriteLine($"Time Span {timeSpan.ToString()} ");
            Console.WriteLine($"Milliseconds : {timeSpan.Milliseconds}");
            Console.WriteLine($"Seconds : {timeSpan.Seconds}");
            Console.WriteLine($"Minutes : {timeSpan.Minutes}");
            Console.WriteLine($"Hours : {timeSpan.Hours}");
            Console.WriteLine($"Days : {timeSpan.Days}");
            Console.WriteLine($"Days : {timeSpan.Ticks}");

            Console.WriteLine($"Total Milliseconds : {timeSpan.TotalMilliseconds}");
            Console.WriteLine($"Total Seconds : {timeSpan.TotalSeconds}");
            Console.WriteLine($"Total Minutes : {timeSpan.TotalMinutes}");
            Console.WriteLine($"Total Hours : {timeSpan.TotalHours}");
            Console.WriteLine($"Total Days : {timeSpan.TotalDays}");


            decimal money = 41.90m;
            //CultureInfo us = new CultureInfo("PL-pl");
            //CultureInfo us = new CultureInfo("ka-GE");
            CultureInfo us = new CultureInfo("UA-ua");
            //CultureInfo us = new CultureInfo("ko-KR");
            //CultureInfo us = new CultureInfo("en-US");
            //CultureInfo us = new CultureInfo("fr-FR");
            string course = $" Today course of dollar is : {money.ToString("C2",us)}";
            Console.WriteLine(course);

            string nullStr = null;

            if (nullStr != null)
                nullStr.ToUpper();
            //Console.WriteLine(nullStr.Length);
            //null-conditional
            nullStr?.ToLower();  // ? --  if (nullStr != null)
            Console.WriteLine(nullStr?.Length);

            string strEmpty = "";
            Console.WriteLine(strEmpty.Length);

            if (string.IsNullOrEmpty(nullStr) && string.IsNullOrEmpty(strEmpty))
            {
                Console.WriteLine("Is null or empty");
            }

            string str2 = "              ";
            Console.WriteLine(str2.Length);
            if (string.IsNullOrWhiteSpace(str2))
            {
                Console.WriteLine("Is null or white Spaces...");
            }

            // Comparing 2 strings 
            string str11 = "This is test";
            string str12 = "This is text";

            if (string.Compare(str11, str12) == 0)
            {
                Console.WriteLine(str11 + " and " + str12 + " are equal.");
            }
            else
            {
                Console.WriteLine(str11 + " and " + str12 + " are not equal.");
            }
            //String Contains String:
            string str3 = "This is testing";
            if (str3.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' was found.");
            }

            //Getting a Substring:
            string str4 = "Last night I dreamt of San Pedro";
            Console.WriteLine(str4);
            string substr = str4.Substring(23);
            Console.WriteLine(substr);

            //Joining Strings:
            string[] starray = new string[]{"Down, the way nights, are dark",
                                            "And the sun shines daily on the mountain top",
                                            "I took, a trip, on,a sailing ship",
                                            "And when I reached Jamaica",
                                            "I made a stop"};

            string str5 = string.Join("!\n", starray);
            Console.WriteLine(str5);

            string[] words2 = str5.Split(new char[] { ' ', ',', '\n', '?', '!' }, 
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words2)
            {
                Console.WriteLine("Word: " + item);
            }
            */
            //String interpolations

            //C / c
            //Задає формат грошової одиниці, вказує кількість десяткових розрядів після коми
            //
            //D / d
            //Цілочисельний формат, вказує мінімальну кількість цифр
            //
            //E / e
            //Експонентне подання числа, вказує кількість десяткових розрядів після коми
            //
            //F / f
            //Формат дробових чисел із фіксованою точкою, вказує кількість десяткових розрядів після коми
            //
            //G / g
            //Задає коротший із двох форматів: F або E
            //
            //N / n
            //Також задає формат дробових чисел із фіксованою точкою, визначає кількість розрядів після коми
            //
            //P / p
            //Задає відображення знака відсотків поряд з числом, вказує кількість десяткових розрядів після коми
            //
            /*
            int number = 23;

            Console.WriteLine(number);

            Console.WriteLine("Number {0:d2}", number);

            string result = String.Format("Number: {0:d4}", number);
            Console.WriteLine(result); // 23

            //string result2 = String.Format("{0:d4}", number);
            string result2 = $"Number : {number:d5}";
            Console.WriteLine(result2); // 0023

            int number1 = 23;
            string result1 = String.Format("{0:f4}", number1);
            Console.WriteLine(result1); // 23,00

            double number2 = 45.08;
            //string result3 = String.Format("{0:f4}", number2);
            string result3 = $"Number: {number2:f4}";
            Console.WriteLine(result3); // 45,0800

            long number4 = 19876543210;
            string result5 = String.Format("{0:+# (###) ###-##-##}", number4);
            string result6 = $"{number4:+# (###) ###-##-##}";
            Console.WriteLine(result5); // +1 (987) 654-32-10
            Console.WriteLine(result6); // +1 (987) 654-32-10

            //was            
            var anInt = 1;
            var aBool = true;
            var aString = "3";
            var formated = string.Format("{0},{1},{2}", anInt, aBool, aString);
            Console.WriteLine(formated);
            //become
            var anInt1 = 1;
            var aBool1 = true;
            var aString1 = "3";
            var formated1 = $"{anInt1:f4},{aBool1},{aString1}";
            //Console.WriteLine(formated1);

            var someDir = "a";
            Console.WriteLine($@"c:\{someDir}\b         
mvbjcvl;bncv;
xcvxckbvx
            kjhrgksjerhglearhglierhg
erjkghaer               kherlkf
            ejhjer

\c");
*/
            //
            Console.WriteLine($"Name: {"Ivan",-10} Age: {23,10}"); // spaces before
            Console.WriteLine($"Name: {"Veronika",-10} Age: {34,10}"); // spaces after


            //Concatanation
            string s1 = "hello";
            string s2 = "world";
            string s3 = s1 + " " + s2; // = string "hello world"
            string s4 = System.String.Concat(s3, "!!!"); // = string "hello world!!!"
            Console.WriteLine(s4);

            string s5 = "apple";
            string s6 = "a day";
            string s7 = "keeps";
            string s8 = "a doctor";
            string s9 = "away";
            string[] values = new string[] { s5, s6, s7, s8, s9 };

            String s10 = String.Join(" ", values);
            Console.WriteLine(s10);

            //Finding in string 
            string s11 = "hello world";
            char ch = 'o';
            int indexOfChar = s11.IndexOf(ch); // = 4
            Console.WriteLine(indexOfChar);

            string subString = "wor";
            int indexOfSubstring = s11.IndexOf(subString); // = 6
            Console.WriteLine(indexOfSubstring);


            //broken string
            string text = "This is the last day of ^ ^ ^       winter";

            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string[] words1 = text.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words1)
            {
                Console.WriteLine(s);
            }

            string s12 = " ? Me tengo?!, To be honest!!!   ";
            s12 = s12.TrimStart(new char[] { '?', ' ', '!' });
            Console.WriteLine($"After trimming: /{s12}/");
            s12 = s12.TrimEnd(new char[] { '?', ' ', '!' });
            Console.WriteLine($"After trimming: /{s12}/");
            //s12 = s12.Trim(new char[] { '?', ' ', '!' });
            //Console.WriteLine($"After trimming: /{s12}/");
        }
    }
}
