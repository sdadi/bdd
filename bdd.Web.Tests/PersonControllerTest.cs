using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bdd.Web.Controllers;
using bdd.Core.RepositoryInterfaces;
using bdd.Infrastructure.Repository;

namespace bdd.Web.Tests
{
    [TestClass]
    public class PersonControllerTest
    {
        private IPersonRepository _repository = null;
        private PersonController _controller = null;
        [TestInitialize]
        public void SetUp()
        {
            _repository = new PersonRepository();
            _controller = new PersonController(_repository);
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
