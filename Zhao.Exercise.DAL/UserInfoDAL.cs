using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhao.Exercise.DBUtility;

namespace Zhao.Exercise.DAL
{
    public partial class UserInfoDAL
    {
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
    }
}
