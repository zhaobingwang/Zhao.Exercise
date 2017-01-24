using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入EF模式：CodeFirst:0|DbFirst:1");
            string type = Console.ReadLine();
            if (type == "0")
            {
                using (var db = new BloggingContent())
                {
                    Console.WriteLine("为新博客起一个名字：");
                    var name = Console.ReadLine();
                    var blog = new Blog { Name = name };
                    db.Blogs.Add(blog);
                    db.SaveChanges();
                    var query = from b in db.Blogs
                                orderby b.Name
                                select b;
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("按任意键退出");
                }
            }
            else
            {
                using (var db=new Entities())
                {
                    var query = from b in db.Blogs
                                orderby b.Name
                                select b;
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine("按任意键退出");
                }
            }
            
        }
    }
    #region Code First
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
    public class User
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }
    public class BloggingContent : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    } 
    #endregion
}
