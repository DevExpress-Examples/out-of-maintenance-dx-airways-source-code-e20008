using System;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DXAirways.Business.Orm
{
    public static class OrmFactory
    {
        public static T GetEntity<T>(Guid id) where T : XPBaseObject
        {
            Session session = new Session();
            return GetEntity<T>(session, id);
        }

        public static T GetEntity<T>(Session session, Guid id) where T : XPBaseObject
        {
            T obj = session.GetObjectByKey<T>(id);
            return obj;
        }

        public static T GetEntity<T>(CriteriaOperator criteria) where T : XPBaseObject
        {
            Session session = new Session();
            return GetEntity<T>(session, criteria);
        }

        public static T GetEntity<T>(Session session, CriteriaOperator criteria) where T : XPBaseObject
        {
            T obj = session.FindObject<T>(criteria);
            return obj;
        }

        public static XPCollection<T> GetCollection<T>() where T : XPBaseObject, new()
        {
            Session session = new Session();
            return GetCollection<T>(session);
        }

        public static XPCollection<T> GetCollection<T>(Session session) where T : XPBaseObject, new()
        {
            XPCollection<T> list = new XPCollection<T>(session);
            return list;
        }

        public static XPCollection<T> GetCollection<T>(CriteriaOperator criteria) where T : XPBaseObject, new()
        {
            Session session = new Session();
            return GetCollection<T>(session, criteria);
        }

        public static XPCollection<T> GetCollection<T>(Session session, CriteriaOperator criteria) where T : XPBaseObject, new()
        {
            XPCollection<T> list = new XPCollection<T>(session) { Criteria = criteria };
            return list;
        }

        public static XPCollection GetBindingCollection<T>() where T : XPBaseObject, new()
        {
            Session session = new Session();
            return GetBindingCollection<T>(session);
        }

        public static XPCollection GetBindingCollection<T>(Session session) where T : XPBaseObject, new()
        {
            XPCollection list = new XPCollection(session, typeof(T));
            return list;
        }

    }
}