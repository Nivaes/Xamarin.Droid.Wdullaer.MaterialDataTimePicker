namespace Com.Wdullaer.MaterialDateTimePicker.Date
{
    public partial class DatePickerDialog
    {
        public DatePickerDialog(global::Com.Wdullaer.MaterialDateTimePicker.Date.DatePickerDialog.IOnDateSetListener callBack, int year, int monthOfYear, int dayOfMonth)
        {
            Initialize(callBack, year, monthOfYear, dayOfMonth);
        }

        DatePickerDialog.ScrollOrientation IDatePickerController.ScrollOrientation => GetScrollOrientation();

        DatePickerDialog.Version IDatePickerController.Version => GetVersion();
    }
}
