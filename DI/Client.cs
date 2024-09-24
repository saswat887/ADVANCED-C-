using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class Client
    {
        IMath math;
        IMath1 math1;
        /*  public Client(IMath m,IMath1 m1) 
        {
            math = m;
            math1 = m1;
        }*/

        public Client(IMath m, IMath1 m1) 
        {
            math= m;
            math1 = m1;
        }
        public void show()
        {
            math.Add(10, 20);
            math1.Multiply(10, 20); 
        }
       /* public IMath m { get; set; }
        public IMath1 m1 { get; set; }

        public void show(IMath m, IMath1 m1)
        {
            m.Add(34,45);
            m1.Multiply(34, 56);
        }*/

    }
} 
