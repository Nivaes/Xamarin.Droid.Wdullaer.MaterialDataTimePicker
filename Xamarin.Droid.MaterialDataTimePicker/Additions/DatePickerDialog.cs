namespace Com.Wdullaer.MaterialDateTimePicker.Date
{
    public partial class DatePickerDialog
    {
        DatePickerDialog.ScrollOrientation IDatePickerController.ScrollOrientation
        {
            get => GetScrollOrientation();
        }

        DatePickerDialog.Version IDatePickerController.Version
        {
            get => GetVersion();
        }
    }
}