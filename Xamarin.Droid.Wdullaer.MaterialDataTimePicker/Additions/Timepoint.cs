namespace Com.Wdullaer.MaterialDateTimePicker.Time
{
    using Java.Lang;

    public partial class Timepoint
    {
        int IComparable.CompareTo(Object o)
        {
            return CompareTo((Timepoint)o);
        }
    }
}
