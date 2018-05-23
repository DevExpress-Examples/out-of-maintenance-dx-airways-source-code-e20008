using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Web
{
    public class FlightSearchEventArgs : EventArgs
    {
        public FlightSearchEventArgs(string originAirport, string destinationAirport, DateTime departureDate, DateTime returnDate, TimeSlot departureTime, TimeSlot returnTime, CabinSeating seating, int numberOfPassengers)
        {
            _OriginAirport = originAirport;
            _DestinationAirport = destinationAirport;
            _DepartureDate = departureDate;
            _ReturnDate = returnDate;
            _DepartureTime = departureTime;
            _ReturnTime = returnTime;
            _Seating = seating;
            _NumberOfPassengers = numberOfPassengers;
        }

        protected string _OriginAirport;
        protected string _DestinationAirport;
        protected DateTime _DepartureDate;
        protected DateTime _ReturnDate;
        protected TimeSlot _DepartureTime;
        protected TimeSlot _ReturnTime;
        protected CabinSeating _Seating;
        protected int _NumberOfPassengers;

        public string OriginAirport
        {
            get { return _OriginAirport; }
        }

        public string DestinationAirport
        {
            get { return _DestinationAirport; }
        }

        public DateTime DepartureDate
        {
            get { return _DepartureDate; }
        }

        public DateTime ReturnDate
        {
            get { return _ReturnDate; }
        }

        public TimeSlot DepartureTime
        {
            get { return _DepartureTime; }
        }

        public TimeSlot ReturnTime
        {
            get { return _ReturnTime; }
        }

        public CabinSeating Seating
        {
            get { return _Seating; }
        }

        public int NumberOfPassengers
        {
            get { return _NumberOfPassengers; }
        }
    }


}
