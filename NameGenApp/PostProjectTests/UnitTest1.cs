﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NameGenApp.Database;
using PostProjectWebServices.Models;
using PostProjectWebServices.Models.Repositories;


namespace PostProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAllPackagesTestMethod1()
        {
            Mock<IPackageRepository> mock = new Mock<IPackageRepository>();

            mock.Object.GetAllPackages();

            mock.Verify(t => t.GetAllPackages());
        }

        [TestMethod]
        public void CreatePackageTestMethod1()
        {
            Mock<IPackageRepository> mock = new Mock<IPackageRepository>();
            Package package = new Package();

            mock.Object.CreatePackage(package);
            mock.VerifyAll();
            mock.Verify(t => t.CreatePackage(package));
        }

        [TestMethod]
        public void GetAllPackagesTestMethod2()
        {
            // Integration testing without mock
            PackageRepository packageRepository = new PackageRepository();

            List<Package> packages = packageRepository.GetAllPackages();

            Assert.IsNotNull(packages);
        }
    }
}
