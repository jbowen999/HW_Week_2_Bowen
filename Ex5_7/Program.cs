namespace Ex5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Julian";
            Console.WriteLine(First(s));
            Console.WriteLine(Rest(s));
            Console.WriteLine(Length(s));
            WriteString(s);
            WriteBackward(s);
            Console.WriteLine(ReverseString(s));
        }

        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }

        // rest: returns a new string that contains all but the
        // first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }

        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }

        // WriteString: writes each character of the given string
        // on a new line
        public static void WriteString(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        // WriteBackward: writes each character of the given string
        // on a new line, starting from the last character and ending
        // with the first
        public static void WriteBackward(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(s[i]);
            }
        }

        // ReverseString: returns a new string that is the reverse
        // of the given string
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
