using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.ExConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //ZhaoEx changeTwoVariable = new ZhaoEx();
            //List<int> list = changeTwoVariable.ChangeTwoVariable(10, 20);
            //Console.WriteLine("源数据：i={0},j={1}",10,20);
            //Console.WriteLine("交换后：i={0},j={1}",list[0],list[1]);
            //Console.WriteLine("-------------------------------------------------------");
            //Person p = new Person("Jack",24,'男');
            //Console.WriteLine(p.SayHi());
            //Console.ReadKey();
            //Console.WriteLine("-------------------------------------------------------");
            //Ticket ticket = new Ticket(150);
            //ticket.ShowTicketPrice();
            //Console.WriteLine("-------------------------------------------------------"); 
            #endregion

            //string tempBankNo = "123456789087654598";
            //for (int iBankNo = 4; iBankNo < tempBankNo.Length; iBankNo += 4 + 1)
            //{
            //    tempBankNo += tempBankNo.Insert(iBankNo, "-");//灾难代码
            //}
            //Console.WriteLine(tempBankNo);
            //Console.ReadKey();


            TestClass class1 = new TestClass();
            TestClass class2 = new TestClass();
            class1.str1 = "abc";
            class1.int1 = 1;
            class2 = class1;//(TestClass)Clone2.CloneObject(class1);//(TestClass)class1.Clone();
            class2.str1 = "123";
            class2.int1 = 2;
            Console.WriteLine(Object.ReferenceEquals(class1,class2));
            Console.WriteLine(class1.str1+class2.str1);
            Console.WriteLine(class1.int1+class2.int1);

        }
    }
    class ZhaoEx
    {
        public List<int> ChangeTwoVariable(int i, int j)
        {
            i = i + j;//此时i是i+j
            j = i - j;//此时j是初始的i的值
            i = i - j;//此时i是i+j,j是i初始值
            List<int> result = new List<int>();
            result.Add(i);
            result.Add(j);
            return result;
        }
    }
    [Serializable]
    class TestClass:ICloneable
    {
        public string str1 { get; set; }
        public string str2 { get; set; }
        public int int1 { get; set; }

        //object ICloneable.Clone()
        //{
        //    return this.Clone();
        //}
        //public TestClass Clone()
        //{
        //    return (TestClass)this.MemberwiseClone();
        //}
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Clone2
    {
        //此方法必须把诶标记为 Serializable
        public static object CloneObject(object obj)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null,
                     new StreamingContext(StreamingContextStates.Clone));
                binaryFormatter.Serialize(memStream, obj);
                memStream.Seek(0, SeekOrigin.Begin);
                return binaryFormatter.Deserialize(memStream);
            }
        }
    }
}
