using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhao.Exercise.DBUtility;

namespace Zhao.Exercise.DAL
{
    public partial class UserInfoDAL
    {
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public List<Model.UserInfo> GetList()
        {
            string sql = "select * from UserInfo";
            DataTable dt = SQLHelper.ExecuteReaderDT(sql);
            List<Model.UserInfo> list = new List<Model.UserInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Model.UserInfo()
                {
                    UserId = row["UserId"] == DBNull.Value ? 0 : Convert.ToInt32(row["UserId"]),
                    UserName = row["UserName"].ToString(),
                    UserPwd = row["UserPwd"].ToString(),
                    UserAge = row["UserAge"] == DBNull.Value ? 0 : Convert.ToInt32(row["UserAge"]),
                    DelFlag = Convert.ToInt16(row["DelFlag"]),
                    CreateTime = row["CreateTime"] == DBNull.Value ? Convert.ToDateTime("2000-1-1") : Convert.ToDateTime(row["CreateTime"]),
                    UpdateTime = row["UpdateTime"] == DBNull.Value ? Convert.ToDateTime("2000-1-1") : Convert.ToDateTime(row["UpdateTime"])
                });
            }
            return list;
        }
        public int Update(Model.UserInfo userinfo)
        {
            string sql = "update userinfo set UserName=@UserName,UserPwd=@UserPwd,UserAge=@UserAge,UpdateTime=@UpdateTime where UserId=@UserId";
            SqlParameter[] ps = new SqlParameter[] {
                new SqlParameter("@UserId",userinfo.UserId),
                new SqlParameter("@UserName",userinfo.UserName),
                new SqlParameter("@UserPwd",userinfo.UserPwd),
                new SqlParameter("@UserAge",userinfo.UserAge),
                new SqlParameter("@UpdateTime",userinfo.UpdateTime)
            };
            return SQLHelper.ExecuteNonQuery(sql, ps);
        }
    }
}
