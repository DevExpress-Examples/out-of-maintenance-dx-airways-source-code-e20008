using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DevExpress.Data;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DXAirways.Data;

namespace DXAirways.Business.Orm
{
    public class PickListItem
    {
        public PickListItem()
        {
        }

        public PickListItem(string type, string code, string description)
        {
            _Type = type;
            _Code = code;
            _Description = description;
        }
        protected string _Type;
        protected string _Code;
        protected string _Description;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

    }
}
