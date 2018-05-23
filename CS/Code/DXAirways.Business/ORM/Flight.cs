using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class Flight : XPLiteObject    
    {
		public Flight() { }
		
		public Flight(Session session) : base(session) { }
		
		protected Guid _Id;
		protected string _FlightNumber;
        protected Airport _Origin;
        protected Airport _Destination;
		protected DateTime _DepartureTime;
        protected string _FlightTime;
        protected Int32 _Distance;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(5)]
		public string FlightNumber
		{
			get { return _FlightNumber; }
			set { SetPropertyValue<string>("FlightNumber", ref _FlightNumber, value); }
		}
       
        public Airport Origin
		{
			get { return _Origin; }
            set { SetPropertyValue<Airport>("Origin", ref _Origin, value); }
		}

        public Airport Destination
		{
			get { return _Destination; }
            set { SetPropertyValue<Airport>("Destination", ref _Destination, value); }
		}

        public DateTime DepartureTime
		{
			get { return _DepartureTime; }
            set { SetPropertyValue<DateTime>("DepartureTime", ref _DepartureTime, value); }
		}

        public string FlightTime
		{
			get { return _FlightTime; }
            set { SetPropertyValue<string>("FlightTime", ref _FlightTime, value); }
		}

		public Int32 Distance
		{
			get { return _Distance; }
			set { SetPropertyValue<Int32>("Distance", ref _Distance, value); }
		}

        public string OriginCaption
        {
            get { return _Origin.AirportCode; }
        }

        public string DestinationCaption
        {
            get { return _Destination.AirportCode; }
        }

    }
}
