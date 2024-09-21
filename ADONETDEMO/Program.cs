using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            connectDemo con=new connectDemo();
            //  con.Display();
            //  con.DisplayId();
            //con.AddRecords();

         //   TransactionDemo td=new TransactionDemo();
           // td.Add();

            DisconnectDemo dis=new DisconnectDemo();
            //   dis.displaymovies();
            // dis.Search();
            //   dis.Add();
            // dis.Delete();
            //    dis.FilterRecord();
            //  dis.xmldata();

          //  Class1 c = new Class1();
            //c.demo3();

        //    LinqDemo l=new LinqDemo();
         //   l.Demo5();

      //      LinqAssignment la=new LinqAssignment();
        //    la.pq2();
        efdemo demo=new efdemo();
          demo.DisplayStudentsbyId();

            LinqEntityAss l=new LinqEntityAss();
         //   l.q14();

            Console.ReadKey();
        }
    }
}
