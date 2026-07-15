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

        // Runs a SELECT query and returns results as a DataTable
        // Use this for loading data into DataGridViews, ComboBoxes, etc.
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            return dt;
        }

        // Runs INSERT / UPDATE / DELETE queries safely using parameters
        // Returns true if it succeeded, false if it failed
        public static bool ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
        }

        // Runs a query that returns a single value (e.g. COUNT, SUM, checking login)
        // Useful for things like "does this username exist" or "get total price"
        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return null;
            }
        }
    }
}