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
        static float expectedPremium;
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
        [Test(Description = "get premium for 25yo male")]
        public void Test2()
        {
            expectedPremium = 6.0f;
            float actualPremium = test.CalcPremium(25, "male");
            Assert.AreEqual(expectedPremium, actualPremium);
        }
        [TestCase(17, "female", ExpectedResult = 4.0f)]
        [TestCase(20, "female", ExpectedResult = 5.0f)]
        [TestCase(32, "female", ExpectedResult = 2.5f)]
        [TestCase(5, "male", ExpectedResult = 4.0f)]
        [TestCase(22, "male", ExpectedResult = 6.0f)]
        [TestCase(40, "male", ExpectedResult = 4.0f)]
        [TestCase(50, "male", ExpectedResult = 0.0f)]
        [TestCase(65,"mule", ExpectedResult = 4.0f)]

        public float Test3(int age, string gender)
        {
            float actualResult = test.CalcPremium(age, gender);
            return actualResult;
        }
    }
}