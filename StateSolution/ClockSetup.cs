using System;

namespace StateSolution
{
    public class ClockSetup
    {
        private IClockSetupState yearState;
        private IClockSetupState monthState;
        private IClockSetupState dayState;
        private IClockSetupState hourState;
        private IClockSetupState minuteState;
        private IClockSetupState finishedState;
        private IClockSetupState currentState;

        #region Properties
        public IClockSetupState YearState
        {
            get { return yearState; }
            set { yearState = value; }
        }
        public IClockSetupState MonthState
        {
            get { return monthState; }
            set { monthState = value; }
        }
        public IClockSetupState DayState
        {
            get { return dayState; }
            set { dayState = value; }
        }
        public IClockSetupState HourState
        {
            get { return hourState; }
        }
        public IClockSetupState MinuteState
        {
            get { return minuteState; }
        }
        public IClockSetupState FinishedState
        {
            get { return finishedState; }
        }
        public IClockSetupState State
        {
            set
            {
                currentState = value;
                Console.WriteLine(currentState.Instructions);
            }
        }
        #endregion

        public ClockSetup()
        {
            yearState = new YearState(this, DateTime.Now.Year);
            monthState = new MonthState(this, DateTime.Now.Month);
            dayState = new DayState(this, DateTime.Now.Day);
            hourState = new HourState(this, DateTime.Now.Hour);
            minuteState = new MinuteState(this, DateTime.Now.Minute);
            finishedState = new FinishedState(this);
        }

        public void RotateRight()
        {
            currentState.NextValue();
            
        }

        public void RotateLeft()
        {
           currentState.PreviousValue();
            
        }

        public void PushKnob()
        {
            if (currentState == null)
                currentState = yearState;
            else
                currentState.SelectValue();
            
        }

        public virtual IClockSetupState YearSetupState
        {
            get { return yearState; }
        }

        public DateTime GetSelectedDate()
        {
            return new DateTime(yearState.SelectedValue, monthState.SelectedValue, dayState.SelectedValue);
        }
    }


}
