using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostProjectWebServices.Models.Repositories;
using PostProjectWebServices.Statistics;

namespace WebServiceUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCitiesTestMethod1()
        {
            CityRepository cityRepository = new CityRepository();

            HashSet<String> citiesSet = cityRepository.GetCities();

            Assert.IsNotNull(citiesSet);
        }

        [TestMethod]
        public void CountCitiesTestMethod1()
        {
            StatisticsHandler statisticsHandler = new StatisticsHandler();

            statisticsHandler.CountPackagesPerCity();
        }
    }
}
