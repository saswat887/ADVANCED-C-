using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class TransactionDemo
    {
        public void Add()
        {
            SqlTransaction tr=null;//step 1 (rollback/commit)
            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            try
            {
              
                tr = con.BeginTransaction();// step 2 


                SqlCommand cmd1 = new SqlCommand("insert into tableA values(10,'raj')", con);
                cmd1.Transaction = tr;  //part of transaction

                int i = cmd1.ExecuteNonQuery();
                
                SqlCommand cmd2 = new SqlCommand("insert into tableB values(10,'raj')", con);
                cmd2.Transaction = tr;  //part of transaction

                int j = cmd2.ExecuteNonQuery();
               
                tr.Commit();
                Console.WriteLine("Commit");

                con.Close();

            }
            catch (Exception ex) { 
                tr.Rollback();
                Console.WriteLine("Rollback");

            }
        }
    }
}
