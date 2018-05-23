using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class MealSchedule : XPLiteObject    
    {
		public MealSchedule() { }
		
		public MealSchedule(Session session) : base(session) { }
		
		protected Guid _Id;
		protected Int32 _BeginTime;
		protected Int32 _EndTime;
		protected string _MealServed;
		protected decimal _CostPerSeat;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		public Int32 BeginTime
		{
			get { return _BeginTime; }
			set { SetPropertyValue<Int32>("BeginTime", ref _BeginTime, value); }
		}

		public Int32 EndTime
		{
			get { return _EndTime; }
			set { SetPropertyValue<Int32>("EndTime", ref _EndTime, value); }
		}

		[Size(20)]
		public string MealServed
		{
			get { return _MealServed; }
			set { SetPropertyValue<string>("MealServed", ref _MealServed, value); }
		}

		public decimal CostPerSeat
		{
			get { return _CostPerSeat; }
			set { SetPropertyValue<decimal>("CostPerSeat", ref _CostPerSeat, value); }
		}

    }
}
