using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraEditors.Controls;
using DXAirways.Business;
using DXAirways.Business.Orm;
using System.Collections;
using DXAirways.Windows.Controls;

namespace DXAirways.Windows
{
    public class EditorInfo
    {
        public EditorInfo(string fieldName, object value, bool valid, string errorText)
        {
            FieldName = fieldName;
            Value = value;
            Valid = valid;
            ErrorText = errorText;
        }

        public string FieldName { get; set; }
        public object Value { get; set; }
        public bool Valid { get; set; }
        public string ErrorText { get; set; }
    }
}
