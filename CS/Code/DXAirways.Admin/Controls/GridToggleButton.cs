using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DXAirways.Windows.Controls
{
    public class GridToggleButton : SimpleButton
    {
        public GridToggleButton()
        {
            this.Click += GridToggleButton_Click;
        }

        private GridControl _Grid;
        private ColumnView _ListView;
        private ColumnView _MaintView;

        public GridControl Grid
        {
            get { return _Grid; }
            set { _Grid = value; }
        }

        public ColumnView ListView
        {
            get { return _ListView; }
            set { _ListView = value; }
        }

        public ColumnView MaintView
        {
            get { return _MaintView; }
            set { _MaintView = value; }
        }
        
        void GridToggleButton_Click(object sender, EventArgs e)
        {
            if (_Grid != null & _ListView != null && _MaintView != null)
            {
                if (_Grid.MainView.Name == _ListView.Name)
                {
                    _Grid.MainView = _MaintView;
                    _Grid.UseEmbeddedNavigator = true;
                }
                else
                {
                    _Grid.MainView = _ListView;
                    _Grid.UseEmbeddedNavigator = false;
                }
            }
        }
    }
}
