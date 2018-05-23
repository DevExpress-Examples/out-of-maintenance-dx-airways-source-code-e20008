using System;
using DevExpress.Xpo;
using System.Runtime.Serialization;

namespace DXAirways.Business.Orm
{
    public class Phone : XPLiteObject
    {
		public Phone() { }

        public Phone(string phoneCode, string intlCode, string areaCode, string number, string extension) : this()
        {
            _PhoneCode = phoneCode;
            _IntlCode = intlCode;
            _AreaCode = areaCode;
            _Number = number;
            _Extension = extension;
        }

        public Phone(Session session) : base(session) { }

        public Phone(string phoneCode, string intlCode, string areaCode, string number, string extension, Session session)
            : this(session)
        {
            _PhoneCode = phoneCode;
            _IntlCode = intlCode;
            _AreaCode = areaCode;
            _Number = number;
            _Extension = extension;
        }

		protected Guid _Id;
		protected string _PhoneCode;
		protected string _IntlCode;
		protected string _AreaCode;
		protected string _Number;
		protected string _Extension;
        protected Person _Person;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(20)]
		public string PhoneCode
		{
			get { return _PhoneCode; }
			set { SetPropertyValue<string>("PhoneCode", ref _PhoneCode, value); }
		}

		[Size(5)]
		public string IntlCode
		{
			get { return _IntlCode; }
			set { SetPropertyValue<string>("IntlCode", ref _IntlCode, value); }
		}

		[Size(50)]
		public string AreaCode
		{
			get { return _AreaCode; }
			set { SetPropertyValue<string>("AreaCode", ref _AreaCode, value); }
		}

		[Size(20)]
		public string Number
		{
			get { return _Number; }
			set { SetPropertyValue<string>("Number", ref _Number, value); }
		}

		[Size(50)]
		public string Extension
		{
			get { return _Extension; }
			set { SetPropertyValue<string>("Extension", ref _Extension, value); }
		}

        [Association("Person-Phones")]
        public Person Person
        {
            get { return _Person; }
            set { SetPropertyValue<Person>("Person", ref _Person, value); }
        }

    }
}
