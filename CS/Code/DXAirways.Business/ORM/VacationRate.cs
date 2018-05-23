using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class VacationRate : XPLiteObject    
    {
		public VacationRate() { }
		
		public VacationRate(Session session) : base(session) { }
		
		protected Guid _Id;
		protected string _Position;
		protected Int32 _BaseVacationDays;
		protected Int32 _PlusOneYear;
		protected Int32 _PlusFiveYear;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		[Size(20)]
		public string Position
		{
			get { return _Position; }
			set { SetPropertyValue<string>("Position", ref _Position, value); }
		}

		public Int32 BaseVacationDays
		{
			get { return _BaseVacationDays; }
			set { SetPropertyValue<Int32>("BaseVacationDays", ref _BaseVacationDays, value); }
		}

		public Int32 PlusOneYear
		{
			get { return _PlusOneYear; }
			set { SetPropertyValue<Int32>("PlusOneYear", ref _PlusOneYear, value); }
		}

		public Int32 PlusFiveYear
		{
			get { return _PlusFiveYear; }
			set { SetPropertyValue<Int32>("PlusFiveYear", ref _PlusFiveYear, value); }
		}

    }
}
