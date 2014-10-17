using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSolution
{
    public class FinishedState:IClockSetupState
    {
        private ClockSetup clockSetup;

        public FinishedState(ClockSetup clockSetup)
        {
            this.clockSetup = clockSetup;
        }

        public virtual void PreviousValue()
        {
            Console.WriteLine("Previous value for finished state is not supported.");
        }

        public virtual void NextValue()
        {
            Console.WriteLine("Next value for finished state is not supported.");
        }
        public string Instructions
        {
            get { return "Clock setup finished"; }
        }

        public int SelectedValue
        {
            get { return 0; }
        }


        public void SelectValue()
        {
           Console.WriteLine("Select Values");
            clockSetup.State = clockSetup.MonthState;
        }
    }
}
