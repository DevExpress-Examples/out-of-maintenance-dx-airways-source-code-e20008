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
    public class FlightTimeValidationRule : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            bool ret = false;
            string flightTime = value as string;

            // if flightTime format is ##:##, then convert to decimal
            if (!string.IsNullOrEmpty(flightTime))
            {
                if (flightTime.IndexOf(":") > -1)
                {
                    string stripped = flightTime.Replace(":", "");
                    if (stripped.IndexOf(":") == -1)
                    {
                        bool numeric = true;
                        foreach (char c in stripped)
                            if (!char.IsNumber(c))
                            {
                                numeric = false;
                                break;
                            }
                        if (numeric)
                        {
                            string[] arrParts = flightTime.Split(':');
                            int hours = Convert.ToInt32(arrParts[0]);
                            int minutes = Convert.ToInt32(arrParts[1]);
                            if (minutes <= 59)
                            {
                                ret = true;
                            }
                        }
                    }
                }
                else
                {
                    double time;
                    bool parse = double.TryParse(flightTime, out time);
                    if (parse)
                    {
                        int hours = (int)(Math.Truncate(time));
                        double fractional = time - hours;
                        int minutes = (int)(60 * fractional);

                        TextEdit txtFlightTime = control as TextEdit;
                        txtFlightTime.Text = hours.ToString() + ":" + minutes.ToString();

                        ret = true;
                    }
                }
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
