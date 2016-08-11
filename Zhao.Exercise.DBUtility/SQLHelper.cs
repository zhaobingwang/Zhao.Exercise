using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.DBUtility
{
    // 提供执行方法
    public class SQLHelper
    {
        // 连接字符串
        static string connStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;

        /// <summary>
        /// 实现非查询操作，增删改返回受影响行数，否则返回-1
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(ps);
					cmd.CommandType = type;
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static object ExecuteScalar(string sql, CommandType type, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(ps);
					cmd.CommandType = type;
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string sql, CommandType type, params SqlParameter[] ps)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(ps);
					cmd.CommandType = type;
                    conn.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
                throw ex;
            }
        }
        public static DataTable ExecuteReaderDT(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

                sda.SelectCommand.Parameters.AddRange(ps);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
            }
        }

        public static DataTable ExecuteReaderDT(string sql,CommandType ct ,params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);

                sda.SelectCommand.Parameters.AddRange(ps);
                sda.SelectCommand.CommandType = ct;

                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
            }
        }

        public static DataSet GetDataSet(string sql, CommandType type, params SqlParameter[] ps)
        {
            DataSet ds = new DataSet();
            using (SqlDataAdapter sda = new SqlDataAdapter(sql, connStr))
            {
                sda.SelectCommand.Parameters.AddRange(ps);
				sda.SelectCommand.CommandType = type;
                sda.Fill(ds);
            }
            return ds;
        }


        // 常用的简化方法
        public static int ExecuteNonQuery(string Sql, params SqlParameter[] ps)
        {
            return ExecuteNonQuery(Sql, CommandType.Text, ps);
        }
        public static int ExecuteNonQuerySP(string Sql, params SqlParameter[] ps)
        {
            return ExecuteNonQuery(Sql, CommandType.StoredProcedure, ps);
        }

        public static object ExecuteScalar(string Sql, params SqlParameter[] ps)
        {
            return ExecuteScalar(Sql, CommandType.Text, ps);
        }
        public static object ExecuteScalarSP(string Sql, params SqlParameter[] ps)
        {
            return ExecuteScalar(Sql, CommandType.StoredProcedure, ps);
        }

        public static SqlDataReader ExecuteReader(string Sql, params SqlParameter[] ps)
        {
            return ExecuteReader(Sql, CommandType.Text, ps);
        }
        public static SqlDataReader ExecuteReaderSP(string Sql, params SqlParameter[] ps)
        {
            return ExecuteReader(Sql, CommandType.StoredProcedure, ps);
        }

        public static DataSet GetDataSet(string Sql, params SqlParameter[] ps)
        {
            return GetDataSet(Sql, CommandType.Text, ps);
        }
        public static DataSet GetDataSetSP(string Sql, params SqlParameter[] ps)
        {
            return GetDataSet(Sql, CommandType.StoredProcedure, ps);
        }

    }
}
