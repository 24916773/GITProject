using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class statChris
    {
        private int n;
        private int[] randNum;

        public statChris(int n)
        {
            this.n = n;
            randNum = new int[n];
            generateNumbers();
            minNumber();
        }

        private void generateNumbers()
        {
            Random randomObj = new Random();

            for (int i = 0; i < n; i++)
            {
                randNum[i] = randomObj.Next(100);
            }
        }

        public int minNumber()
        {
            int smallest = randNum[0];
            for (int i = 1; i < n; i++)
            {
                if (randNum[i] < smallest)
                {
                    smallest = randNum[i];
                }
            }
            return smallest;
        }
    }
}
