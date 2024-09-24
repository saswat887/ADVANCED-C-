using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class q1Cliient
    {
       
        public void show(IMathq1 array, int[] data)
        {
            Console.WriteLine("SUM="+array.findSUM(data));
            Console.WriteLine("MAX="+array.findMAX(data));
        }
    }
}
