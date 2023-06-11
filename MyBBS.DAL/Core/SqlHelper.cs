using System.Data;
using Microsoft.Data.SqlClient;

namespace MyBBS.DAL.Core
{
    public class SqlHelper
    {
        public static string ConnectionString { get; set; } = "server=localhost;database=MyBBSDb;uid=sa;password=1q2w3e4r;TrustServerCertificate=True;";

        public static DataTable ExecuteTable(string cmdText, params SqlParameter[] sqlParameters)
        {
            using SqlConnection conn = new(ConnectionString);
            conn.Open();
            SqlCommand cmd = new(cmdText, conn);
            cmd.Parameters.AddRange(sqlParameters);
            SqlDataAdapter sda = new(cmd);
            DataSet ds = new();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public static int ExecuteNonQuery(string cmdText, params SqlParameter[] sqlParameters)
        {
            using SqlConnection conn = new(ConnectionString);
            conn.Open();
            SqlCommand cmd = new(cmdText, conn);
            cmd.Parameters.AddRange(sqlParameters);
            return cmd.ExecuteNonQuery();
        }
    }
}