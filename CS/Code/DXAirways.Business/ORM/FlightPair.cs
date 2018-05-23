using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class FlightPair : XPLiteObject
    {
        public FlightPair() { }

        public FlightPair(Session session) : base(session) { }

        protected Guid _Id;
        protected Flight _FirstLeg;
        protected Flight _SecondLeg;
        protected CityPair _CityPair;

        [Key(true)]
        public Guid Id
        {
            get { return _Id; }
            set { SetPropertyValue<Guid>("Id", ref _Id, value); }
        }

        public Flight FirstLeg
        {
            get { return _FirstLeg; }
            set { SetPropertyValue<Flight>("FirstLeg", ref _FirstLeg, value); }
        }

        public Flight SecondLeg
        {
            get { return _SecondLeg; }
            set { SetPropertyValue<Flight>("SecondLeg", ref _SecondLeg, value); }
        }
        
        [Association("CityPair-FlightPairs")]
        public CityPair CityPair
        {
            get { return _CityPair; }
            set { SetPropertyValue<CityPair>("CityPair", ref _CityPair, value); }
        }

    }
}
