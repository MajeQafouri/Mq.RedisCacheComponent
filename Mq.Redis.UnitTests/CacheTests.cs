using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mq.Redis.Common;
using Mq.Redis.Common.Interfaces;
using Mq.Redis.UnitTests.Models;
using System.Collections.Generic;

namespace Mq.Redis.UnitTests
{
    [TestClass]

    public class CacheTests
    {
        ICacheProvider _cacheProvider;
        readonly string _key = "People";

        [TestInitialize]
        public void Initialize()
        {
            _cacheProvider = new RedisCacheProvider();
        }

        [TestMethod]
        public void Test_SetValue()
        {
            List<Person> people = GetNewPerson();
            _cacheProvider.Set(_key, people);
            var isInCache = _cacheProvider.IsInCache(_key);


            Assert.IsTrue(isInCache);
        }

      

        [TestMethod]
        public void Test_GetValue()
        {
            List<Person> people = GetNewPerson();
            _cacheProvider.Set(_key, people);
            var person = _cacheProvider.Get<List<Person>>(_key);
             
            Assert.IsNotNull(person);
            Assert.IsNotNull(person[0].Contacts);
            Assert.AreEqual(2, person[0].Contacts.Count);
        }

        [TestMethod]
        public void Test_RemoveValue()
        {
            var result = _cacheProvider.Remove(_key);
            var person = _cacheProvider.Get<List<Person>>(_key);

            Assert.IsNull(person);
        }

        

        #region private method

        private List<Person> GetNewPerson()
        {
            return new List<Person>()
            {
                new Person(1, "Joe", new List<Contact>()
                {
                    new Contact("1", "123456789"),
                    new Contact("2", "234567890")
                })
            };
        }
        #endregion
    }
} 
