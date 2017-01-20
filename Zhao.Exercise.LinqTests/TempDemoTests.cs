using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zhao.Exercise.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhao.Exercise.Linq.Tests
{
    [TestClass()]
    public class TempDemoTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest()
        {
            TempDemo tempDemo = new TempDemo();
            int a = -1;
            //int aInit = a;
            int b = -1;
            int bInit = b;
            int count = 3;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    tempDemo.Divide(a, b);
                    b++;
                    if (b==(bInit+count))
                    {
                        b = 1;
                    }
                }
                a++;
            }
        }
    }
}