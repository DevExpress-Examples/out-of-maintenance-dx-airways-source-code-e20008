using System;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Test
{
    [TestClass]
    public class XpoTests
    {

        private TestContext testContextInstance;

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

        [ClassInitialize()]
        public static void Initialize(TestContext testContext) 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dxAirways"].ConnectionString;
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.SchemaOnly);            
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void LoadAndAccessPickLists()
        {
            PickLists allLists = PickLists.Load();

            PickList phoneTypes = allLists["PHONE"];

            Assert.IsTrue(phoneTypes.Count == 3, "Something is wrong with the phone count.");
        }

        private Airport GetAirport()
        {
            Guid airportId = new Guid("2f67fa33-fe6f-43cf-8f14-11dd2104c944");
            return GetAirport(airportId);
        }

        private Airport GetAirport(Guid airportId)
        {
            Airport airport = null;
            CriteriaOperator criteria = new BinaryOperator("Id", airportId, BinaryOperatorType.Equal);
            using (XPCollection<Airport> airports = new XPCollection<Airport> { Criteria = criteria })
            {
                airports.Load();
                if (airports.Count > 0)
                    airport = airports[0];
            }
            return airport;
        }

        [TestMethod]
        public void CreateCityPairs()
        {
            Session session = new Session();
            Airport lax = new FlightEngine(session).GetAirportByCode("LAX");
            Airport jfk = new FlightEngine(session).GetAirportByCode("JFK");
            Guid id = new Guid("cbb109ed-949d-44e5-9c45-08dd4164c6d6");
            AircraftType b737 = OrmFactory.GetEntity<AircraftType>(session, id);

            CityPair pair = new CityPair(session);
            pair.FirstCity = lax;
            pair.SecondCity = jfk;
            pair.Equipment = b737;

            pair.Save();
        }

        [TestMethod]
        public void CreateTimeZones()
        {
            Session session = new Session();

            
        }

    }
}
