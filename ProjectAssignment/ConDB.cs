using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace ProjectAssignment
{
    internal class ConDB
    {
        public static SqlConnection con = new SqlConnection();
        public static void myConnection()
        {
            string conStr;
            conStr = "Data Source = DESKTOP-17EIQD8\\SNADATABASE;" + "Initial Catalog=Inventory;" + "Integrated Security=true;";
            try
            {
                con = new SqlConnection(conStr);
                con.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
