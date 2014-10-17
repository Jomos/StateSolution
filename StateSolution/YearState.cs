using System;

namespace StateSolution
{
    public class YearState:IClockSetupState
    {
        private readonly ClockSetup clockSetup;
        private int _year;

        public YearState(ClockSetup clockSetup, int year)
        {
            this.clockSetup = clockSetup;
            this._year = year;
        }

        public virtual void PreviousValue()
        {
            _year--;
        }

        public virtual void NextValue()
        {
            _year++;
        }
        public string Instructions
        {
            get { return "Please set the year..."; }
        }

        public int SelectedValue
        {
            get { return _year; }
        }

        public void SelectValue()
        {
           Console.WriteLine("Year set to "+_year);
            clockSetup.State = clockSetup.MonthState;
        }
    }
}
