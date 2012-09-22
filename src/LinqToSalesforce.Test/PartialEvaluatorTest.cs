using LinqToSalesforce.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace LinqToSalesforce.Test
{


    /// <summary>
    ///这是 PartialEvaluatorTest 的测试类，旨在
    ///包含所有 PartialEvaluatorTest 单元测试
    ///</summary>
    [TestClass()]
    public class PartialEvaluatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



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
