using System;

namespace StateSolution
{
    public class DayState:IClockSetupState
    {
        private readonly ClockSetup clockSetup;
        private int _day;

        public DayState(ClockSetup clockSetup, int day)
        {
            this.clockSetup = clockSetup;
            this._day = day;
        }

        public virtual void PreviousValue()
        {
            if (_day > 1)
                _day--;
        }

        public virtual void NextValue()
        {
            if (_day < 31)
                _day++;
        }
        public string Instructions
        {
            get { return "Please set the day..."; }
        }

        public int SelectedValue
        {
            get { return _day; }
        }

        public void SelectValue()
        {
           Console.WriteLine("Day set to " + _day);
            clockSetup.State = clockSetup.FinishedState;
        }
    }
}
