using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class LinqAssignment
    {
        List<Movies> li = new List<Movies>()
            {
                new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas", Actress="Tamanna",YOR=2015 },
                new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas", Actress="Anushka",YOR=2017 },
                new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini", Actress="Aish", YOR=2010 },
                new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir", Actress="kareena", YOR=2009 },
                new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas", Actress="shraddha",YOR=2019 },
            };
        List<Product> li2 = new List<Product>()
{
new Product() { pid = 100, pname = "book", price = 1000, qty = 5 },
new Product() { pid = 200, pname = "cd", price = 2000, qty = 6 },
new Product() { pid = 300, pname = "toys", price = 3000, qty = 5 },
new Product() { pid = 400, pname = "mobile", price = 8000, qty = 6 },
new Product() { pid = 600, pname = "pen", price = 200, qty = 7 },
new Product() { pid = 700, pname = "tv", price = 30000, qty = 7 },
};
        public void mq1()
        {
            var res=from m in li
                    where m.Actor== "Prabhas"
                    select m;
            foreach(var m in res)
            {
                Console.WriteLine(m.MovieName);
            }
        }
        public void mq2()
        {
            var res=from m in li
                    where m.YOR==2019
                    select m;

            foreach (var m in res)
            {
                Console.WriteLine(m.MovieName);
            }
        }
        public void mq3()
        {
            var res=from m in li
                    where m.Actor== "Prabhas" && m.Actress== "Anushka"
                    select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.MovieName);
            }
        }
        public void mq4()
        {
            var res = from m in li
                      where m.Actor == "Prabhas"
                      select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.Actress);
            }
        }
        public void mq5()
        {
            var res = from m in li
                      where m.YOR>=2010 && m.YOR<=2018
                      select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.MovieName);
            }
        }
        public void mq6()
        {
            var res = from m in li
                      orderby m.YOR descending
                      select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.MovieId);
                Console.WriteLine(m.MovieName);
                Console.WriteLine(m.Actor);
                Console.WriteLine(m.Actress);
                Console.WriteLine(m.YOR);

            }
            Console.WriteLine("------------------------------");
        }
        public void mq7()
        {
            var res=from m in li
                    group m by m.Actor into g
                    select new
                    {
                        Actor=g.Key,
                        MovieCount=g.Count()
                    }
                    into result
                    orderby result.MovieCount descending
                    select result; ;
            foreach (var actor in res)
            {
                Console.WriteLine($"Actor: {actor.Actor}, Movies: {actor.MovieCount}");
            }
        }
        public void mq8()
        {
            var res = from m in li
                      where m.MovieName.Length >5
                      select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.MovieName);
            }
        }
        public void mq9()
        {
            var res = from m in li
                      where m.YOR==2015 || m.YOR==2017 || m.YOR==2019
                      select m;
            foreach (var m in res)
            {
                Console.WriteLine(m.YOR);
                Console.WriteLine(m.Actor);
                Console.WriteLine(m.Actress);
            }
        }
        public void mq10()
        {
            var res= from m in li
                     where m.MovieName.StartsWith("b", StringComparison.OrdinalIgnoreCase) && m.MovieName.EndsWith("i", StringComparison.OrdinalIgnoreCase)
                     select m.MovieName;
            foreach (var m in res)
            {
                Console.WriteLine(m);
           
            }

        }
        public void mq11()
        {
            var res = from m in li
                      where m.Actor != "Rajini"
                      orderby m.Actress descending
                      select m.Actress;
            foreach(var m in res)
            {
                Console.WriteLine(m);
            }
        }
        public void mq12()
        {
            var res = from m in li
                      select new
                      {
                          MovieName=m.MovieName,
                          Cast=$"{m.Actor}-{m.Actress}"
                      };
            foreach (var m in res)
            {
                Console.WriteLine($"{m.MovieName}:{m.Cast}");
            }
        }
        public void pq1()
        {
            var res=li2.OrderByDescending(p=>p.price).Select(p=>p.price).Skip(1).First();
            Console.WriteLine(res);
        }
        public void pq2()
        {
            var res = li2.OrderByDescending(p => p.price).Take(3).Select(p => p.price);
            foreach(var m in res)
            {
                Console.WriteLine(m);
            }
        }
        public void pq3()
        {
            var res = li2.Where(p => p.pname.Contains('o')).Sum(p => p.price); ;
            Console.WriteLine($"Sum of Prices (names containing 'O'): {res}");
        }
        public void pq4()
        {
            var res = li2.Where(p => p.pname.EndsWith("e")).Select(p => new {p.pid,p.pname});
            foreach (var m in res)
            {
                Console.WriteLine(m.pid);
                Console.WriteLine(m.pname);
            }
        }
        public void pq5()
        {
            var res = li2.GroupBy(p => p.qty).Select(g => new { qty=g.Key,maxprice=g.Max(p=>p.price)});
            foreach(var m in res)
            {
                Console.WriteLine(m.qty);
                Console.WriteLine(m.maxprice);  
            }
        }
    }
}
