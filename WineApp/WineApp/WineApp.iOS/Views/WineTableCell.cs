﻿using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using System;
using UIKit;
using WineApp.Core.Models;

namespace WineApp.iOS
{
    public partial class WineTableCell : MvxTableViewCell
    {
        internal static readonly NSString Identifier = new NSString("WineCell");

        public WineTableCell (IntPtr handle) : base (handle)
        {
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            MvxFluentBindingDescriptionSet<WineTableCell, Wine> set = new MvxFluentBindingDescriptionSet<WineTableCell, Wine>(this);
            set.Bind(lblTitle).To(res => res.Name);
            set.Bind(lblSubtitle).To(res => res.Appelation);
            set.Apply();
        }
    }
}