using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONETDEMO
{
    internal class connectDemo
    {
        public void Display()
        {
            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from movie", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);   
                Console.WriteLine(dr[3]);   
                Console.WriteLine(dr[4]);
                

            }
            con.Close();
        }
        public void DisplayId()
        {
            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("select * from movie where movieid=@id", con);
            cmd.Parameters.AddWithValue("@id",id);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
                Console.WriteLine(dr[2]);
                Console.WriteLine(dr[3]);
                Console.WriteLine(dr[4]);


            }
            con.Close();
        }
        public void AddRecords() 
        {

            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter film");
            string film = Console.ReadLine();
            Console.WriteLine("Enter actor");
            string actor = Console.ReadLine();
            Console.WriteLine("Enter actress");
            string actress = Console.ReadLine();
            Console.WriteLine("Enter budget");
            int budget = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into movie values (@id,@film,@actor,@actress,@budget)", con);
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@film", film);
            cmd.Parameters.AddWithValue("@actor", actor);
            cmd.Parameters.AddWithValue("@actress", actress);
            cmd.Parameters.AddWithValue("@budget", budget);

            int result=cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("Data Added Successfully");

            //Display();
        }
        public void UpdateRecords()
        {
            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("update movie set budget=90000 where movieid=1", con);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("total record updated is " + i);
            con.Close();

        }
        public void DeleteRecords()
        {
            SqlConnection con = new SqlConnection("integrated security=sspi;database=cinemadb;server=.");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from movie where movieid=4", con);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("total record deleted is " + i);
            con.Close();

        }
    }
}
