using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

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