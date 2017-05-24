using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.Lambda
{
    class Program
    {
        delegate int del(int i);
        delegate bool compare(string str, int length);
        static void Main(string[] args)
        {
            //del myDelegate = x => x * x;
            //Console.WriteLine(myDelegate(5));
            //Expression<del> myET = x => x * x;
            //Console.WriteLine(CompareStrLength("aaa",3));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static bool CompareStrLength(string str, int length)
        {
            compare compare = (string s, int len) => str.Length > len;
            return compare(str, length);
        }
    }
}
