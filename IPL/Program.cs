using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace IPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test t = new test()
            {
                teamname = "RR",
                state = "Rajastan",
                budget = 1000
            };
            Model1Container1 m = new Model1Container1();
            m.tests.Add(t);
            m.SaveChanges();
        }
    }
}
