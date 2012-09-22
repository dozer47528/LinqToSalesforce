using LinqToSalesforce.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace LinqToSalesforce.Test.Other
{
    [TestClass()]
    public class PartialEvaluatorTest
    {
        [TestMethod()]
        public void EvalTest1()
        {
            var local = "test";
            Expression<Func<string, string>> expression = a => a + local;
            Expression<Func<string, string>> expected = a => a + "test";
            Expression actual;
            actual = PartialEvaluator.Eval(expression);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void EvalTest2()
        {
            var local = "test";
            Expression<Func<string, bool>> expression = a => a.StartsWith(local);
            Expression<Func<string, bool>> expected = a => a.StartsWith("test");
            Expression actual;
            actual = PartialEvaluator.Eval(expression);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void EvalTest3()
        {
            var local = 1;
            Expression<Func<User, bool>> expression = a => a.ID == 0 + local;
            Expression<Func<User, bool>> expected = a => a.ID == 1;
            Expression actual;
            actual = PartialEvaluator.Eval(expression);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
