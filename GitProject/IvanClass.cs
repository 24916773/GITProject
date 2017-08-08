using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class IvanClass
    {
        Random random = new Random();
        int maxi;
        public int Randomizer()
        {
            
            return random.Next(1,100);
        }
       public int largest(int[] arr)
        {
            maxi = arr.Max();
            return maxi;
        }
    }
}
