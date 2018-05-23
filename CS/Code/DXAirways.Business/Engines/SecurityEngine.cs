using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXAirways.Business.Orm;

namespace DXAirways.Business
{
    public class SecurityEngine : EngineBase
    {
        public SecurityEngine() : base() { }

        public SecurityEngine(Session session) : base(session) { }

        public static class Roles
        {
            public static string Customer
            {
                get { return "CUST"; }
            }

            public static string CrewMember
            {
                get { return "CREW"; }
            }

            public static string Admin
            {
                get { return "ADMIN"; }
            }
        }

        public Person AuthenticateUser(string email, string password)
        {
            bool authenticated = false;

            CriteriaOperator criteria = new BinaryOperator("Email", email.ToLower(), BinaryOperatorType.Equal);
            Person person = OrmFactory.GetEntity<Person>(_Session, criteria);

            if (person != null)
            {
                if (person.Password == password)
                    authenticated = true;
            }

            if (authenticated)
                return person;
            else
                return null;
        }

        public Person FetchPerson(string email)
        {
            CriteriaOperator criteria = new BinaryOperator("Email", email.ToLower(), BinaryOperatorType.Equal);
            Person person = OrmFactory.GetEntity<Person>(_Session, criteria);

            return person;
        }
    }
}
