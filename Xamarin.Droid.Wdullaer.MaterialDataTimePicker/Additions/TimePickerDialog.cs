namespace Com.Wdullaer.MaterialDateTimePicker.Time
{
    public partial class TimePickerDialog
    {
        public TimePickerDialog(IOnTimeSetListener callback, int hourOfDay, int minute, int second, bool is24HourMode)
        {
            Initialize(callback, hourOfDay, minute, second, is24HourMode);
        }
    }
}
