using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class PersonTest : XPLiteObject
    {
        private Guid _ID;
        private string _FirstName;
        private string _LastName;

        public Guid ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
    }

    public class AirportTest : XPLiteObject
    {
        private Guid _ID;
        private string _Code;
        private string _Name;

        public Guid ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }        
    }

    public class CrewMemberTest : PersonTest
    {
        private DateTime _DateOfHire;
        private AirportTest _HomeAirport;

        public DateTime DateOfHire
        {
            get { return _DateOfHire; }
            set { _DateOfHire = value; }
        }

        public AirportTest HomeAirport
        {
            get { return _HomeAirport; }
            set { _HomeAirport = value; }
        }
    }
}
