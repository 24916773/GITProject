using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class stat
    {
        public double CalculateSD(int[] arr)
        {
            double tmp = arr.Average();
            double total = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                total = +arr[i] - tmp;
            }
            return Math.Round(total / arr.Length);
        }

       public int GCD(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }

        public int GCD(int x, int y)
        {
            return y == 0 ? x : GCD(y, x % y);
        }

        public double calcMean(int[] arr)
        {
            double ave;

            ave = arr.Average();
            return ave;
        }
    }
}
