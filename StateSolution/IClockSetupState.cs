namespace StateSolution
{
    public interface IClockSetupState
    {
        void PreviousValue();
        void NextValue();
        void SelectValue();
        string Instructions { get; }
        int SelectedValue { get; }
    }
}
