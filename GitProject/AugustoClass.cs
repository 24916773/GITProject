using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class AugustoClass
    {
        public int[] getRandom(int iAmnt)// method that sets random numbers in an array for specified amount
        {
            int[] list = new int[iAmnt];
            Random rmd1 = new Random();
            for (int i = 0; i < list.Length; i++)
                list[i] = rmd1.Next(1, 100);// add random numbers to list between 0 and 9

            return list;
        }

        public int getMedian(int[] list)// calculate median of a median
        {
            int iMiddle = 0, iTemp1 = 0, iTemp2 = 0;

            Array.Sort(list);
            if ((list.Length % 2) == 0)
            {
                iTemp1 = (list.Length / 2) - 1;
                iTemp2 = list.Length / 2;
                iMiddle = (list[iTemp1] + list[iTemp2]) / 2;
                return iMiddle;
            }
            else
                iMiddle = list.Length / 2;

            return list[iMiddle];
        }
    }
}
