using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class ChrisClass
    {
        private int n;
        private int[] randNum;

        public ChrisClass(int num)
        {
            n = num;
            randNum = new int[n];
            generateRandomNumbers();
        }

        private void generateRandomNumbers()
        {
            Random randGen = new Random();
            for(int i = 0; i < n; i++)
            {
                randNum[i] = randGen.Next(100);
            }
        }

        public int minimumRandom()
        {
            int smallest = randNum[0];
            for(int i = 1; i < n; i++)
            {
                if(randNum[i] < smallest)
                {
                    smallest = randNum[i];
                }
            }
            return smallest;
        }
    }
}
