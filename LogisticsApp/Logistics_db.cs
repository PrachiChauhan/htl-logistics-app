using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LogisticsApp
{
    public class Logistics_db
    {
        private String connectionString;
        private SqlConnection connection;

        public Logistics_db()
        {
            connectionString = ConfigurationManager.ConnectionStrings["LogisticsApp.Properties.Settings.LogisticsDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public DataTable getCustomerNames()
        {
            SqlCommand cmd =new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select c_name,c_id from customer";

            DataTable cNameTable = new DataTable();
            SqlDataAdapter addressAdapter = new SqlDataAdapter(cmd);
            addressAdapter.Fill(cNameTable);

            return cNameTable;
        }

        public DataTable getCustAddress(String id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select c_address from customer c where c.c_id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            DataTable cNameTable = new DataTable();
            SqlDataAdapter addressAdapter = new SqlDataAdapter(cmd);
            addressAdapter.Fill(cNameTable);
            
            return cNameTable;

        }
        public DataTable getAllocationCode()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select a_code,a_type,a_chargecode from allocation";
            DataTable aCodeTable = new DataTable();
            SqlDataAdapter addressAdapter = new SqlDataAdapter(cmd);
            addressAdapter.Fill(aCodeTable);

            return aCodeTable;

        }
        public DataTable getCustomerPerc(String id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Select c_calcpercent from customer c where c.c_id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            DataTable aPercTable = new DataTable();
            SqlDataAdapter addressAdapter = new SqlDataAdapter(cmd);
            addressAdapter.Fill(aPercTable);

            return aPercTable;
        }

        /* public void testdb()
         {
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = connection;
             cmd.CommandText = "Select * from customer";
             DataTable aPercTable = new DataTable();
             SqlDataAdapter addressAdapter = new SqlDataAdapter(cmd);
             addressAdapter.Fill(aPercTable);
             foreach (DataRow dataRow in aPercTable.Rows)
             {
                 foreach (var item in dataRow.ItemArray)
                 {
                     Console.Write(item.ToString());
                 }
             }
         }

         public int delCustomer(String[] value)
         {
             int rc=0;
             try
             {
                 testdb();
                 connection.Open();
                 using (SqlCommand cmd = new SqlCommand("Delete from dbo.customer where c_id=@cid", connection)) {
                     cmd.Parameters.AddWithValue("@cid", "PID1");
                     cmd.Transaction = connection.BeginTransaction();

                     rc = cmd.ExecuteNonQuery();
                     cmd.Transaction.Commit();
                     Console.WriteLine("RC Ret code: " + rc);
                 }
                 connection.Close();
                 testdb();
             }
             catch (Exception exp)
             {
                 Console.WriteLine(exp.Message);
             }
             return rc;
         }
         */
        public int addCustomer(String[] value)
        {
            int rc = 0;
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO customer VALUES(@value1, @value2, @value3, @value4, @value5)", connection))
                {
                    cmd.Parameters.AddWithValue("@value1", value[0]);
                    cmd.Parameters.AddWithValue("@value2", value[1]);
                    cmd.Parameters.AddWithValue("@value3", value[2]);
                    cmd.Parameters.AddWithValue("@value4", Convert.ToDecimal(value[3]));
                    cmd.Parameters.AddWithValue("@value5", Convert.ToDouble(value[4]));
                    cmd.Transaction = connection.BeginTransaction();

                    rc = cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                    Console.WriteLine("RC Ret code: " + rc);
                }
                connection.Close();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            return rc;
        }


    }
}
