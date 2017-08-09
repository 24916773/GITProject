using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class AugustoClass
    {
        public int[] GetRandomArray(int iAmnt)// method that sets random numbers in an array for specified amount
        {
            int[] list = new int[iAmnt];
            Random rmd1 = new Random();
            for (int i = 0; i < list.Length; i++)
                list[i] = rmd1.Next(1, 100);// add random numbers to list between 0 and 9

            return list;
        }
    }
}
