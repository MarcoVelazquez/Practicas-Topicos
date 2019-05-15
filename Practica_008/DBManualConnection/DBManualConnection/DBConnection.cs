using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;



namespace DBManualConnection
{
    class DBConnection
    {

        public DataTable dataTable = new DataTable(); 
        //"Data Source=DANIEL-LAPTOP\DANIEL_DB;Initial Catalog=Estudiantes2;Persist Security Info=True;User ID=daniel;Password=1234"

        public void PullData()
        {
            try
            {
                string connString = @"Data Source=DANIEL-LAPTOP\DANIEL_DB;Initial Catalog=Estudiantes2;Persist Security Info=True;User ID=daniel;Password=1234asdf";
                string query = "select * from Estudiantes2";

                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(dataTable);
                conn.Close();
                da.Dispose();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

    }
}
