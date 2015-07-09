using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompareClass.Net;

namespace TestCompareClass.Net
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test1()
        {
            model m1 = new model() { age = 2, name = "Sandy" };
            model m2 = new model() { age = 5, name = "Rauff" };

            Compare.CompareClass<model>(m1, m2);


        }
    }


    public class model
    {
        public string name { get; set; }
        public int age { get; set; }
    }



}
