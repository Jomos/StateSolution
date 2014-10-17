using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class MinuteState:IClockSetupState
    {
        private ClockSetup clockSetup;
        private int minute;

        public MinuteState(ClockSetup clockSetup,int minute)
        {
            this.clockSetup = clockSetup;
            this.minute = minute;
        }

        public virtual void PreviousValue()
        {
            minute--;
            if (minute == -1) minute = 59;
        }

        public virtual void NextValue()
        {
            minute++;
            if (minute == 60) minute = 0;
        }
        public string Instructions
        {
            get { return "Please set the minute..."; }
        }

        public int SelectedValue
        {
            get { return minute; }
        }


        public void SelectValue()
        {
            Console.WriteLine("minute set to " + minute);
            clockSetup.State = clockSetup.FinishedState;
        }
    }
}
