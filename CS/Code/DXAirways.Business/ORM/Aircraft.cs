using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class Aircraft : XPLiteObject
    {
		public Aircraft() { }
		
		public Aircraft(Session session) : base(session) { }
		
		protected Guid _Id;
        protected AircraftType _AircraftType;
		protected string _TailNumber;
		protected Int32 _EngineMiles;
        protected bool _InService;
        protected DateTime _DateOfService;
        protected Int32 _MilesAtService;
        protected Airport _HomeAirport;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

        [Association("AircraftType-Aircraft")]
        public AircraftType AircraftType
        {
            get { return _AircraftType; }
            set { SetPropertyValue<AircraftType>("AircraftType", ref _AircraftType, value); }
        }

		[Size(20)]
		public string TailNumber
		{
			get { return _TailNumber; }
			set { SetPropertyValue<string>("TailNumber", ref _TailNumber, value); }
		}

		public Int32 EngineMiles
		{
			get { return _EngineMiles; }
			set { SetPropertyValue<Int32>("EngineMiles", ref _EngineMiles, value); }
		}

        public bool InService
        {
            get { return _InService; }
            set { SetPropertyValue<bool>("InService", ref _InService, value); }
        }

        public DateTime DateOfService
        {
            get { return _DateOfService; }
            set { SetPropertyValue<DateTime>("DateOfService", ref _DateOfService, value); }
        }

        public Int32 MilesAtService
        {
            get { return _MilesAtService; }
            set { SetPropertyValue<Int32>("MilesAtService", ref _MilesAtService, value); }
        }

        public Airport HomeAirport
        {
            get { return _HomeAirport; }
            set { SetPropertyValue<Airport>("HomeAirport", ref _HomeAirport, value); }
        }

        [Association("Aircraft-CrewMembers")]
        public XPCollection<CrewMember> CrewMembers
        {
            get
            {
                return GetCollection<CrewMember>("CrewMembers");
            }
        }

    }
}
