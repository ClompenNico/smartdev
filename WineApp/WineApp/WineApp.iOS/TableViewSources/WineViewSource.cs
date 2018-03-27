using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;

namespace WineApp.iOS.TableViewSources
{
    public class WineViewSource : MvxTableViewSource
    {
        public WineViewSource(UITableView tableView) : base(tableView)
        {

        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            try
            {
                var cell = (WineTableCell)tableView.DequeueReusableCell(WineTableCell.Identifier, indexPath);
                return cell;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}