using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class LinqEntityAss
    {
        studentsdbEntities dc=new studentsdbEntities();
        public void q1()
        {
            var res=from t in dc.customers
                    select t;
            foreach (var t in res) 
            {
                Console.WriteLine($"{t.custid} {t.custname} {t.age} {t.caddress}");
            }
        }
        public void q2() 
        {
            var res = from t in dc.orders
                      select t;
            foreach (var t in res)
            {
                Console.WriteLine($"{t.orderid} {t.custid} {t.orderdate} {t.product} {t.price} {t.qty}");
            }
        } 
        public void q3()
        {
            var res = from t in dc.customers join t1 in dc.orders
                    on t.custid equals t1.custid
                    select new {t.custid,t.custname,t1.orderid};
            foreach(var t in res)
            {
                Console.WriteLine($"{t.custid} {t.custname} {t.orderid}");
            }
        }
        public void q4()
        {
            var res = from t in dc.customers
                      join t1 in dc.orders
                    on t.custid equals t1.custid
                      select new { t.custname,t1.orderdate,t1.product,t1.price,};
            foreach (var t in res)
            {
                Console.WriteLine($"{t.orderdate} {t.custname} {t.price} {t.product}");
            }
        }
        public void q5()
        {
            var res = from t in dc.customers
                      join t1 in dc.orders
                    on t.custid equals t1.custid
                      where t.custname.StartsWith("a") && t.custname.EndsWith("s")
                      select new {t.custname,t.caddress,t1.product,t1.price };
            foreach(var t in res)
            {
                Console.WriteLine($"{t.custname} {t.caddress} {t.product} {t.price}");
            }
        }
        public void q6()
        {
            var res =from t in dc.customers
                     where t.age>20
                     select t;
            foreach (var t in res)
            {
                Console.WriteLine($"{t.custid} {t.custname} {t.age} {t.caddress}");
            }
        }
        public void q7()
        {
            var res = (from t in dc.customers
                       select t).Take(3);
            foreach (var t in res)
            {
                Console.WriteLine($"{t.custid} {t.custname} {t.age} {t.caddress}");
            }
        }
        public void q8()
        {
            var res = from t in dc.customers
                      join t1 in dc.orders
                    on t.custid equals t1.custid
                      where t1.price > 500 && t1.orderdate > new DateTime(2000,1,1)
                      select new { t1.orderid,t1.custid,t1.orderdate,t1.product,newprice=t1.price*0.9,t1.price};
            foreach(var t in res)
            {
                Console.WriteLine($"{t.orderid} {t.custid} {t.orderdate} {t.product} {t.price} {t.newprice}");
            }
        }
        public void q9()
        {
            var res = (from t in dc.orders
                       select t.price).Sum();

            var res1 = (from t in dc.orders
                        select t.price).Max();

            Console.WriteLine($"{res} {res1}");
        }
        public void q10()
        {
            var res = from t in dc.orders
                      where t.orderdate == DateTime.Now
                      select t;
            foreach(var t in res)
            {
                Console.WriteLine($"{t.custid} {t.orderid} {t.orderdate} {t.product} {t.price}");
            }
        }
        public void q11()
        {
            Console.WriteLine("Enter the first date in yyyy-mm-dd format");
            int y1=int.Parse(Console.ReadLine());
            int m1= int.Parse(Console.ReadLine());
            int d1=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second date in yyyy-mm-dd format");
            int y2 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());

            var res = from t in dc.orders
                      where t.orderdate > new DateTime(y1,m1,d1) && t.orderdate < new DateTime(y2,m2,d2)
                      select t;
            foreach( var t in res)
            {
                Console.WriteLine($"${t.custid} {t.orderid} {t.orderdate} {t.product} {t.price}");
            }
        }
        public void q12()
        {
           
            //var t1 = from t in dc.customers
            //         select t;

            //var t2 = from t in dc.orders
            //         select t;
            //foreach ( var t in t1)
            //{
            //    int c = 0;
            //    foreach(var a in t2)
            //    {
            //        if (t.custid == a.custid)
            //            c++;

            //    }
            //    if (c == 0)
            //    {
            //        Console.WriteLine(t.custid);
            //        Console.WriteLine(t.custname);
            //    }
            //}
            var res=  from t in dc.customers
                    join t1 in dc.orders
                    on t.custid equals t1.custid
                    select new { t.custid ,t.custname};

            foreach(var c in res)
            {
                Console.WriteLine($"{c.custid} {c.custname}");
            }

        }
        public void q13()
        {
            var res = from t in dc.customers
                      join t1 in dc.orders
                      on t.custid equals t1.custid
                      where t1.price > 5000
                      orderby t.custid descending
                      select new { t.custid ,t.custname,t1.product,t1.price};

            foreach( var t in res)
            {
                Console.WriteLine($"{t.custid} {t.custname} {t.product} {t.price}");
            }
        }
        public void q14()
        {
            int cid = 1;
            String cname = "Saswat";
            String product = "TV";
            var res = dc.customers.Where(t => t.custid == cid).FirstOrDefault();
            res.custname = cname;
            res.caddress = product;
            

        }
        public void q15()
        {
            var res = dc.customers.Where(t => t.caddress == "Banglore").FirstOrDefault();
            dc.customers.Remove(res);
            int i = dc.SaveChanges();
        }
        public void q16()
        {
            var result = dc.customers.Where(c => c.age > 25).ToList().SkipWhile(c => c.age < 35) .Take(2); 

            foreach (var customer in result)
            {
                Console.WriteLine($"Id: {customer.custid}, Name: {customer.custname}, Age: {customer.age}");
            }
        }

    }
}
