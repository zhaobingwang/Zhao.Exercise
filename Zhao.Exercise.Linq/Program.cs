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
            //LinqDemo linqDemo = new LinqDemo();
            //linqDemo.BaseQueryDemo();
            //string a = null;
            //Console.WriteLine(TypeConverter.ChangeString(a));

            LinqQuery();
            string s = "Z";
            s.Foo();
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
