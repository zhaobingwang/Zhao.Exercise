using System;
using System.Collections.Generic;
using System.Linq;
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

            string tempBankNo = "123456789087654598";
            for (int iBankNo = 4; iBankNo < tempBankNo.Length; iBankNo += 4 + 1)
            {
                tempBankNo += tempBankNo.Insert(iBankNo, "-");//灾难代码
            }
            Console.WriteLine(tempBankNo);
            Console.ReadKey();
        }
    }
    class ZhaoEx
    {
        public List<int> ChangeTwoVariable(int i,int j)
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
}
