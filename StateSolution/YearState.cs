using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class YearState:IClockSetupState
    {
        private ClockSetup clockSetup;
        private int year;

        public YearState(ClockSetup clockSetup, int year)
        {
            this.clockSetup = clockSetup;
            this.year = year;
        }

        public virtual void PreviousValue()
        {
            year--;
        }

        public virtual void NextValue()
        {
            year++;
        }
        public string Instructions
        {
            get { return "Please set the year..."; }
        }

        public int SelectedValue
        {
            get { return year; }
        }


        public void SelectValue()
        {
           Console.WriteLine("Year set to "+year);
            clockSetup.State = clockSetup.MonthState;
        }
    }
}
