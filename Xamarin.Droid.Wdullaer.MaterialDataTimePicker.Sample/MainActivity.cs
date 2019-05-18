namespace Nivaes.MaterialDataTimePicker.Droid
{
    using Android.App;
    using Android.OS;
    using Android.Support.Design.Widget;
    using Android.Support.V4.App;
    using Android.Support.V4.View;
    using Android.Support.V7.App;
    using Android.Support.V7.Widget;

    [Activity(Label = "@string/app_name", 
        MainLauncher = true, 
        Theme = "@style/AppTheme",
        Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        ViewPager viewPager;
        PickerAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            base.SetContentView(Resource.Layout.activity_main);

            adapter = new PickerAdapter(base.FragmentManager);
            viewPager = base.FindViewById< ViewPager>(Resource.Id.pager);
            viewPager.Adapter = adapter;

            SetSupportActionBar(base.FindViewById<Toolbar>(Resource.Id.toolbar));
            TabLayout tabLayout = base.FindViewById< TabLayout>(Resource.Id.tabs);
            tabLayout.SetupWithViewPager(viewPager);
            for (int i = 0; i < adapter.Count; i++) //noinspection ConstantConditions
                tabLayout.GetTabAt(i).SetText(adapter.GetTitle(i));
        }

        private class PickerAdapter : Android.Support.V13.App.FragmentPagerAdapter
        {
            Android.App.Fragment timePickerFragment;
            Android.App.Fragment datePickerFragment;

            public PickerAdapter(Android.App.FragmentManager fm)
                :base(fm)
            {
                timePickerFragment = new TimePickerFragment();
                datePickerFragment = new DatePickerFragment();
            }

            public override int Count => 2;

            public override Android.App.Fragment GetItem(int position)
            {
                switch (position)
                {
                    case 0:
                        return timePickerFragment;
                    case 1:
                    default:
                        return datePickerFragment;
                }
            }

            public int GetTitle(int position)
            {
                switch (position)
                {
                    case 0:
                        return Resource.String.tab_title_time;
                    case 1:
                    default:
                        return Resource.String.tab_title_date;
                }
            }
        }
    }
}


