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

        private int randomNumberMin()
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
