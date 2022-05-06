using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber2
{
    internal class HarmonicNumber
    {
        double sum = 0.0;
        public void findHarmonicNum()
        {
            Console.WriteLine("Find the nth Harmonic value");
            Console.Write("\n\n");
            Console.Write("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for (float i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine("Sum of series up to {0} terms: {1}", n, sum);
        }

    }
}
