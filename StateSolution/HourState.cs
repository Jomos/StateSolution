using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class HourState:IClockSetupState
    {
        private ClockSetup clockSetup;
        private int hour;

        public HourState(ClockSetup clockSetup,int hour)
        {
            this.clockSetup = clockSetup;
            this.hour = hour;
        }

        public virtual void PreviousValue()
        {
            hour--;
            if (hour == 0) hour = 24;
        }

        public virtual void NextValue()
        {
            hour++;
            if (hour == 25) hour = 1;
        }
        public string Instructions
        {
            get { return "Please set the hour..."; }
        }

        public int SelectedValue
        {
            get { return hour; }
        }


        public void SelectValue()
        {
            Console.WriteLine("hour set to " + hour);
            clockSetup.State = clockSetup.MinuteState;
        }
    }
}
