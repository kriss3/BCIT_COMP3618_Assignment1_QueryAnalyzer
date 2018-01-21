using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    /// <summary>
    /// Krzysztof Szczurowski
    /// BCIT COMP3618 Assingment 1;
    /// Repo: https://github.com/kriss3/BCIT_COMP3618_Assignment1_QueryAnalyzer.git
    /// </summary>
    public class SimpleRepository
    {
        public SqlConnection Connection { get; private set; }

        public SimpleRepository()
        {
            GetConnection();
        }

        public string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
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

        private void GetConnection()
        {
            SqlConnection conn = null;
            conn = new SqlConnection(GetConnString());
            conn.Open();
            Connection = conn;
        }
    }
}
