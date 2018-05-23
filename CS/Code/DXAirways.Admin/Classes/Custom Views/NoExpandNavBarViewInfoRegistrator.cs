using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraNavBar;
using DevExpress.XtraNavBar.ViewInfo;

namespace DXAirways.Windows
{
    public class NoExpandNavBarViewInfoRegistrator : AdvExplorerBarViewInfoRegistrator
    {
        public override string ViewName
        {
            get
            {
                return "NoExpandNavBarView";
            }
        }

        public override BaseNavGroupPainter CreateGroupPainter(NavBarControl navBar)
        {
            return new NoExpandNavBarGroupPainter(navBar);
        }

        public override NavBarViewInfo CreateViewInfo(NavBarControl navBar)
        {
            return new NoExpandNavBarViewInfo(navBar);
        }
    }
}
