using System;

namespace DP_Ugly_Numbers
{
    // https://www.geeksforgeeks.org/ugly-numbers/
    /// <summary>
    /// Ugly Numbers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the nth Ugly no you want!");
                var input = Console.ReadLine();
                Console.WriteLine("{0} Ugly no is : {1}", input, GetNThUglyNumber(Convert.ToInt32(input)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static long GetNThUglyNumber(int n)
        {
            long i = 0;
            int count = 0;

            while(n > count)
            {
                if (IsUgly(++i))
                    count++;
            }

            return i;
        }

        static bool IsUgly(long i)
        {
            long no = MaxDivide(i, 2);
            no = MaxDivide(no, 3);
            no = MaxDivide(no, 5);

            return no == 1;
        }

        static long MaxDivide(long i, int j)
        {
            while (i % j == 0)
            {
                i = i / j;
            }
            return i;

        }
    }
}
