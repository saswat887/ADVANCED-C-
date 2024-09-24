using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomers ic = new CustomerServices();
            ICustomer ic1=new ICustomer(ic);  
            ic1.show();
            Console.ReadKey();
        }
    }
}
