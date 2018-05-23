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
    public class CrewMemberEngine : EngineBase
    {
        public CrewMemberEngine() : base() { }

        public CrewMemberEngine(Session session) : base(session) { }

        public CrewMember GetCrewMember(Guid crewMemberId)
        {
            CrewMember crewMember = OrmFactory.GetEntity<CrewMember>(crewMemberId);

            return crewMember;
        }
    }
}
