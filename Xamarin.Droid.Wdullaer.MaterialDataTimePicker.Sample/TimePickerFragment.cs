namespace Nivaes.MaterialDataTimePicker.Droid
{
    using System;
    using Android.Graphics;
    using Android.OS;
    using Android.Util;
    using Android.Views;
    using Android.Widget;
    using Com.Wdullaer.MaterialDateTimePicker.Time;
    using Java.Util;

    public class TimePickerFragment : Android.App.Fragment, TimePickerDialog.IOnTimeSetListener
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
            Button timeButton = view.FindViewById<Button>(Resource.Id.time_button);
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
                new Android.App.TimePickerDialog(
                    base.Activity,
                        (object sender, Android.App.TimePickerDialog.TimeSetEventArgs arg) =>
                        {
                            Log.Debug("Orignal", "Got clicked");
                        },
                        now.Get(CalendarField.HourOfDay),
                        now.Get(CalendarField.Minute),
                        mode24Hours.Checked
                        ).Show();
            };

            timeButton.Click += (o, e) =>
            {
                Calendar now = Calendar.Instance;
                tpd = new TimePickerDialog(this, now.Get(CalendarField.HourOfDay), now.Get(CalendarField.Minute), now.Get(CalendarField.Second), mode24Hours.Checked);

                tpd.SetThemeDark(modeDarkTime.Checked);
                tpd.Vibrate(vibrateTime.Checked);
                tpd.DismissOnPause(dismissTime.Checked);
                tpd.EnableSeconds(enableSeconds.Checked);
                tpd.SetVersion(showVersion2.Checked ? TimePickerDialog.Version.Version2 : TimePickerDialog.Version.Version1);
                if (modeCustomAccentTime.Checked)
                {
                    tpd.AccentColor = Color.ParseColor("#9C27B0");
                }
                if (titleTime.Checked)
                {
                    tpd.Title = "TimePicker Title";
                }
                if (limitSelectableTimes.Checked)
                {
                    if (enableSeconds.Checked)
                    {
                        tpd.SetTimeInterval(3, 5, 10);
                    }
                    else
                    {
                        tpd.SetTimeInterval(3, 5, 60);
                    }
                }
                if (disableSpecificTimes.Checked)
                {
                    Timepoint[] disabledTimes = {
                            new Timepoint(10),
                            new Timepoint(10, 30),
                            new Timepoint(11),
                            new Timepoint(12, 30)
                    };
                    tpd.SetDisabledTimes(disabledTimes);
                }
                tpd.TimeSet += (oo, ee) =>
                {

                };

                //tpd.SetOnCancelListener()

                //tpd.setOnCancelListener(new DialogInterface.OnCancelListener() {
                //    @Override
                //    public void onCancel(DialogInterface dialogInterface)
                //{
                //    Log.d("TimePicker", "Dialog was cancelled");
                //}
                //});
                tpd.Show(base.FragmentManager, "Timepickerdialog");
            };

            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            TimePickerDialog tpd = (TimePickerDialog)base.FragmentManager.FindFragmentByTag("Timepickerdialog");
            if (tpd != null) tpd.OnTimeSetListener = this;
        }

        void TimePickerDialog.IOnTimeSetListener.OnTimeSet(Com.Wdullaer.MaterialDateTimePicker.Time.TimePickerDialog view, int hourOfDay, int minute, int second)
        {
            string hourString = hourOfDay < 10 ? "0" + hourOfDay : "" + hourOfDay;
            string minuteString = minute < 10 ? "0" + minute : "" + minute;
            string secondString = second < 10 ? "0" + second : "" + second;
            string time = "You picked the following time: " + hourString + "h" + minuteString + "m" + secondString + "s";
            timeTextView.Text = time;
        }
    }
}
