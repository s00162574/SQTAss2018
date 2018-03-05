using NUnit.Framework;
using SQTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
        static float ExpectedPremium;
        static Calculator test;

        [SetUp]
        public static void Init()
        {
            test = new Calculator();
        }

        [Test(Description = "a test check not null")]
        public void Test1()
        {
            Assert.NotNull(test, "not created");
        }
        [Test(Description ="get each persons premium")]
        public void Test2()
        {

        }
    }
}
