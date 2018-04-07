using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace Nivaes.MaterialDataTimePicker.Droid
{
    [Activity(Label = "@string/app_name", 
        MainLauncher = true, 
        Theme = "@style/AppTheme",
        Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        ViewPager viewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //base.SetContentView(R.layout.activity_main);

            //adapter = new PickerAdapter(getFragmentManager());
            //viewPager = findViewById(R.id.pager);
            //viewPager.setAdapter(adapter);

            //setSupportActionBar((Toolbar)findViewById(R.id.toolbar));
            //TabLayout tabLayout = findViewById(R.id.tabs);
            //tabLayout.setupWithViewPager(viewPager);
            //for (int i = 0; i < adapter.getCount(); i++) //noinspection ConstantConditions
            //    tabLayout.getTabAt(i).setText(adapter.getTitle(i));
        }

        //private class PickerAdapter extends FragmentPagerAdapter
        //{
        //private static final int NUM_PAGES = 2;
        //Fragment timePickerFragment;
        //Fragment datePickerFragment;

        //PickerAdapter(FragmentManager fm)
        //{
        //    super(fm);
        //    timePickerFragment = new TimePickerFragment();
        //    datePickerFragment = new DatePickerFragment();
        //}

        //@Override
        //public int getCount()
        //{
        //    return NUM_PAGES;
        //}

        //@Override
        //public Fragment getItem(int position)
        //{
        //    switch (position)
        //    {
        //        case 0:
        //            return timePickerFragment;
        //        case 1:
        //        default:
        //            return datePickerFragment;
        //    }
        //}

        //int getTitle(int position)
        //{
        //    switch (position)
        //    {
        //        case 0:
        //            return R.string.tab_title_time;
        //        case 1:
        //        default:
        //            return R.string.tab_title_date;
        //    }
        //}
    }
}


