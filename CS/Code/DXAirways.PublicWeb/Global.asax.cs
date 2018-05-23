using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo.DB;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dxAirways"].ConnectionString;
            XPDictionary dict = new ReflectionDictionary();
            IDataStore store = XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.SchemaAlreadyExists);

            dict.GetDataStoreSchema(
                typeof(Flight), 
                typeof(Customer),
                typeof(AircraftType),
                typeof(Aircraft), 
                typeof(CityPair),
                typeof(FlightPair),
                typeof(Airport));
            
            XpoDefault.DataLayer = new ThreadSafeDataLayer(dict, store);
            XpoDefault.Session = null;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}