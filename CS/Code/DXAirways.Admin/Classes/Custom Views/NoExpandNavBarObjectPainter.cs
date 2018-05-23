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
    public class NoExpandNavBarObjectPainter : AdvExplorerBarOpenCloseButtonObjectPainter
    {
        protected override void DrawNormal(ObjectInfoArgs e, AppearanceObject appearance)
        {
        }

        protected override void DrawHot(ObjectInfoArgs e, AppearanceObject appearance)
        {
        }

        public override System.Drawing.Rectangle GetObjectClientRectangle(ObjectInfoArgs e)
        {
            return Rectangle.Empty;
        }
    }
}
