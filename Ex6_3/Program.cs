namespace Ex6_3
{
    internal class Program
    {
        static void Main()
        {
            double number = 9.0;
            double sqrt = SquareRoot(number);
            Console.WriteLine($"Approximate square root of {number} is {sqrt}");
        }

        static double SquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Cannot compute square root of a negative number");
            }

            double x0 = a / 2;
            double x1 = (x0 + a / x0) / 2;

            while (Math.Abs(x1 - x0) >= 0.0001)
            {
                x0 = x1;
                x1 = (x0 + a / x0) / 2;
            }

            return x1;
        }
    }
}
