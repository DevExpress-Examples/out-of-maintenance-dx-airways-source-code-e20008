using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Runtime.Serialization;

namespace DXAirways.Business.Orm
{
    public class Role : XPLiteObject
    {
        public Role() { }

        public Role(Session session) : base(session) { }

        public Role(string roleName)
        {
            _RoleName = roleName;
        }

        public Role(string roleName, Session session) : base(session)
        {
            _RoleName = roleName;
        }

        protected Guid _Id;
        protected string _RoleName;
        protected Person _Person;

        [Key(true)]
        public Guid Id
        {
            get { return _Id; }
            set { SetPropertyValue<Guid>("Id", ref _Id, value); }
        }

        public string RoleName
        {
            get { return _RoleName; }
            set { SetPropertyValue<string>("RoleName" ,ref _RoleName, value); }
        }

        [Association("Person-Roles")]
        public Person Person
        {
            get { return _Person; }
            set { SetPropertyValue<Person>("Person", ref _Person, value); }
        }

    }
}
