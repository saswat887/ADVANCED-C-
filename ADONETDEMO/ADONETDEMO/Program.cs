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
            dis.displaymovies();
            dis.Search();

            Console.ReadKey();
        }
    }
}
