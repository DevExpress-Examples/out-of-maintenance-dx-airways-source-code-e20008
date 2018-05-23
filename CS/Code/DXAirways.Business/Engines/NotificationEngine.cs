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
    public class NotificationEngine : EngineBase
    {
        public NotificationEngine() : base() { }

        public NotificationEngine(Session session) : base(session) { }

    }
}
