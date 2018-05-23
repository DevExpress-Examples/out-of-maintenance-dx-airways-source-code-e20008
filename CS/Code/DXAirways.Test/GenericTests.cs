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
    public class GenericTests
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
        public void generate_new_dxmiles_number()
        {
            bool unique = false;
            int retries = 0;
            string newMilesNumber = string.Empty;

            while (!unique)
            {
                CustomerEngine engine = new CustomerEngine();

                newMilesNumber = engine.GenerateNewMilesNumber();
                Customer customer = engine.GetCustomerByMilesNumber(newMilesNumber);
                if (customer != null)
                    retries++;
                else
                    unique = true;

                if (retries > 3)
                    break;
            }

            if (retries > 3 && !unique)
                Assert.Fail("Too many retries and a unique miles # was not generated.");

            Assert.IsTrue(unique && newMilesNumber != string.Empty, "Unique miles number was not able to generate.");
        }
    }
}
