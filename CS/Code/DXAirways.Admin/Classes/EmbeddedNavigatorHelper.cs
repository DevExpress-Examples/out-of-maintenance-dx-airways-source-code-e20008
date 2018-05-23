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
    public class EmbeddedNavigatorHelper : Component
    {
        public EmbeddedNavigatorHelper()
        {
        }
        
        public EmbeddedNavigatorHelper(ControlNavigator navigator)
        {
            _Navigator = navigator;
            HookupEvents();
        }

        private ControlNavigator _Navigator;

        public ControlNavigator Navigator
        {
            get
            {
                return _Navigator;
            }
            set
            {
                _Navigator = value;
                HookupEvents();
            }
        }
        
        private void HookupEvents()
        {
            _Navigator.ButtonClick += _Navigator_ButtonClick;
        }

        void _Navigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (_Navigator != null)
            {
                GridControl grd = _Navigator.Parent as GridControl;

                if (grd != null)
                {
                    ColumnView view = (ColumnView)(grd.FocusedView);

                    switch (e.Button.ButtonType)
                    {
                        case NavigatorButtonType.Append:

                            // Handle this manually so we can put the grid into edit mode on the first field right away.
                            // Otherwise, the new row will be created but we'll be able to press OK without entering data,
                            // and until we focus on a field we won't be in edit mode and validation event won't fire.

                            // Determine first visible column
                            GridColumn firstColumn = null;
                            foreach (GridColumn column in view.Columns)
                            {
                                if (column.Visible)
                                {
                                    firstColumn = column;
                                    break;
                                }
                            }

                            view.AddNewRow();
                            view.FocusedColumn = firstColumn; // _View.Columns["AirportCode"];
                            view.ShowEditor();

                            e.Handled = true;

                            break;

                        case NavigatorButtonType.Remove:

                            if (MessageBox.Show("Are you sure want to remove the current record?\n\rNote: actual deletion will not take place until you confirm the form with 'OK' or 'Apply'.",
                                                "Confirm Remove", MessageBoxButtons.YesNo) == DialogResult.No)
                                e.Handled = true;

                            break;
                    }
                }
            }
        }
    }
}
