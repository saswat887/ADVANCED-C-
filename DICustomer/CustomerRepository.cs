using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICustomer
{
    internal class CustomerRepository
    {
        InterfaceEntities e=new InterfaceEntities();
        public IList<T> ShowAllCustomer<T>(DbSet<T> table)where T:class
        {
            var resultList = new List<T>();
            var res = from t in table
                      select t;
            foreach (var item in res)
            {
                resultList.Add(item);
                var properties = item.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    Console.Write($"{prop.GetValue(item)} ");
                }
                Console.WriteLine();
            }
            return resultList;

        }
        public T ShowById<T>(int id)where T: class
        {
            var res = e.Set<T>().Find(id);
            if (res != null)
            {
                var properties = res.GetType().GetProperties();
                foreach (var prop in properties)
                {
                    Console.Write($"{prop.GetValue(res)} ");
                }
                Console.WriteLine();
            }
            return res;
        }
        public int DeleteById<T>(int id) where T : class 
        {
            var r = e.Set<T>().Find(id);
            e.Set<T>().Remove(r);
            int i = e.SaveChanges();
            Console.WriteLine($"{i} deleted");
            return i;
        }
        public int AddCustomer<T>(T item) where T:class
        {
            e.Set<T>().Add(item);
            int i = e.SaveChanges();
            Console.WriteLine(i + "  record insertion success");
            return i;
        }
    }
}
