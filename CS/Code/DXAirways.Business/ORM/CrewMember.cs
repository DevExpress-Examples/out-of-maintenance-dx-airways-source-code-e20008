using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class CrewMember : Person
    {
        public CrewMember()  { } 
		
		public CrewMember(Session session) : base(session) { }
		
		protected string _Position;
		protected decimal _Salary;
		protected DateTime _DateOfHire;
		protected Airport _HomeAirport;
        protected Aircraft _Aircraft;

		[Size(20)]
		public string Position
		{
			get { return _Position; }
			set { SetPropertyValue<string>("Position", ref _Position, value); }
		}

		public decimal Salary
		{
			get { return _Salary; }
			set { SetPropertyValue<decimal>("Salary", ref _Salary, value); }
		}

		public DateTime DateOfHire
		{
			get { return _DateOfHire; }
			set { SetPropertyValue<DateTime>("DateOfHire", ref _DateOfHire, value); }
		}

        public Airport HomeAirport
		{
			get { return _HomeAirport; }
            set { SetPropertyValue<Airport>("HomeAirport", ref _HomeAirport, value); }
		}

        [Association("Aircraft-CrewMembers")]
        public Aircraft Aircraft
        {
            get { return _Aircraft; }
            set { SetPropertyValue<Aircraft>("Aircraft", ref _Aircraft, value); }
        }

        [Association("CrewMember-Vacations")]
        [Aggregated]
        public XPCollection<VacationSchedule> Vacations
        {
            get
            {
                return GetCollection<VacationSchedule>("Vacations");
            }
        }
    }
}
