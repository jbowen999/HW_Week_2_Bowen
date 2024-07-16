namespace Ex5_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Prod(1, 4));
        }
        /// <summary>
        /// 
        /// Main: (Stack diagram)
        //  Prod(1, 4)
        //      |
        //      |-- Prod(1, 3)
        //              |
        //              |-- Prod(1, 2)
        //                      |
        //                      |-- Prod(1, 1) -> returns 1

        /// This function calculates the product of integers from 'm' to 'n'. 
        /// If 'm' is equal to 'n', it returns 'n'. 
        /// Otherwise, it recursively calculates the product of integers from 
        /// 'm' to 'n-1` and then multiplies the result by 'n'
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>Product of integers from 'm' to 'n' >> (1,4) >> (1 x 2 x 3 x 4)</returns>
        public static int Prod(int m, int n)
        {
            if (m == n)
            {
                return n;
            }
            else
            {
                return n * Prod(m, n - 1);
            }
        }
    }
}