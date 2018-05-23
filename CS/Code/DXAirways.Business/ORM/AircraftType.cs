using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class AircraftType : XPLiteObject
    {
		public AircraftType() { }
		
		public AircraftType(Session session) : base(session) { }
		
		protected Guid _Id;
		protected string _Make;
		protected string _Model;
		protected Int32 _FirstClassSeats;
		protected Int32 _CoachSeats;
		protected Int32 _MilesPerGallon;
		protected Int32 _MinorServiceMiles;
		protected Int32 _MinorServiceOutage;
		protected Int32 _MajorServiceMiles;
		protected Int32 _MajorServiceOutage;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(25)]
		public string Make
		{
			get { return _Make; }
			set { SetPropertyValue<string>("Make", ref _Make, value); }
		}

		[Size(20)]
		public string Model
		{
			get { return _Model; }
			set { SetPropertyValue<string>("Model", ref _Model, value); }
		}

		public Int32 FirstClassSeats
		{
			get { return _FirstClassSeats; }
			set { SetPropertyValue<Int32>("FirstClassSeats", ref _FirstClassSeats, value); }
		}

		public Int32 CoachSeats
		{
			get { return _CoachSeats; }
			set { SetPropertyValue<Int32>("CoachSeats", ref _CoachSeats, value); }
		}

		public Int32 MilesPerGallon
		{
			get { return _MilesPerGallon; }
			set { SetPropertyValue<Int32>("MilesPerGallon", ref _MilesPerGallon, value); }
		}

		public Int32 MinorServiceMiles
		{
			get { return _MinorServiceMiles; }
			set { SetPropertyValue<Int32>("MinorServiceMiles", ref _MinorServiceMiles, value); }
		}

		public Int32 MinorServiceOutage
		{
			get { return _MinorServiceOutage; }
			set { SetPropertyValue<Int32>("MinorServiceOutage", ref _MinorServiceOutage, value); }
		}

		public Int32 MajorServiceMiles
		{
			get { return _MajorServiceMiles; }
			set { SetPropertyValue<Int32>("MajorServiceMiles", ref _MajorServiceMiles, value); }
		}

		public Int32 MajorServiceOutage
		{
			get { return _MajorServiceOutage; }
			set { SetPropertyValue<Int32>("MajorServiceOutage", ref _MajorServiceOutage, value); }
		}

        public string MakeAndModel
        {
            get
            {
                return string.Format("{0} {1}", _Make, _Model);
            }
        }

        [Association("AircraftType-Aircraft")]
        [Aggregated]
        public XPCollection<Aircraft> Aircraft
        {
            get { return GetCollection<Aircraft>("Aircraft"); }
        }
    }
}
