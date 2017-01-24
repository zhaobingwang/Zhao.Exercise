using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhao.Exercise.Common;

namespace Zhao.Exercise.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqDemo linqDemo = new LinqDemo();
            //linqDemo.BaseQueryDemo();
            //string a = null;
            //Console.WriteLine(TypeConverter.ChangeString(a));

            //LinqQuery();
            //string s = "Z";
            //s.Foo();
            //linqDemo.DelayedQuery();
            //linqDemo.AvoidDelayedQuery();

            #region 标准的查询操作符
            linqDemo.QueryOperator();
            #endregion
        }
        static void LinqQuery()
        {
            var query = from r in Formulal.GetChampions()
                        where r.Country == "Brazil"
                        orderby r.Wins descending
                        select r;
            foreach (Racer r in query)
            {
                Console.WriteLine("{0}", r.ToString("A"));
            }
        }
    }
    class LinqDemo
    {
        #region MyRegion
        public void BaseQueryDemo()
        {
            //Specify the data source.
            int[] scores = new int[] { 60, 76, 99, 100, 56, 90 };

            //Define the query expression.
            IEnumerable<int> scorequery =
                from score in scores
                where score > 80
                select score;
            // Execute the query
            foreach (int i in scorequery)
            {
                Console.WriteLine(i + " ");
            }
        }
        #endregion

        #region 推迟查询的执行
        /// <summary>
        /// 延迟查询
        /// </summary>
        public void DelayedQuery()
        {
            var names = new List<string> { "Jack", "Nick", "Spartan" };
            var nameWithS = (from name in names
                             where name.StartsWith("S")
                             orderby name
                             select name);
            Console.WriteLine("First Demo:");
            foreach (string name in nameWithS)
            {
                Console.WriteLine(name);//Result:Spartan
            }
            Console.WriteLine();
            names.Add("John");
            names.Add("Jim");
            names.Add("Steven");
            Console.WriteLine("Second Demo:");
            foreach (string name in nameWithS)
            {
                Console.WriteLine(name);//Result:Spartan,Steven
            }
            /*
             *由这俩个不同结果可见只有在枚举nameWithS的时候才会真正的执行查询操作。
             * 如果没有延迟查询, 两次输出的结果应该是相同的。
             */
        }
        /// <summary>
        /// 避免延迟查询
        /// </summary>
        public void AvoidDelayedQuery()
        {
            var names = new List<string> { "Jack", "Nick", "Spartan" };
            var nameWithS = (from name in names
                             where name.StartsWith("S")
                             orderby name
                             select name).ToList();
            Console.WriteLine("First Demo:");
            foreach (string name in nameWithS)
            {
                Console.WriteLine(name);//Result:Spartan
            }
            Console.WriteLine();
            names.Add("John");
            names.Add("Jim");
            names.Add("Steven");
            Console.WriteLine("Second Demo:");
            foreach (string name in nameWithS)
            {
                Console.WriteLine(name);//Result:Spartan,Steven
            }
            /*
             *可以使用一个不返回IEnumerable<T>数据类型的转换操作符, 
             * 如ToArray, ToList, ToDictionary或ToLookup
             */
        }
        #endregion

        #region 标准的查询操作符
        public void QueryOperator()
        {
            using (var db = new Entities())
            {

                #region 数据源
                var queryBlogs = from b in db.Blogs
                                 select b;
                var queryPosts = from p in db.Posts
                                 select p;
                Console.WriteLine("数据源Blogs：");
                foreach (var item in queryBlogs)
                {
                    Console.WriteLine("{0}-{1}-{2}", item.BlogId, item.Name, item.Url);
                }
                Console.WriteLine("数据源Posts：");
                foreach (var item in queryPosts)
                {
                    Console.WriteLine("{0}-{1}-{2}-{3}", item.PostId, item.Title, item.Content, item.BlogId);
                }
                #endregion

                Console.WriteLine(Environment.NewLine);

                #region SelectMany-cross join,结果集是所有表的迪卡尔积
                var query_selectMany = from b in db.Blogs
                                       from p in db.Posts
                                       select p;
                Console.WriteLine("操作符：SelectMany-cross join");
                foreach (var item in query_selectMany)
                {
                    Console.WriteLine("{0}-{1}-{2}", item.PostId, item.Title, item.Content, item.BlogId);
                }
                #endregion

                #region SelectMany-inner join
                Console.WriteLine("操作符：SelectMany-inner join");
                var query_selectMany_innerJoin = from b in db.Blogs
                                                 from p in b.Posts
                                                 select p;
                foreach (var item in query_selectMany_innerJoin)
                {
                    Console.WriteLine("{0}-{1}-{2}", item.PostId, item.Title, item.Content, item.BlogId);
                }
                #endregion

                #region SelectMany-left out join
                Console.WriteLine("操作符：SelectMany-left out join");
                var query_selectMany_leftOutJoin = from b in db.Blogs
                                                   from p in b.Posts.DefaultIfEmpty()
                                                   select new { b.Name, p.Title, p.Content };
                foreach (var item in query_selectMany_leftOutJoin)
                {
                    Console.WriteLine("{0}-{1}-{2}", item.Title, item.Content, item.Name);
                }
                #endregion
            }
        }
        #endregion
    }

    public static class StringExtension
    {
        public static void Foo(this string s)
        {
            Console.WriteLine("Foo invoked for {0}", s);
        }
    }

    public class TempDemo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

}
