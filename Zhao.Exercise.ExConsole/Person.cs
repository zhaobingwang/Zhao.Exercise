using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.ExConsole
{
    public class Person
    {
        //当程序结束的时候，析构函数才执行
        //帮助我们释放资源
        //GC Garbage Collection 能自动帮我们释放资源。如果希望马上释放资源，可使用析构函数
        ~Person()
        {
            Console.WriteLine("执行析构函数");
        }
        public Person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person(string address):this("aa",20,'男')
        {
            this.Address = address;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age < 0 || _age > 150)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        private string _address;

        public string SayHi()
        {
            return string.Format("我叫{0}，今年{1}岁，我是{2}生", this.Name, this.Age, this.Gender);
        }
    }
}
