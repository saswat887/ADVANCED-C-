using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICustomer
{
    interface ICustomers{
        IList<Customer> ShowAllCustomers(DbSet table);
        Customer ShowByid(int id);
        int DeleteCustomer(int id);
        int AddCustomer(Customer custobj);
    }
    internal class CustomerServices : ICustomers
    {
        InterfaceEntities e=new InterfaceEntities();
        CustomerRepository cr=new CustomerRepository();
        public int AddCustomer(Customer c)
        {
            return cr.AddCustomer(c);
        }

        public int DeleteCustomer(int id)
        {
            return cr.DeleteById<Customer>(id);
        }

        public IList<Customer> ShowAllCustomers(DbSet table)
        {
            return cr.ShowAllCustomer(e.Customers);
        }

        public Customer ShowByid(int id)
        {
            return cr.ShowById<Customer>(id);
        }
    }
}
