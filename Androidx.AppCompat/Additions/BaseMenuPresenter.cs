﻿namespace AndroidX.AppCompat.View.Menu
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class BaseMenuPresenter
    {
        void IMenuPresenter.SetCallback(IMenuPresenterCallback callback)
        {
            Callback = callback;
        }
    }
}