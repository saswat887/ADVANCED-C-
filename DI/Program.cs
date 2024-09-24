using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create obbject of service class
            /*  IMath ob = new Service();
              IMath1 ob1 = new Service();

              //send object to client class
              Client c =new Client();
              c.m=ob;
              c.m1 =ob1;
              c.show(ob,ob1);*/
            /*   UnityContainer container = new UnityContainer();

                 container.RegisterSingleton<IMath,Service>();
                 container.RegisterSingleton<IMath1,Service>();
                 var client=container.Resolve<Client>();
                 client.show();
           
            //q1
            int[] data = { 10, 30, 60, 90, 130, 190 };
            q1Cliient q1=new q1Cliient();
            IMathq1 a=new q1Service();
            q1.show(a,data); */
            UnityContainer container = new UnityContainer();
            container.RegisterType<TestInstance, TestInstance>();
          //  container.RegisterSingleton<TestInstance, TestInstance>();
            //  container.RegisterType<Show, Show>();   
            var client = container.Resolve<TestInstance>();
            client.Show();

            UnityContainer container1 = new UnityContainer();
            container1.RegisterSingleton<TestInstance, TestInstance>();
            var client1 = container.Resolve<TestInstance>();
            client1.Show();



            Console.ReadKey();  

        }
    }
}
