using System;

namespace StateSolution
{
    public class MonthState:IClockSetupState
    {
        private readonly ClockSetup clockSetup;
        private int _month;

        public MonthState(ClockSetup clockSetup,int month)
        {
            this.clockSetup = clockSetup;
            this._month = month;
        }

        public virtual void PreviousValue()
        {
            _month--;
            if (_month == 0) _month = 12;
        }

        public virtual void NextValue()
        {
            _month++;
            if (_month == 13) _month = 1;
        }
        public string Instructions
        {
            get { return "Please set the month..."; }
        }

        public int SelectedValue
        {
            get { return _month; }
        }

        public void SelectValue()
        {
           Console.WriteLine("Month set to "+_month);
            clockSetup.State = clockSetup.DayState;
        }
    }
}
