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
    public class NoExpandNavBarGroupPainter : AdvExplorerBarNavGroupPainter
    {
        public NoExpandNavBarGroupPainter(NavBarControl navBar)
            : base(navBar)
        {
        }

        protected override ObjectPainter CreateOpenCloseButtonPainter()
        {
            return new NoExpandNavBarObjectPainter();
        }
    }
}
