using System;
using System.Text;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DXAirways.Business.Orm;

namespace DXAirways.Test
{
    [TestClass]
    public class OrmFactoryTests
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
        public void create_retrieve_and_delete_new_customer_with_addresses_and_phone_numbers()
        {
            Customer customer = new Customer();
            
            customer.FirstName = "Miguel";
            customer.LastName = "Castro";

            customer.Addresses.Add(new Address("HOME", "12 Kevin Road", "", "Lincoln Park", "NJ", "07035", "USA"));
            customer.Addresses.Add(new Address("WORK", "801 North Brand Blvd.", "Suite 850", "Glendale", "CA", "91203", "USA"));

            customer.Phones.Add(new Phone("HOME", "1", "973", "7090714", ""));
            customer.Phones.Add(new Phone("WORK", "1", "973", "4544713", ""));

            customer.Roles.Add(new Role("CUST"));

            customer.Save();

            Assert.IsTrue(1==1, "Customer did not save.");

            Guid customerId = customer.Id;
            customer = OrmFactory.GetEntity<Customer>(customerId);

            Assert.IsTrue(customer != null, "Did not retrieve customer just inserted.");
            Assert.IsTrue(customer.Id == customerId, "IDs don't match");
            Assert.IsTrue(customer.FirstName == "Miguel" && customer.LastName == "Castro", "Wrong person.");
            Assert.IsTrue(customer.Addresses.Count == 2, "Wrong number of addresses.");
            Assert.IsTrue(customer.Phones.Count == 2, "Wrong number of phones.");

            customer.Delete();

            customer = OrmFactory.GetEntity<Customer>(customerId);

            Assert.IsTrue(customer == null, "Customer did not delete.");
        }

        [TestMethod]
        public void create_new_aircraft_type()
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
        }

        [TestMethod]
        public void create_new_aircraft_based_on_existing_aircraft_type()
        {
            XPCollection<AircraftType> aircraftTypes = OrmFactory.GetCollection<AircraftType>();

            if (aircraftTypes.Count > 0)
            {
                AircraftType aircraftType = aircraftTypes[0];

                Aircraft aircraft = new Aircraft();

                //aircraft.AircraftTypeId = aircraftType.Id;
                aircraft.AircraftType = aircraftType;
                aircraft.TailNumber = "N63140";
                aircraft.EngineMiles = 23000;

                aircraft.Save();
            }
        }
    }
}
