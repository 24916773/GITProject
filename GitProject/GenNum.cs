using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProject
{
    class GenNum
    {
        Random r = new Random();

        public int Generate()
        {
            return r.Next(1, 10);
        }
    }
}
