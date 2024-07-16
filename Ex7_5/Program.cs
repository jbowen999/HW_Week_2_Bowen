namespace Ex7_5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\t\tbool\t\tchar\t\tint\t\tstring\t\tdouble\t\tlong");

            Console.WriteLine("bool\t\tIllegal\t\tIllegal\t\tIllegal\t\tLegal\t\tIllegal\t\tIllegal");
            Console.WriteLine("char\t\tIllegal\t\tLegal\t\tLegal\t\tLegal\t\tIllegal\t\tLegal");
            Console.WriteLine("int\t\tIllegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal");
            Console.WriteLine("string\t\tLegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal");
            Console.WriteLine("double\t\tIllegal\t\tIllegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal");
            Console.WriteLine("long\t\tIllegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal\t\tLegal");

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("General Behavior:");
            Console.WriteLine("- bool: Cannot be combined with other types using the '+' operator, except with strings (concatenation).");
            Console.WriteLine("- char: Can be added to chars, ints, and longs, or concatenated with strings.");
            Console.WriteLine("- int: Can be added to chars, ints, doubles, and longs, or concatenated with strings.");
            Console.WriteLine("- string: Can be concatenated with any type, resulting in a string.");
            Console.WriteLine("- double: Can be added to ints, doubles, and longs, or concatenated with strings.");
            Console.WriteLine("- long: Can be added to chars, ints, doubles, and longs, or concatenated with strings.");
        }
    }
}
