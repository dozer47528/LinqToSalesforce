using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToSalesforce.Test.force.com;
using System.Linq;
using LinqToSalesforce.Entity;

namespace LinqToSalesforce.Test.SalesforceQuery
{
    [TestClass]
    public class SalesforceQueryTest
    {
        #region HelpMethod
        protected SalesforceQuery<T> Query<T>(SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel) where T : sObject
        {
            return new SalesforceQuery<T>(new SalesforceProviderSample<T> { SelectType = selectType });
        }
        #endregion

        #region Where
        [TestMethod]
        public void WhereTest()
        {
            var result = Query<Contract>().Where(c => c.CreatedDate > DateTime.Now.AddMonths(-1)).ToList();
            Assert.IsTrue(result.Any());
        }

        [TestMethod]
        public void WhereRelatedTest()
        {
            var result = Query<Contract>().Where(c => c.Owner.Name != "").FirstOrDefault();
            Assert.IsNotNull(result);
        }
        #endregion

        #region First
        [TestMethod]
        public void SelectTest()
        {
            var result = Query<Contract>().Select(c => new Contract
            {
                Id = c.Id,
                IsDeleted = c.IsDeleted,
                Account = new Account
                {
                    Name = c.Account.Name,
                    Owner = new User { Name = c.Account.Owner.Name },
                },
            }).FirstOrDefault();

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.IsDeleted);
            Assert.IsNotNull(result.Account.Name);
            Assert.IsNotNull(result.Account.Owner.Name);
            Assert.IsNull(result.Account.Owner.Phone);
        }

        [TestMethod]
        public void First_NoneTest()
        {
            try
            {
                var result = Query<User>().First(u => u.Name == Guid.NewGuid().ToString());
                Assert.Fail("the First() method did not throw any exception");
            }
            catch { }
        }

        [TestMethod]
        public void First_OneTest()
        {
            // find an user
            var firstUser = Query<User>().Select(u => new User { Id = u.Id }).FirstOrDefault();
            Assert.IsNotNull(firstUser);

            var result = Query<User>().First(u => u.Id == firstUser.Id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void First_ManyTest()
        {
            var result = Query<User>().First();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FirstOrDefault_NoneTest()
        {
            //query for an inexistent user should not throw an exception
            var result2 = Query<User>().FirstOrDefault(u => u.Name == Guid.NewGuid().ToString());
            Assert.IsNull(result2);
        }

        [TestMethod]
        public void FirstOrDefault_OneTest()
        {
            // find an user
            var firstUser = Query<User>().Select(u => new User { Id = u.Id }).FirstOrDefault();
            Assert.IsNotNull(firstUser);

            var result = Query<User>().FirstOrDefault(u => u.Id == firstUser.Id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FirstOrDefault_ManyTest()
        {
            var result1 = Query<User>().FirstOrDefault();
            Assert.IsNotNull(result1);
        }
        #endregion

        #region Single
        [TestMethod]
        public void Single_NoneTest()
        {
            try
            {
                var result = Query<User>().Single(u => u.Name == Guid.NewGuid().ToString());
                Assert.Fail("the First() method did not throw any exception");
            }
            catch { }
        }

        [TestMethod]
        public void Single_OneTest()
        {
            // find an user
            var firstUser = Query<User>().Select(u => new User { Id = u.Id }).FirstOrDefault();
            Assert.IsNotNull(firstUser);

            var result = Query<User>().Single(u => u.Id == firstUser.Id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Single_ManyTest()
        {
            try
            {
                var result = Query<User>().Single();
                Assert.Fail("the Single() method did not throw any exception");
            }
            catch { }
        }

        [TestMethod]
        public void SingleOrDefault_NoneTest()
        {
            var result = Query<User>().SingleOrDefault(u => u.Name == Guid.NewGuid().ToString());
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SingleOrDefault_OneTest()
        {
            // find an user
            var firstUser = Query<User>().Select(u => new User { Id = u.Id }).FirstOrDefault();
            Assert.IsNotNull(firstUser);

            var result = Query<User>().SingleOrDefault(u => u.Id == firstUser.Id);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SingleOrDefault_ManyTest()
        {
            try
            {
                var result = Query<User>().SingleOrDefault();
                Assert.Fail("the SingleOrDefault() method did not throw any exception");
            }
            catch { }
        }
        #endregion

        #region Any
        [TestMethod]
        public void Any_NoneTest()
        {
            var result = Query<User>().Any(u => u.Name == Guid.NewGuid().ToString());
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Any_ManyTest()
        {
            var result = Query<User>().Any();
            Assert.IsTrue(result);
        }
        #endregion

        #region Count
        [TestMethod]
        public void Count_NoneTest()
        {
            var result = Query<User>().Count(u => u.Name == Guid.NewGuid().ToString());
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void Count_OneTest()
        {
            // find an user
            var firstUser = Query<User>().Select(u => new User { Id = u.Id }).FirstOrDefault();
            Assert.IsNotNull(firstUser);

            var result = Query<User>().Count(u => u.Id == firstUser.Id);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void Count_ManyTest()
        {
            var result = Query<User>().Count();
            Assert.IsTrue(result > 0);
        }
        #endregion

        #region SelectType
        [TestMethod]
        public void SelectIdAndUseAttachModelTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectIdAndUseAttachModel)
                .Select(u => new User { Name = u.Name })
                .FirstOrDefault();

            Assert.IsNotNull(user.Id);
            Assert.IsNotNull(user.Name);
            Assert.IsNull(user.MobilePhone);
        }

        [TestMethod]
        public void SelectIdAndUseReplaceModel_NoSelectTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectIdAndUseReplaceModel)
                .FirstOrDefault();

            Assert.IsNotNull(user.Id);
            Assert.IsNull(user.Name);
            Assert.IsNull(user.MobilePhone);
        }

        [TestMethod]
        public void SelectIdAndUseReplaceModel_UseSelectTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectIdAndUseReplaceModel)
                .Select(u => new User { Name = u.Name })
                .FirstOrDefault();

            Assert.IsNull(user.Id);
            Assert.IsNotNull(user.Name);
        }

        [TestMethod]
        public void SelectAllAndUseAttachModelTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectAllAndUseAttachModel)
                .Select(u => new User { Name = u.Name })
                .FirstOrDefault();

            Assert.IsNotNull(user.Id);
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.CreatedDate);
        }

        [TestMethod]
        public void SelectAllAndUseReplaceModel_NoSelectTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectAllAndUseReplaceModel)
                .FirstOrDefault();

            Assert.IsNotNull(user.Id);
            Assert.IsNotNull(user.Name);
            Assert.IsNotNull(user.CreatedDate);
        }

        [TestMethod]
        public void SelectAllAndUseReplaceModel_UseSelectTest()
        {
            var user = Query<User>(SelectTypeEnum.SelectAllAndUseReplaceModel)
                .Select(u => new User { Name = u.Name })
                .FirstOrDefault();

            Assert.IsNull(user.Id);
            Assert.IsNotNull(user.Name);
            Assert.IsNull(user.CreatedDate);
        }
        #endregion
    }
}
