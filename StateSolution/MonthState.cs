using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class MonthState:IClockSetupState
    {
        private ClockSetup clockSetup;
        private int month;

        public MonthState(ClockSetup clockSetup,int month)
        {
            this.clockSetup = clockSetup;
            this.month = month;
        }

        public virtual void PreviousValue()
        {
            month--;
            if (month == 0) month = 12;
        }

        public virtual void NextValue()
        {
            month++;
            if (month == 13) month = 1;
        }
        public string Instructions
        {
            get { return "Please set the month..."; }
        }

        public int SelectedValue
        {
            get { return month; }
        }


        public void SelectValue()
        {
           Console.WriteLine("Month set to "+month);
            clockSetup.State = clockSetup.DayState;
        }
    }
}
