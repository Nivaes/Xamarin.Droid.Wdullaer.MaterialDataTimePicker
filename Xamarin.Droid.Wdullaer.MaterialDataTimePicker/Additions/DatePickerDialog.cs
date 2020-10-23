namespace Com.Wdullaer.MaterialDateTimePicker.Date
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class DatePickerDialog
        : IDatePickerController
    {
        ScrollOrientation IDatePickerController.ScrollOrientation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        DatePickerDialog.Version IDatePickerController.Version
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
