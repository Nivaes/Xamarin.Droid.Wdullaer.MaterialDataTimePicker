namespace Com.Wdullaer.MaterialDateTimePicker.Date
{
    using Android.Support.V7.App;
    using Android.Support.V7.Widget;
    using Java.Util;
    using static Android.Views.View;

    public partial class DatePickerDialog
    {
        public DatePickerDialog(DatePickerDialog.IOnDateSetListener callBack, int year, int monthOfYear, int dayOfMonth)
        {
            Initialize(callBack, year, monthOfYear, dayOfMonth);
        }

        //DatePickerDialog.ScrollOrientation IDatePickerController.ScrollOrientation => GetScrollOrientation();

        //DatePickerDialog.Version IDatePickerController.Version => GetVersion();
    }
}
