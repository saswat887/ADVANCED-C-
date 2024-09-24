using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICustomer
{
    internal class ICustomer
    {
        ICustomers ic;
        InterfaceEntities e = new InterfaceEntities();
        public ICustomer(ICustomers ic1)
        {
            ic = ic1;
        }
        public void show()
        {

            ic.ShowAllCustomers(e.Customers);
            ic.ShowByid(1);
            ic.DeleteCustomer(10);
            ic.AddCustomer(new Customer { 
            custid=10,
            custname="Saswat"});
        }
        
    }
}
