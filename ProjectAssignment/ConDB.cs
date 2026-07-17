using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProjectAssignment
{
    public class ConDB
    {
        // Connection string built once - change server name here if needed
        public static string connectionString =
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SalePcDB;Integrated Security=true;TrustServerCertificate=True;";

        // Shared connection object (kept from your original design)
        public static SqlConnection con = new SqlConnection();

        // Opens the shared connection - call this if you want to use ConDB.con directly
        public static void myConnection()
        {
            try
            {
                con = new SqlConnection(connectionString);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }



        
    }
}