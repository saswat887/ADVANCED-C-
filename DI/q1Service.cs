using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    interface IMathq1
    {
        int findMAX(int[] a);
        int findSUM(int[] a);
    }
    internal class q1Service : IMathq1
    {
        public int findMAX(int[] a)
        {
            var res = a.Max();
            return res;
        }

        public int findSUM(int[] a)
        {
            var res = a.Sum();
            return res; ;
        }
    }
}
