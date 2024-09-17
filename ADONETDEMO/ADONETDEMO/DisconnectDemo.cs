using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADONETDEMO
{
    internal class DisconnectDemo
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public void displaymovies()
        {
            con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            da = new SqlDataAdapter("select * from movie",con);
            DataSet ds=new DataSet();  
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds,"m");
            int count = 0;
          /*  for (int i = 0; i < ds.Tables["m"].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables["m"].Rows[i][0]);
                Console.WriteLine(ds.Tables["m"].Rows[i][1]);
                Console.WriteLine(ds.Tables["m"].Rows[i][2]);
                Console.WriteLine(ds.Tables["m"].Rows[i][3]);
                Console.WriteLine(ds.Tables["m"].Rows[i][4]);
                count++;
            }*/
           
            dt=ds.Tables["m"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables["m"].Rows[i][0]);
                Console.WriteLine(ds.Tables["m"].Rows[i][1]);
                Console.WriteLine(ds.Tables["m"].Rows[i][2]);
                Console.WriteLine(ds.Tables["m"].Rows[i][3]);
                Console.WriteLine(ds.Tables["m"].Rows[i][4]);
                count++;
            }

            Console.WriteLine("No of row printed "+count);
        }
        public void Search()
        {
            Console.WriteLine("Enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow dr=   dt.Rows.Find(id);
            Console.WriteLine(dr[0]);
            Console.WriteLine(dr[1]);
            Console.WriteLine(dr[2]);
            Console.WriteLine(dr[3]);
            Console.WriteLine(dr[4]);

        }
        public void Add()
        {
        }
        public void Delete()
        {
        }
        public void FilterRecord()
        {
        }
        public void Concurrent()
        {
        }
    }
}
