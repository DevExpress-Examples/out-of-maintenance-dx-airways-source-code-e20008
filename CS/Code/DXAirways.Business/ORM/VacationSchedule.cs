using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class VacationSchedule : XPLiteObject    
    {
		public VacationSchedule() { }
		
		public VacationSchedule(Session session) : base(session) { }
		
		protected Guid _Id;
		protected DateTime _StartDate;
		protected DateTime _EndDate;
		protected string _Description;
		protected Int32 _VacationDays;
        protected CrewMember _CrewMember;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		public DateTime StartDate
		{
			get { return _StartDate; }
			set { SetPropertyValue<DateTime>("StartDate", ref _StartDate, value); }
		}

		public DateTime EndDate
		{
			get { return _EndDate; }
			set { SetPropertyValue<DateTime>("EndDate", ref _EndDate, value); }
		}

		[Size(200)]
		public string Description
		{
			get { return _Description; }
			set { SetPropertyValue<string>("Description", ref _Description, value); }
		}

		public Int32 VacationDays
		{
			get { return _VacationDays; }
			set { SetPropertyValue<Int32>("VacationDays", ref _VacationDays, value); }
		}

        [Association("CrewMember-Vacations")]
        [Aggregated]
        public CrewMember CrewMember
        {
            get { return _CrewMember; }
            set { SetPropertyValue<CrewMember>("CrewMember", ref _CrewMember, value); }
        }

    }
}
