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
        DataSet ds = new DataSet();
        public void displaymovies()
        {
            con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            da = new SqlDataAdapter("select * from movie",con);
         
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder s = new SqlCommandBuilder(da);
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
            dt.Rows.Add(12,"3idiots","amir","kareena",10000);
            dt.Rows.Add(18,"kantara","risabh","abc", 10000);
            dt.AcceptChanges();
            dt.Rows.Add(20, "kantara", "risabh", "abc", 10000);
            int i=da.Update(dt);
            Console.WriteLine(i+" no of row updated");
        }
        public void Delete()
        {
            Console.WriteLine("Enter the id");
            int id = int.Parse(Console.ReadLine());
            DataRow dr = dt.Rows.Find(id);
            dr.Delete();
            int i = da.Update(dt);
            Console.WriteLine("row deleted");
        }
        public void FilterRecord()
        {
            Console.WriteLine("----");
            DataView dv=new DataView(dt);
            dv.RowFilter = "moviename like 'k%'";

            foreach(DataRowView d in dv)
            {
                Console.WriteLine(d[0]);
                Console.WriteLine(d[1]);
                Console.WriteLine(d[2]);
                Console.WriteLine(d[3]);
                Console.WriteLine(d[4]);
            }
            Console.WriteLine("----");

        }
        public void xmldata()
        {
            //Code to create xml file
            //   ds.WriteXml("C:\\Users\\saswat.nayak\\Desktop\\ad\\movie.xml");

            //code to create xml file with tracking support
            dt.Rows.Add(10, "kantara", "risabh", "abc", 10000);
            ds.WriteXml("C:\\Users\\saswat.nayak\\Desktop\\ad\\movie.xml",XmlWriteMode.DiffGram);

            Console.WriteLine("File Created");
        }
        public void Concurrent()
        {

        }
    }
}
