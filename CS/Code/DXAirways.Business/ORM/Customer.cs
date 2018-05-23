using System;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public class Customer : Person
    {
		public Customer() : base() { }
		
		public Customer(Session session) : base(session) { }
		
		protected string _DxMilesNumber;
        protected long _FlyerMiles;

		[Size(15)]
		public string DxMilesNumber
		{
			get { return _DxMilesNumber; }
			set { SetPropertyValue<string>("DxMilesNumber", ref _DxMilesNumber, value); }
		}

        public long FlyerMiles
        {
            get { return _FlyerMiles; }
            set { SetPropertyValue<long>("FlyerMiles", ref _FlyerMiles, value); }
        }

    }
}
