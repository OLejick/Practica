using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            int m1 = 0;
            int m2 = 0;
            int summ = 0;
            int summ2 = 0;
            int summ3 = 0;

            //for
            if (n % 2 != 0)
            {
                m1 = n;
                for (int i = m1; i < m1 * 2; i += 2)
                {
                    summ += i;

                }
                Console.WriteLine($"for:{summ}");
            }
            else
            {
                m1 += n + 1;
                for (int i = m1; i < m1 * 2; i += 2)
                {
                    summ += i;

                }
                Console.WriteLine($"for:{summ}");
            }

            //while
            if (n % 2 != 0)
            {
                m = n;
                while (m < n * 2)
                {
                    summ2 += m;
                    m += 2;
                }
                Console.WriteLine($"while:{summ2}");
            }
            else
            {
                m += n + 1;
                while (m < (n+1) * 2)
                {
                    summ2 += m;
                    m += 2;
                }
                Console.WriteLine($"while:{summ2}");
            }

            //do...while
            if (n % 2 != 0)
            {
                m2 = n;
                do
                {
                    summ3 += m2;
                    m2 += 2;
                }while (m2 < n * 2);
                
                Console.WriteLine($"do...while:{summ3}");
            }
            else
            {
                m2 += n + 1;
                do
                {
                    summ3 += m2;
                    m2 += 2;
                } while (m2 < n * 2);

                Console.WriteLine($"do...while:{summ3}");
            }
            
        }
    }
}
