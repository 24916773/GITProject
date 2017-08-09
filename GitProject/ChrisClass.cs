using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class ChrisClass
    {
        public ChrisClass()
        {

        }

        public int[] GetRandomNumbers(int n)
        {
            int[] randNum = new int[n];
            Random randGen = new Random();
            for(int i = 0; i < n; i++)
            {
                randNum[i] = randGen.Next(100);
            }
            return randNum;
        }
    }
}
