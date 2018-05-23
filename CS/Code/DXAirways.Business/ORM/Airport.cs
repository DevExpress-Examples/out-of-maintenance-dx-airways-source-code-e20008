using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class Airport : XPLiteObject
    {
		public Airport() { }
		
		public Airport(Session session) : base(session) { }
		
		protected Guid _Id;
		protected string _AirportCode;
        protected int _UtcOffset;
		protected string _Name;
        protected string _City;
        protected string _State;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(3)]
		public string AirportCode
		{
			get { return _AirportCode; }
			set { SetPropertyValue<string>("AirportCode", ref _AirportCode, value); }
		}

        public int UtcOffset
		{
            get { return _UtcOffset; }
            set { SetPropertyValue<int>("UtcOffset", ref _UtcOffset, value); }
		}

		[Size(50)]
		public string Name
		{
			get { return _Name; }
			set { SetPropertyValue<string>("Name", ref _Name, value); }
		}

        [Size(75)]
        public string City
        {
            get { return _City; }
            set { SetPropertyValue<string>("City", ref _City, value); }
        }

        [Size(2)]
        public string State
        {
            get { return _State; }
            set { SetPropertyValue<string>("State", ref _State, value); }
        }
        
        public string DisplayCaption
        {
            get
            {
                return AirportCode + " - " + Name;
            }
        }

        public string CityState
        {
            get
            {
                return City + ", " + State;
            }
        }

    }
}
