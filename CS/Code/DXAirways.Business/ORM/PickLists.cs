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
    public class PickLists : XPLiteObject
    {
        protected PickList _FullList;
        protected Dictionary<string, PickList> _AllLists;

        public PickList this[string listType]
        {
            get
            {
                PickList listToReturn = null;

                if (_AllLists == null)
                    _AllLists = new Dictionary<string, PickList>();

                if (!_AllLists.ContainsKey(listType))
                {
                    listToReturn = new PickList();

                    foreach (PickListItem item in _FullList)
                    {
                        if (item.Type.ToLower() == listType.ToLower())
                            listToReturn.Add(item);
                    }

                    _AllLists.Add(listType, listToReturn);
                }
                else
                    listToReturn = _AllLists[listType];

                return listToReturn;
            }
        }

        public static PickLists Load()
        {
            PickLists obj = new PickLists();            

            using (IDataReader reader = new DataAccess().PickListGetAll())
            {
                while (reader.Read())
                {
                    if (obj._FullList == null)
                        obj._FullList = new PickList();

                    obj._FullList.Add(new PickListItem(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
            }

            return obj;
        }

        public static PickList Load(string listType)
        {
            PickList list = null;

            using (IDataReader reader = new DataAccess().PickListGetByType(listType))
            {
                while (reader.Read())
                {
                    if (list == null)
                        list = new PickList();

                    list.Add(new PickListItem(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                }
            }

            return list;
        }
    }
}