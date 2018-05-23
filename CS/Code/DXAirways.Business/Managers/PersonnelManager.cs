using System;
using System.Collections.Generic;
using System.Transactions;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXAirways.Business.Orm;

namespace DXAirways.Business
{
    public static class PersonnelManager
    {
        public static Customer RegisterNewCustomer(string firstName, string lastName, string email, string password)
        {
            // Wrap all areas of customer registration into a single transaction.

            Customer customer = null;

            using (Session session = new Session())
            {
                session.BeginTransaction();

                try
                {
                    CustomerEngine engine = new CustomerEngine(session);
                    customer = engine.CreateCustomer(firstName, lastName, email, password);
                    session.CommitTransaction();
                }
                catch
                {
                    session.RollbackTransaction();
                    customer = null;
                }
            }

            return customer;
        }
    }
}
