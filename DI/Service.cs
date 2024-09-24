using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    interface IMath
    {
        void Add(int x,int y);
    }
    interface IMath1
    {
        void Multiply(int x,int y);
    }
    internal class Service : IMath, IMath1
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("the sum is "+(x+y));
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine("the product is " + (x * y));
        }
    }
}
