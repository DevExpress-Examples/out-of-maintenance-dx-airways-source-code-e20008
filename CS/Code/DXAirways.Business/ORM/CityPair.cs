using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class CityPair : XPLiteObject
    {
        public CityPair() { }

        public CityPair(Session session) : base(session) { }

        protected Guid _Id;
        protected Airport _FirstCity;
        protected Airport _SecondCity;
        protected AircraftType _Equipment;

        [Key(true)]
        public Guid Id
        {
            get { return _Id; }
            set { SetPropertyValue<Guid>("Id", ref _Id, value); }
        }

        public Airport FirstCity
        {
            get { return _FirstCity; }
            set { SetPropertyValue<Airport>("FirstCity", ref _FirstCity, value); }
        }

        public Airport SecondCity
        {
            get { return _SecondCity; }
            set { SetPropertyValue<Airport>("_Destination", ref _SecondCity, value); }
        }

        public AircraftType Equipment
        {
            get { return _Equipment; }
            set { SetPropertyValue<AircraftType>("Equipment", ref _Equipment, value); }
        }

        [Association("CityPair-FlightPairs")]
        [Aggregated]
        public XPCollection<FlightPair> FlightPairs
        {
            get { return GetCollection<FlightPair>("FlightPairs"); }
        }

        public string DisplayCaption
        {
            get { return _FirstCity.AirportCode + " - " + _SecondCity.AirportCode; }
        }
    }
}
