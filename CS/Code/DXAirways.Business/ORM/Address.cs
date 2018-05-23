using System;
using DevExpress.Xpo;
using System.Runtime.Serialization;

namespace DXAirways.Business.Orm
{
    public class Address : XPLiteObject
    {
		public Address() { }

        public Address(string addressCode, string street1, string street2, string city, string stateOrProvince, string postalCode, string country) : this()
        {
            _AddressCode = addressCode;
            _Street1 = street1;
            _Street2 = street2;
            _City = city;
            _StateOrProvince = stateOrProvince;
            _PostalCode = postalCode;
            _Country = country;
        }

        public Address(Session session) : base(session) { }

        public Address(string addressCode, string street1, string street2, string city, string stateOrProvince, string postalCode, string country, Session session)
            : this(session)
        {
            _AddressCode = addressCode;
            _Street1 = street1;
            _Street2 = street2;
            _City = city;
            _StateOrProvince = stateOrProvince;
            _PostalCode = postalCode;
            _Country = country;
        }

		protected Guid _Id;
		protected string _AddressCode;
		protected string _Street1;
		protected string _Street2;
		protected string _City;
		protected string _StateOrProvince;
		protected string _PostalCode;
		protected string _Country;
        protected Person _Person;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(20)]
		public string AddressCode
		{
			get { return _AddressCode; }
			set { SetPropertyValue<string>("AddressCode", ref _AddressCode, value); }
		}

		[Size(75)]
		public string Street1
		{
			get { return _Street1; }
			set { SetPropertyValue<string>("Street1", ref _Street1, value); }
		}

		[Size(50)]
		public string Street2
		{
			get { return _Street2; }
			set { SetPropertyValue<string>("Street2", ref _Street2, value); }
		}

		[Size(50)]
		public string City
		{
			get { return _City; }
			set { SetPropertyValue<string>("City", ref _City, value); }
		}

		[Size(2)]
		public string StateOrProvince
		{
			get { return _StateOrProvince; }
			set { SetPropertyValue<string>("StateOrProvince", ref _StateOrProvince, value); }
		}

		[Size(15)]
		public string PostalCode
		{
			get { return _PostalCode; }
			set { SetPropertyValue<string>("PostalCode", ref _PostalCode, value); }
		}

		[Size(25)]
		public string Country
		{
			get { return _Country; }
			set { SetPropertyValue<string>("Country", ref _Country, value); }
		}

        [Association("Person-Addresses")]
        public Person Person
        {
            get { return _Person; }
            set { SetPropertyValue<Person>("Person", ref _Person, value); }
        }

    }
}
