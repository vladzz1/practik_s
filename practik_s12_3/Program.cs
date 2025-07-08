namespace practik_s12_3
{
    static class StringExtension
    {
        public static bool isPalindrom(this string word)
        {
            char[] word2 = word.ToCharArray();
            string reverse = "";
            for (int i = word2.Length - 1; i >= 0; i--)
            {
                reverse = reverse + word2[i];
            }
            if (word == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string encryption(this string word, int key)
        {
            char[] word2 = word.ToCharArray();
            string newWord = "";
            char symbol;
            for (int i = 0; i < word2.Length; i++)
            {
                symbol = (char)(word2[i] + key);
                newWord = newWord + symbol;
            }
            return newWord;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "madam";
            Console.WriteLine(word1.isPalindrom());

            Console.WriteLine("\n----------");
            string word2 = "привіт";
            Console.WriteLine(word2.encryption(3));
        }
    }
}
