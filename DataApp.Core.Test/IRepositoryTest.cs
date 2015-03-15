﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataApp.Core.Abstracts;
using DataApp.Core.DAL;
using DataApp.Core.Models;

namespace DataApp.Core.Test
{
    [TestClass]
    public class IRepositoryTest
    {
        IRepositoryFactory factory = null;
        DataAppContext dbContext = null;
        /// <summary>
        /// Target of our test.
        /// </summary>
        IRepository<User> repository = null;
        /// <summary>
        /// Object to be used by our target as an argument.
        /// </summary>
        User entity = null;

        /// <summary>
        /// Encapslates Arrange process segment in our tests.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.dbContext = new DAL.DataAppContext();
            this.factory = new DataApp.Core.Factories.RepoFactory();
            this.repository = this.factory.CreateRepository<User>(this.dbContext);
            this.entity = new User();
            entity.Username = "New";
            entity.Password = "New";
        }

        [TestMethod]
        public void Add()
        {
            //arrange
            //act
            //done on Init()
            //assert
            Assert.IsTrue(this.repository.Add(this.entity));
        }

        [TestMethod]
        public void Update()
        {
            //arrange
            //act
            this.repository.Add(this.entity);
            this.entity.Username = "Update";
            this.entity.Password = "Update";

            //assert
            Assert.IsTrue(this.repository.Update(this.entity));
        }

        [TestMethod]
        public void Delete()
        {
            //arrange
            //act
            this.repository.Add(this.entity);
            //assert
            Assert.IsTrue(this.repository.Update(this.entity));
        }

        [TestMethod]
        public void Get()
        {
            //arrange
            //act
            var user = this.repository.Get(p => p.ID > 0);
            //assert
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void GetAll()
        {
            //arrange
            //act
            var user = this.repository.GetAll();
            //assert
            Assert.IsNotNull(user);
        }
    }
}
