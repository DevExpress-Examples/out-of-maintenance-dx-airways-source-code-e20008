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
    public class DataCreationTests
    {

        private TestContext testContextInstance;
        private Guid _AirportId = new Guid("2f67fa33-fe6f-43cf-8f14-11dd2104c944");

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
        public void create_aircraft_types_and_aircraft()
        {
            AircraftType aircraftType = new AircraftType();

            aircraftType.Make = "Boeing";
            aircraftType.Model = "737-800";
            aircraftType.FirstClassSeats = 16;
            aircraftType.CoachSeats = 140;
            aircraftType.MilesPerGallon = 20;
            aircraftType.MinorServiceMiles = 10000;
            aircraftType.MinorServiceOutage = 3;
            aircraftType.MajorServiceMiles = 50000;
            aircraftType.MajorServiceOutage = 7;

            aircraftType.Save();

            Guid aircraftTypeId = aircraftType.Id;
            aircraftType = OrmFactory.GetEntity<AircraftType>(aircraftTypeId);

            Assert.IsTrue(aircraftType != null, "Did not retrieve aircraft type just inserted");

            Aircraft aircraft = new Aircraft();

            aircraft.AircraftType = aircraftType;
            aircraft.TailNumber = "N63140";
            aircraft.EngineMiles = 23000;

            aircraft.Save();
        }

        [TestMethod]
        public void create_sample_flights()
        {
            Airport ewrAirport = new FlightEngine().GetAirportByCode("EWR");
            Airport laxAirport = new FlightEngine().GetAirportByCode("LAX");

            AircraftType boeing737 = new FlightEngine().GetAircraftByMakeAndModel("Boeing", "737-800");

            Flight flight = new Flight();

            flight.FlightNumber = "001";
            flight.Origin = ewrAirport;
            flight.Destination = laxAirport;
            flight.DepartureTime = new DateTime(0,0,0,8,30,0);
            flight.FlightTime = "04:54";
            flight.Distance = 2900;

            flight.Save();

            Assert.IsTrue(flight != null, "Flight did not save.");

            flight = new Flight();

            flight.FlightNumber = "002";
            flight.Origin = laxAirport;
            flight.Destination = ewrAirport;
            flight.DepartureTime = new DateTime(0,0,0,17,30,0);
            flight.FlightTime = "04:22";
            flight.Distance = 2900;
            
            flight.Save();

            Assert.IsTrue(flight != null, "Flight did not save.");
        }

    }
}
