using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXAirways.Windows.Controls
{
    public class StdButtonClickedEventArgs : EventArgs
    {
        public StdButtonClickedEventArgs(StdButtons.ButtonType buttonType)
        {
            _ButtonType = buttonType;
        }

        protected StdButtons.ButtonType _ButtonType;

        public StdButtons.ButtonType ButtonType
        {
            get { return _ButtonType; }
        }
    }
}