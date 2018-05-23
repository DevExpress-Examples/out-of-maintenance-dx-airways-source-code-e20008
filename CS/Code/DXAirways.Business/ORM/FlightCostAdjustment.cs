using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class FlightCostAdjustment : XPLiteObject
    {
		public FlightCostAdjustment() { }
		
		public FlightCostAdjustment(Session session) : base(session) { }
		
		protected Guid _Id;
		protected Int32 _DaysOut;
		protected Int32 _PctAboveBase;

		[Key(true)]
		public Guid Id
		{
			get { return _Id; }
			set { SetPropertyValue<Guid>("Id", ref _Id, value); }
		}

		public Int32 DaysOut
		{
			get { return _DaysOut; }
			set { SetPropertyValue<Int32>("DaysOut", ref _DaysOut, value); }
		}

		public Int32 PctAboveBase
		{
			get { return _PctAboveBase; }
			set { SetPropertyValue<Int32>("PctAboveBase", ref _PctAboveBase, value); }
		}

    }
}
