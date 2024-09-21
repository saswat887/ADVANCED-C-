using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class Repo
    {
        studentsdbEntities dc = new studentsdbEntities();
        public void Add<T>(T item) where T : class
        {
            dc.Set<T>().Add(item);
            int i = dc.SaveChanges();
            Console.WriteLine(i + "  record insertion success");
        }
        public void Delete<T>(int d) where T : class
        {
            var r = dc.Set<T>().Find(d);
            dc.Set<T>().Remove(r);
            int i= dc.SaveChanges();
            Console.WriteLine($"{i} deleted");
        }
        public T Search<T>(int id) where T : class
        {
            var r = dc.Set<T>().Find(id);
            return r;
        }
    }
}
