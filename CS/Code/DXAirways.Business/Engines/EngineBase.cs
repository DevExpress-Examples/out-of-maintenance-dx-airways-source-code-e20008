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
    public abstract class EngineBase
    {
        public EngineBase()
        {
            _Session = new Session();
        }

        public EngineBase(Session session)
        {
            _Session = session;
        }

        protected Session _Session = null;
    }
}
