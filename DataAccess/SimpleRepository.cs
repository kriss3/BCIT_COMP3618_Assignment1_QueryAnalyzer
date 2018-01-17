using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class SimpleRepository
    {
        public ConnectionState ConnState { get; private set; }

        public string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        }

        public SqlConnection Connect()
        {
            return new SqlConnection(GetConnString());
        }

        public DataSet GetResults(string query)
        {
            DataSet ds = null;
            using (var conn = new SqlConnection(GetConnString()))
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                conn.Open();

                var da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Results");
            }
            return ds;
        }

        public string GetConnectionStatistics()
        {
            var results = String.Empty;

            using (var c = new SqlConnection(GetConnString()))
            {
                c.Open();
                results =
                  $"Connection Status:\t {c.State}{Environment.NewLine}"
                + $"Conn TimeOut:\t{c.ConnectionTimeout}{Environment.NewLine}"
                + $"Packet Size:\t {c.PacketSize}{Environment.NewLine}"
                + $"Server Version:\t {c.ServerVersion}{Environment.NewLine}"
                + $"Workstation ID:\t {c.WorkstationId}";
                ConnState = c.State;
            }
            return results;
        }

    }
}
