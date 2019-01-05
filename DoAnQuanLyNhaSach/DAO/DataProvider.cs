using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyNhaSach.DAO
{
    class DataProvider
    {
        SqlConnection Connection { get; set; }
        string connectionString = @"Data Source=DESKTOP-77J83LG;Initial Catalog=QuanLyNhaSach;Integrated Security=True";
        public void Connect()
        {
            try
            {
                if (Connection == null)
                    Connection = new SqlConnection(connectionString);
                if (Connection != null && Connection.State != ConnectionState.Open)
                    Connection.Close();
                Connection.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public void Disconnect()
        {
            try
            {
                if (Connection != null && Connection.State == ConnectionState.Open)
                    Connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ExecuteNonQuery(CommandType cmdType, string query, params SqlParameter[] parameters)
        {
            int nRows = 0;
            try
            {
                SqlCommand Command = Connection.CreateCommand();
                Command.CommandType = cmdType;
                Command.CommandText = query;
                if (parameters != null && parameters.Length > 0)
                    Command.Parameters.AddRange(parameters);
                nRows = Command.ExecuteNonQuery();
                return nRows;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable Select(CommandType cmdType, string query, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand Command = Connection.CreateCommand();
                Command.CommandType = cmdType;
                Command.CommandText = query;
                if (parameters != null && parameters.Length > 0)
                    Command.Parameters.AddRange(parameters);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                return table;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
