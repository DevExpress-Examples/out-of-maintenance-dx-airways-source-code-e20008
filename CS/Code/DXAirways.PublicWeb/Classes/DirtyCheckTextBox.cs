using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DXAirways.Web.Classes
{
    [DisplayName("DirtyCheckTextBox")]
    [Description("TextBox control with optional dirty check.")]
    [ToolboxData("<{0}:DirtyCheckTextBox runat=\"server\"></{0}:DirtyCheckTextBox>")]
    [ToolboxBitmap(typeof(TextBox))]
    public class DirtyCheckTextBox : TextBox
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (!Page.ClientScript.IsClientScriptBlockRegistered("GlobalDirtyVar"))
            {
                string globalScript = "var _formDirty = false;";
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "GlobalDirtyVar", globalScript, true);
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (PerformDirtyCheck)
                this.Attributes.Add("onchange", "_formDirty = true;");
        }

        [Category("Custom")]
        [Description("If set to True, then the textbox will perform a check on the form-level dirty variable.")]
        [Bindable(true)]
        [DefaultValue(true)]
        public bool PerformDirtyCheck
        {
            get
            {
                if (ViewState["PerformDirtyCheck"] == null)
                    return true;
                return (bool)ViewState["PerformDirtyCheck"];
            }
            set
            {
                ViewState["PerformDirtyCheck"] = value;
            }
        }
    }
}
