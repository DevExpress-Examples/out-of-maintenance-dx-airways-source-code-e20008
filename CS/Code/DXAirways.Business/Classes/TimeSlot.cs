using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXAirways.Business
{
    public class TimeSlots : List<TimeSlot>
    {
        public static TimeSlots GetFlightSearchTimeSlots()
        {
            TimeSlots slots = new TimeSlots();

            slots.Add(new TimeSlot("Anytime", 0, 0));
            slots.Add(new TimeSlot("Early Morning", 4, 6));
            slots.Add(new TimeSlot("Morning", 6, 9));
            slots.Add(new TimeSlot("Late Morning", 9, 12));
            slots.Add(new TimeSlot("Afternoon", 12, 18));
            slots.Add(new TimeSlot("Evening", 18, 20));
            slots.Add(new TimeSlot("Night", 20, 0));

            return slots;
        }

        public TimeSlot FindByLabel(string label)
        {
            TimeSlot found = null;

            foreach (TimeSlot item in this)
            {
                if (item.Label.ToLower() == label.ToLower())
                {
                    found = item;
                    break;
                }
            }

            return found;
        }
    }

    public class TimeSlot
    {
        public TimeSlot(string label, int beginRange, int endRange)
        {
            _Label = label;
            _BeginRange = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, beginRange, 0, 0);
            _EndRange = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, endRange, 0, 0).AddMinutes(-1);
        }

        protected DateTime _BeginRange;
        protected DateTime _EndRange;
        protected string _Label;

        public DateTime BeginRange
        {
            get { return _BeginRange; }
            set { _BeginRange = value; }
        }

        public DateTime EndRange
        {
            get { return _EndRange; }
            set { _EndRange = value; }
        }

        public string Label
        {
            get { return _Label; }
            set { _Label = value; }
        }
    }
}
