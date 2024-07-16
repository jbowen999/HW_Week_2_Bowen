namespace Ex6_2
{
    internal class Program
    {
        /// <summary>
        /// The code provided has a problem due to the way floating-point arithmetic works in computers. 
        /// The variable count is a double, which means it cannot precisely represent all decimal numbers. 
        /// When adding 0.1 repeatedly to count, the result is subject to floating-point precision errors, 
        /// meaning count will not exactly equal 1.0 even after enough iterations.
        /// </summary>
        /// <param name="args"></param>
        /// 

        //static void Main(string[] args)
        //{
        //    double count = 0.0;
        //    while (count != 1.0)
        //    {
        //        count = count + 0.1;
        //        Console.Write("{0:R}", count);
        //        Console.ReadLine();
        //    }
        //}

        // Below is the corrected code. Instead of dealing with the limits of floating point arithmatic,
        // I just make it look like the count is going up
        // by 0.1 every time, but in reality I am using whole numbers.
        static void Main(string[] args)
        {
            double count = 0.0;
            while (count != 10.0)
            {
                count++;
                Console.Write("{0:R}", count / 10.0);
                Console.ReadLine();
            }
        }

    }
}
