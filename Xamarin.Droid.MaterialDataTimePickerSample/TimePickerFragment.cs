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
using Java.Util;

namespace Nivaes.MaterialDataTimePicker.Droid
{
    public class TimePickerFragment : Fragment, TimePickerDialog.IOnTimeSetListener
    {
        private TextView timeTextView;
        private CheckBox mode24Hours;
        private CheckBox modeDarkTime;
        private CheckBox modeCustomAccentTime;
        private CheckBox vibrateTime;
        private CheckBox dismissTime;
        private CheckBox titleTime;
        private CheckBox enableSeconds;
        private CheckBox limitSelectableTimes;
        private CheckBox disableSpecificTimes;
        private CheckBox showVersion2;
        private TimePickerDialog tpd;

        public TimePickerFragment()
        {
            // Required empty public constructor
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.timepicker_layout, container, false);

            // Find our View instances
            timeTextView = view.FindViewById<TextView>(Resource.Id.time_textview);
            Button timeButton = view.FindViewById<CheckBox>(Resource.Id.time_button);
            mode24Hours = view.FindViewById<CheckBox>(Resource.Id.mode_24_hours);
            modeDarkTime = view.FindViewById<CheckBox>(Resource.Id.mode_dark_time);
            modeCustomAccentTime = view.FindViewById<CheckBox>(Resource.Id.mode_custom_accent_time);
            vibrateTime = view.FindViewById<CheckBox>(Resource.Id.vibrate_time);
            dismissTime = view.FindViewById<CheckBox>(Resource.Id.dismiss_time);
            titleTime = view.FindViewById<CheckBox>(Resource.Id.title_time);
            enableSeconds = view.FindViewById<CheckBox>(Resource.Id.enable_seconds);
            limitSelectableTimes = view.FindViewById<CheckBox>(Resource.Id.limit_times);
            disableSpecificTimes = view.FindViewById<CheckBox>(Resource.Id.disable_times);
            showVersion2 = view.FindViewById<CheckBox>(Resource.Id.show_version_2);

            view.FindViewById(Resource.Id.original_button).Click += (o, e) =>
            {
                Calendar now = Calendar.Instance;
                //new Android.App.TimePickerDialog(
                //    base.Activity,
                //    ,
                //                now.Get(Calendar.HourOfDay),
                //                now.Get(Calendar.Minute),
                //                mode24Hours.Checked
                //        ).Show();
            };

            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            //TimePickerDialog tpd = (TimePickerDialog)base.FragmentManager.FindFragmentByTag("Timepickerdialog");
            //if (tpd != null) tpd.ti SetOnTimeSetListener(this);
        }

        void TimePickerDialog.IOnTimeSetListener.OnTimeSet(TimePicker view, int hourOfDay, int minute)
        {
            //    String hourString = hourOfDay < 10 ? "0" + hourOfDay : "" + hourOfDay;
            //    String minuteString = minute < 10 ? "0" + minute : "" + minute;
            //    String secondString = second < 10 ? "0" + second : "" + second;
            //    String time = "You picked the following time: " + hourString + "h" + minuteString + "m" + secondString + "s";
            //    timeTextView.setText(time);
        }
    }
}