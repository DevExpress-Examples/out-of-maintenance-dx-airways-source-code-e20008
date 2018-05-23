using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

//The view is defined by the NavBarViewInfo class. That's the NoExpandButtonViewNavBarViewInfo class in our sample, which is a direct descendant of the XPExplorerBarNavBarViewInfo class.

//To hide the expand/collapse buttons we've implemented the OpenCloseButton painter class (NoExpandButtonOpenCloseButtonObjectPainter). It does not draw anything, so there is no button.

//A user can expand/collapse a group by clicking its header. The DoGroupClick method is overridden so as to ignore mouse clicks and prevent a group from being collapsed.

//The NoExpandButtonViewInfoRegistrator class registers the custom NavBar view.


namespace DXAirways.Windows
{
    public class NoExpandNavBarViewInfo : AdvExplorerBarNavBarViewInfo
    {
        // this class inherits from the view that we want to extend

        public NoExpandNavBarViewInfo(NavBarControl navBar) : base(navBar)
        {
        }

        protected override void DoGroupClick(NavBarHitInfo hitInfo)
        {
        }
    }
}