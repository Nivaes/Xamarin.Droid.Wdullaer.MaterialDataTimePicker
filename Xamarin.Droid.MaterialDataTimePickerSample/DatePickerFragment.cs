using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Wdullaer.MaterialDateTimePicker.Date;
using Java.Util;

namespace Nivaes.MaterialDataTimePicker.Droid
{
    public class DatePickerFragment : Android.App.Fragment, Com.Wdullaer.MaterialDateTimePicker.Date.DatePickerDialog.IOnDateSetListener
    {
        private TextView dateTextView;
        private CheckBox modeDarkDate;
        private CheckBox modeCustomAccentDate;
        private CheckBox vibrateDate;
        private CheckBox dismissDate;
        private CheckBox titleDate;
        private CheckBox showYearFirst;
        private CheckBox showVersion2;
        private CheckBox switchOrientation;
        private CheckBox limitSelectableDays;
        private CheckBox highlightDays;
        private Com.Wdullaer.MaterialDateTimePicker.Date.DatePickerDialog dpd;

        public DatePickerFragment()
        {
            // Required empty public constructor
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.datepicker_layout, container, false);

            // Find our View instances
            dateTextView = view.FindViewById<TextView>(Resource.Id.date_textview);
            Button dateButton = view.FindViewById<Button>(Resource.Id.date_button);
            modeDarkDate = view.FindViewById<CheckBox>(Resource.Id.mode_dark_date);
            modeCustomAccentDate = view.FindViewById<CheckBox>(Resource.Id.mode_custom_accent_date);
            vibrateDate = view.FindViewById<CheckBox>(Resource.Id.vibrate_date);
            dismissDate = view.FindViewById<CheckBox>(Resource.Id.dismiss_date);
            titleDate = view.FindViewById<CheckBox>(Resource.Id.title_date);
            showYearFirst = view.FindViewById<CheckBox>(Resource.Id.show_year_first);
            showVersion2 = view.FindViewById<CheckBox>(Resource.Id.show_version_2);
            switchOrientation = view.FindViewById<CheckBox>(Resource.Id.switch_orientation);
            limitSelectableDays = view.FindViewById<CheckBox>(Resource.Id.limit_dates);
            highlightDays = view.FindViewById<CheckBox>(Resource.Id.highlight_dates);

            view.FindViewById(Resource.Id.original_button).Click += (o, e) =>
            {
                Calendar now = Calendar.Instance;
                new Android.App.DatePickerDialog(
                        base.Activity,
                        (object sender, Android.App.DatePickerDialog.DateSetEventArgs arg) =>
                        {
                            Log.Debug("Orignal", "Got clicked");
                        },
                        now.Get(Calendar.Year),
                        now.Get(Calendar.Month),
                        now.Get(Calendar.DayOfMonth)
                ).Show();
            };

            // Show a datepicker when the dateButton is clicked
            dateButton.Click += (o, e) =>
            {
                Calendar now = Calendar.Instance;
             
                dpd = new Com.Wdullaer.MaterialDateTimePicker.Date.DatePickerDialog(base.Context,
                            this,
                            now.Get(Calendar.Year),
                            now.Get(Calendar.Month),
                            now.Get(Calendar.DayOfMonth)
                    );
            };

            return view;
        }

        public override void OnResume()
        {
            base.OnResume();
            //DatePickerDialog dpd = (DatePickerDialog)base.FragmentManager.FindFragmentByTag("Datepickerdialog");
            //if (dpd != null) dpd.SetOnDateSetListener(this);
        }

        void OnDateSet(DatePicker view, int year, int month, int dayOfMonth)
        {

        }

        void Com.Wdullaer.MaterialDateTimePicker.Date.DatePickerDialog.IOnDateSetListener.OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            string date = "You picked the following date: " + dayOfMonth + "/" + (++monthOfYear) + "/" + year;
            dateTextView.Text = date;
        }

        void DatePickerDialog.IOnDateSetListener.OnDateSet(DatePickerDialog p0, int p1, int p2, int p3)
        {
            throw new NotImplementedException();
        }
    }
}