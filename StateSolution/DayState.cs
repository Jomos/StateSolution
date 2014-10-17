using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class DayState:IClockSetupState
    {
        private ClockSetup clockSetup;
        private int day;

        public DayState(ClockSetup clockSetup, int day)
        {
            this.clockSetup = clockSetup;
            this.day = day;
        }

        public virtual void PreviousValue()
        {
            if (day > 1)
                day--;
        }

        public virtual void NextValue()
        {
            if (day < 31)
                day++;
        }
        public string Instructions
        {
            get { return "Please set the day..."; }
        }

        public int SelectedValue
        {
            get { return day; }
        }


        public void SelectValue()
        {
           Console.WriteLine("Day set to " + day);
            clockSetup.State = clockSetup.FinishedState;
        }
    }
}
