using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class FlightAssignment : XPLiteObject
    {
		public FlightAssignment() { }
		
		public FlightAssignment(Session session) : base(session) { }
		
		protected Guid _Id;
		protected Flight _Flight;
		protected Aircraft _Aircraft;
		protected DateTime _DepartureDate;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

        public Flight Flight
		{
			get { return _Flight; }
            set { SetPropertyValue<Flight>("Flight", ref _Flight, value); }
		}

		public Aircraft Aircraft
		{
			get { return _Aircraft; }
            set { SetPropertyValue<Aircraft>("Aircraft", ref _Aircraft, value); }
		}

		public DateTime DepartureDate
		{
			get { return _DepartureDate; }
			set { SetPropertyValue<DateTime>("DepartureDate", ref _DepartureDate, value); }
		}

    }
}
