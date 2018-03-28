﻿using Foundation;
using MvvmCross.iOS.Views;
using System;
using TakenApp.Shared.ViewModels;
using UIKit;

namespace TakenApp.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class UserOverView : MvxTableViewController<UserOverViewModel>
    {
        public UserOverView (IntPtr handle) : base (handle)
        {
        }
    }
}