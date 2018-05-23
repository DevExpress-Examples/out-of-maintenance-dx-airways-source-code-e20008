using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Windows
{
    public delegate void ValidateFieldDelegate(ColumnView view, EditorInfo e);

    public class ColumnViewValidationHelper : Component
    {
        public ColumnViewValidationHelper()
        {
        }

        public ColumnViewValidationHelper(ColumnView columnView)
        {
            _View = columnView;
            HookupEvents();
        }

        private ColumnView _View;
        private bool _ValidateEntireRowOnly = false;

        public event ValidateFieldDelegate ValidateField;

        public ColumnView View
        {
            get
            {
                return _View;
            }
            set
            {
                _View = value;
                HookupEvents();
            }
        }

        public bool ValidateEntireRowOnly
        {
            get
            {
                return _ValidateEntireRowOnly;
            }
            set
            {
                _ValidateEntireRowOnly = value;
            }
        }
        
        private void HookupEvents()
        {
            _View.ValidatingEditor += ValidationLayoutView_ValidatingEditor;
            _View.ValidateRow += ValidationLayoutView_ValidateRow;
            _View.InvalidValueException += ValidationLayoutView_InvalidValueException;
            _View.InvalidRowException += ValidationLayoutView_InvalidRowException;
        }

        void ValidationLayoutView_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (!_ValidateEntireRowOnly)
            {
                ColumnView view = (ColumnView)sender;
                
                EditorInfo info = new EditorInfo(view.FocusedColumn.FieldName, e.Value, e.Valid, e.ErrorText);
                ValidateField.Invoke(view, info);

                e.Value = info.Value;
                e.Valid = info.Valid;
                e.ErrorText = info.ErrorText;
            }
        }

        void ValidationLayoutView_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        void ValidationLayoutView_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            ColumnView view = (ColumnView)sender;

            foreach (GridColumn column in view.Columns)
            {
                object value = view.GetRowCellValue(e.RowHandle, column);

                EditorInfo info = new EditorInfo(column.FieldName, value, true, string.Empty);
                ValidateField.Invoke(view, info);

                if (!info.Valid)
                {
                    view.SetColumnError(column, info.ErrorText);
                    e.Valid = false;
                }
            }
        }

        void ValidationLayoutView_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
