using LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Tests
{
    [TestClass]
    public class susbscriberrepositorytest
    {
        public TestContext TestContext
        {
            get;
            set;
        }
        [TestMethod]
        public void FindTestExistingSubscriber()
        {
            {
                subscriberrepository repository = new subscriberrepository();
                var subscriberlist = repository.Retrieve();

                //act
                var result = repository.Find(subscriberlist, 2);
                //assert
                Assert.AreEqual(2, result.SubscriberId);
                Assert.AreEqual("sriram", result.FirstName);
                Assert.AreEqual("Tellapragada", result.LastName);
                Assert.AreEqual("sriramt@gmail.com", result.EmailId);

            }
        }
        [TestMethod]
        public void FindTestNotFoundinExistingSubscriber()
        {
            //Arrange
            subscriberrepository repository = new subscriberrepository();
            var subscriberlist = repository.Retrieve();
            //Act
            var result = repository.Find(subscriberlist, 22);
            //Assert
            Assert.IsNull(result);

        }
    }
}
