using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.Common
{
    public partial class Seed
    {
        public List<UsersInfo> initSeed1(int count=5)
        {
            List<UsersInfo> users = new List<UsersInfo>
            {
                new UsersInfo{ID=10001,NickName="aaa",RealName="张三",Age=20},
                new UsersInfo{ID=10002,NickName="bbb",RealName="李四",Age=20},
                new UsersInfo{ID=10003,NickName="ccc",RealName="王五",Age=20},
                new UsersInfo{ID=10004,NickName="ddd",RealName="曹操",Age=20},
                new UsersInfo{ID=10005,NickName="eee",RealName="刘备",Age=20},
            };
            if (count>5)
            {
                for (int i = 0; i < count; i++)
                {
                    UsersInfo _userinfo = new UsersInfo();
                    _userinfo.ID = 10006 + i;
                    _userinfo.NickName = i.ToString();
                    _userinfo.RealName = "孙权1_" + i.ToString();
                    _userinfo.Age = 20;
                    users.Add(_userinfo);
                }
            }
            UsersInfo _userinfo2 = new UsersInfo();
            _userinfo2.ID = 999999999;
            _userinfo2.NickName = "END";
            _userinfo2.RealName = "END SEED DATA";
            _userinfo2.Age = 20;
            users.Add(_userinfo2);
            return users;
        }
        public List<UsersInfo> initSeed2(int count=5)
        {
            List<UsersInfo> users = new List<UsersInfo>
            {
                new UsersInfo{ID=10001,NickName="aaa",RealName="张三",Age=20},
                new UsersInfo{ID=10002,NickName="bbb",RealName="李四",Age=20},
                new UsersInfo{ID=10003,NickName="ccc",RealName="王五",Age=20},
                new UsersInfo{ID=10004,NickName="ddd",RealName="司马懿",Age=20},
                new UsersInfo{ID=10005,NickName="eee",RealName="诸葛亮",Age=20},
            };
            if (count > 5)
            {
                for (int i = 0; i < count; i++)
                {
                    UsersInfo _userinfo = new UsersInfo();
                    _userinfo.ID = 10006 + i;
                    _userinfo.NickName = i.ToString();
                    _userinfo.RealName = "孙权2_" + i.ToString();
                    _userinfo.Age = 20;
                    users.Add(_userinfo);
                }
            }
            UsersInfo _userinfo2 = new UsersInfo();
            _userinfo2.ID = 999999999;
            _userinfo2.NickName = "END";
            _userinfo2.RealName = "END SEED DATA";
            _userinfo2.Age = 20;
            users.Add(_userinfo2);
            return users;
        }
    }
    public class UsersInfo
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string RealName { get; set; }
        public int Age { get; set; }
    }
}
