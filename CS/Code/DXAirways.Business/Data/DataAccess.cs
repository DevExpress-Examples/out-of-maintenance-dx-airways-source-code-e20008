using System;
using System.Configuration;
using System.Data;

namespace DXAirways.Data
{
    public class DataAccess : DalBase
	{
        #region Constructors

        public DataAccess()
            : base("dxAirways") { }

        #endregion

        #region Stored procedures
		
        public IDataReader PickListGetAll()
		{
            string sql = "Select Type, Code, Description From PickList Order By Type, SortOrder";
			return GetReader(sql, CommandType.Text);
		}


        public IDataReader PickListGetByType(string type)
        {
            string sql = string.Format("Select Type, Code, Description From PickList Where Type = '{0}' Order By SortOrder", type);
            return GetReader(sql, CommandType.Text);
        }

        #endregion

    }
}
