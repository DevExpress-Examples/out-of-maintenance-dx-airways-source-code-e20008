using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DXAirways.Business;
using DXAirways.Business.Orm;

namespace DXAirways.Windows
{
    public class FlightNumberValidationRule : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            bool ret = false;
            string flightNumber = value as string;

            if (flightNumber != null && flightNumber.Length == 3)
            {
                bool numeric = true;
                foreach (char c in flightNumber)
                    if (!char.IsNumber(c))
                    {
                        numeric = false;
                        break;
                    }
                if (numeric)
                    ret = true;
            }

            return ret;
        }

        public override bool CanValidate(Control control)
        {
            if (control is TextEdit)
                return true;
            else
                return false;
        }
    }
}