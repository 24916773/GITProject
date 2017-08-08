using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class stat
    {
        private int n;
        private int[] randNum;

        public stat(int num)
        {
            n = num;
            randNum = new int[num];
        }

        private void generateNumbers()
        {
            Random randomObj = new Random();

            for (int i = 0; i < n; i++)
            {
                randNum[i] = randomObj.Next(100);
            }
        }
    }
}
