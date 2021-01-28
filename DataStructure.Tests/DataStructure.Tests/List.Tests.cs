using NUnit.Framework;
using SOL.CsharpCourse.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.Tests.DataStructure.Tests
{

    public class testobj
    {
        public string id { get; set; }

        public decimal amount { get; set; }
    }
    [TestFixture]
  public  class ListTests
    {

        [Test]
        public static void TestDemo()
        {
            ListDemocs.Run();
        }


        [Test]
        public static void memCheck()
        {
            testobj testobj = new testobj();

            testobj.amount = 100;

            testobj temp = testobj;


            var news = new testobj();
            news.amount = 90;
            testobj = news;

        }
        
    }
}
