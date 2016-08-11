using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhao.Exercise.DAL;

namespace Zhao.Exercise.BLL
{
    public partial class UserInfoService
    {
        private UserInfoDAL dal;

        public UserInfoService()
        {
            dal = new UserInfoDAL();
        }
        public List<Model.UserInfo> GetList()
        {
            List<Model.UserInfo> list = dal.GetList();
            return list;
        }
    }
}
