using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXAirways;
using DXAirways.Business.Orm;

namespace DXAirways.Business
{
    public class FlightEngine : EngineBase
    {
        public FlightEngine() : base() { }

        public FlightEngine(Session session) : base(session) { }

        public Airport GetAirportByCode(string airportCode)
        {
            CriteriaOperator criteria = new BinaryOperator("AirportCode", airportCode, BinaryOperatorType.Equal);
            Airport airport = OrmFactory.GetEntity<Airport>(_Session, criteria);

            return airport;
        }

        public AircraftType GetAircraftByMakeAndModel(string make, string model)
        {
            CriteriaOperator criteria = CriteriaOperator.Parse(string.Format("Make = '{0}' AND Model = '{1}'", make, model));
            AircraftType aircraftType = OrmFactory.GetEntity<AircraftType>(_Session, criteria);

            return aircraftType;
        }

        public XPCollection<Airport> GetAirports()
        {
            XPCollection<Airport> airports = OrmFactory.GetCollection<Airport>(_Session);
            
            return airports;
        }

        public XPCollection<Airport> GetAirportsByCityOrState(string cityOrState)
        {
            XPCollection<Airport> airports = null;

            if (cityOrState == string.Empty)
                airports = GetAirports();
            else
            {
                if (cityOrState.Length == 2)
                    airports = GetAirportsByState(cityOrState.ToUpper());
                else
                    airports = GetAirportsByCity(cityOrState);
            }

            return airports;
        }

        public XPCollection<Airport> GetAirportsByState(string state)
        {
            CriteriaOperator criteria = new BinaryOperator("State", state, BinaryOperatorType.Equal);
            XPCollection<Airport> airports = OrmFactory.GetCollection<Airport>(_Session, criteria);

            return airports;
        }

        public XPCollection<Airport> GetAirportsByCity(string city)
        {
            if (!city.StartsWith("%")) city = "%" + city;
            if (!city.EndsWith("%")) city = city + "%";

            CriteriaOperator criteria = new BinaryOperator("City", city, BinaryOperatorType.Like);
            XPCollection<Airport> airports = OrmFactory.GetCollection<Airport>(_Session, criteria);

            return airports;
        }

        public XPCollection<Flight> GetAllFlightsBetweenAirports(string origin, string destination)
        {
            Airport originAirport = GetAirportByCode(origin);
            Airport destinationAirport = GetAirportByCode(destination);

            string criteriaString = "Origin = '{0}' AND Destination = '{1}'";

            CriteriaOperator criteria = CriteriaOperator.Parse(string.Format(criteriaString, originAirport.Id, destinationAirport.Id));
            XPCollection<Flight> flights = OrmFactory.GetCollection<Flight>(_Session, criteria);

            return flights;
        }

        public CityPair GetCityPair(string airportCode1, string airportCode2)
        {
            Airport airport1 = GetAirportByCode(airportCode1);
            Airport airport2 = GetAirportByCode(airportCode2);

            return GetCityPair(airport1, airport2);
        }

        public CityPair GetCityPair(Guid airportId1, Guid airportId2)
        {
            Airport airport1 = OrmFactory.GetEntity<Airport>(_Session, airportId1);
            Airport airport2 = OrmFactory.GetEntity<Airport>(_Session, airportId2);
            
            return GetCityPair(airport1, airport2);
        }

        public CityPair GetCityPair(Airport airport1, Airport airport2)
        {
            string criteriaString = "(FirstCity = '{0}' AND SecondCity = '{1}') OR (FirstCity = '{1}' AND SecondCity = '{0}')";

            CriteriaOperator criteria = CriteriaOperator.Parse(string.Format(criteriaString, airport1.Id, airport2.Id));
            CityPair cityPair = OrmFactory.GetEntity<CityPair>(_Session, criteria);

            return cityPair;
        }

        public XPCollection<FlightPair> GetFlightPairsForCityPair(Guid cityPairId)
        {
            string criteriaString = "(CityPair = '{0}')";
            
            CriteriaOperator criteria = CriteriaOperator.Parse(string.Format(criteriaString, cityPairId));
            XPCollection<FlightPair> flightPairs = OrmFactory.GetCollection<FlightPair>(_Session, criteria);

            return flightPairs;
        }

        public AircraftType GetEquipmentForFlight(Guid flightId)
        {
            Flight flight = OrmFactory.GetEntity<Flight>(_Session, flightId);
            return GetEquipmentForFlight(flight);
        }
        
        public AircraftType GetEquipmentForFlight(Flight flight)
        {
            AircraftType aircraftType = null;

            string criteriaString = "FirstLeg = '{0}' or SecondLeg = '{0}'";

            CriteriaOperator criteria = CriteriaOperator.Parse(string.Format(criteriaString, flight.Id));
            XPCollection<FlightPair> flightPairs = OrmFactory.GetCollection<FlightPair>(_Session, criteria);

            if (flightPairs.Count > 0)
                aircraftType = flightPairs[0].CityPair.Equipment;

            return aircraftType;
        }

        public FlightPair GetNewFlightsForCityPair(Guid cityPairId)
        {
            CityPair cityPair = OrmFactory.GetEntity<CityPair>(_Session, cityPairId);
            return GetNewFlightsForCityPair(cityPair);
        }

        public FlightPair GetNewFlightsForCityPair(CityPair cityPair)
        {
            FlightPair flightPair = new FlightPair(_Session);
            flightPair.CityPair = cityPair;
            flightPair.FirstLeg = new Flight(_Session);
            flightPair.FirstLeg.Origin = cityPair.FirstCity;
            flightPair.FirstLeg.Destination = cityPair.SecondCity;
            flightPair.SecondLeg = new Flight(_Session);
            flightPair.SecondLeg.Origin = cityPair.SecondCity;
            flightPair.SecondLeg.Destination = cityPair.FirstCity;

            return flightPair;
        }

        public XPCollection<FlightAssignment> GetAvailableFlightAssignments(XPCollection<Flight> flights, DateTime departureDate)
        {
            // need to get Gary to help me here
            return null;
        }
    }
}
