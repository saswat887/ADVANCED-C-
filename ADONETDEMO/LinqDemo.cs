using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class LinqDemo
    {
        public void Demo1()
        {
            string[] countries = { "India","Canada","UK","USA"};
            foreach(string country in  countries)
            {
                if (country.StartsWith("U"))
                {
                    Console.WriteLine(country);
                }
            }
        }
        public void Demo2()
        {
            string[] countries = { "India", "Canada", "UK", "USA" };
            var res=from t in countries
                    where t.StartsWith("U")
                    select t;

            foreach (string country in res) 
            {
                Console.WriteLine(country);
            }
        }
        public void Demo3()
        {
            int[] x = { 1,2,3,4,5,6,7,78,8};
            var res = from t in x
                      where t % 2 == 0
                      select t;
            foreach(int s in res)
            {
                Console.WriteLine(s);
            }
        }
        public void Demo4()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { pid = 1, pname = "books", description = "c#", price = 120 },
                new Product() { pid = 2, pname = "cd", description = "sony", price = 80 },
                new Product() { pid = 3, pname = "moniter", description = "dell", price = 6000 },
                new Product() { pid = 4, pname = "mobile", description = "oppo", price = 10000 },
                new Product() { pid = 5, pname = "keyboard", description = "hp", price = 1400 },
            };
            /* var res = from t in products
                       where t.price > 1000
                       select t;*/

            /*     var res = from t in products
                           where t.price > 1000
                           select new { t.pid,t.pname};*/

        /*    var res = from t in products
                      where t.price > 1000
                      select new { piid=t.pid, pname=t.pname };

            foreach (var p in res)
            {
                Console.WriteLine(p.piid);
                Console.WriteLine(p.pname);
            }*/
            var res1 = from t in products
                       orderby t.price descending
                       select t;
            foreach (var p in res1)
            {
                Console.WriteLine(p.pid);
                Console.WriteLine(p.pname);
                Console.WriteLine(p.description);
                Console.WriteLine(p.price);
            }
        }
        public void Demo5() 
        {
            List<Product> products = new List<Product>()
            {
                new Product() { pid = 1, pname = "books", description = "c#", price = 120 },
                new Product() { pid = 2, pname = "cd", description = "sony", price = 80 },
                new Product() { pid = 3, pname = "moniter", description = "dell", price = 6000 },
                new Product() { pid = 4, pname = "mobile", description = "oppo", price = 10000 },
                new Product() { pid = 5, pname = "keyboard", description = "hp", price = 1400 },
            };

            //    var res = products.Where(t => t.price > 5000);

            //  var res = products.Take(2);

            //     var res = products.Skip(2);
            //   var res = products.TakeWhile(t => t.price != 10000);

            var res = products.Where(t => t.price > 5000).OrderByDescending(t=>t.price);

            foreach (var p in res)
            {
                Console.WriteLine(p.pid);
                Console.WriteLine(p.pname);
                Console.WriteLine(p.description);
                Console.WriteLine(p.price);
            }
        }
       
    }
}
