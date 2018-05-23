using System;
using DevExpress.Xpo;
using System.Runtime.Serialization;

namespace DXAirways.Business.Orm
{
    public class Person : XPLiteObject
    {
        public Person() { }

        public Person(Session session) : base(session) { }

        protected Guid _Id;
        protected string _FirstName;
        protected string _LastName;
        protected string _Email;
        protected string _Password;

        [Key(true)]
        public Guid Id
        {
            get { return _Id; }
            set { SetPropertyValue<Guid>("Id", ref _Id, value); }
        }

        [Size(50)]
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>("FirstName", ref _FirstName, value); }
        }

        [Size(50)]
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>("LastName", ref _LastName, value); }
        }

        [Size(75)]
        public string Email
        {
            get { return _Email; }
            set { SetPropertyValue<string>("Email", ref _Email, value); }
        }

        [Size(75)]
        public string Password
        {
            get { return _Password; }
            set { SetPropertyValue<string>("Password", ref _Password, value); }
        }

        [Association("Person-Addresses")]
        [Aggregated]
        public XPCollection<Address> Addresses
        {
            get { return GetCollection<Address>("Addresses"); }
        }

        [Association("Person-Phones")]
        [Aggregated]
        public XPCollection<Phone> Phones
        {
            get { return GetCollection<Phone>("Phones"); }
        }

        [Association("Person-Roles")]
        [Aggregated]
        public XPCollection<Role> Roles
        {
            get { return GetCollection<Role>("Roles"); }
        }

        public string FullName
        {
            get { return _FirstName + " " + _LastName; }
        }

    }
}
