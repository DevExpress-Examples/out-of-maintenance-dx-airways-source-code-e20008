using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo;

namespace DXAirways.Windows.Controls
{
    public partial class StdButtons : DevExpress.XtraEditors.XtraUserControl
    {
        public StdButtons()
        {
            InitializeComponent();
        }

        public enum ButtonType
        {
            OK,
            Apply,
            Cancel
        };

        public enum Orientation
        {
            Horizontal,
            Vertical
        };

        [Category("Action")]
        public event EventHandler<StdButtonClickingEventArgs> StdButtonClicking;

        [Category("Action")]
        public event EventHandler<StdButtonClickedEventArgs> StdButtonClicked;

        public virtual void OnStdButtonClicking(StdButtonClickingEventArgs e)
        {
            if (this.StdButtonClicking != null)
                this.StdButtonClicking(this, e);
        }
               
        protected virtual void OnStdButtonClicked(StdButtonClickedEventArgs e)
        {
            if (this.StdButtonClicked != null)
                this.StdButtonClicked(this, e);
        }

        private UnitOfWork _UnitOfWork;
        private Orientation _ButtonOrientation;

        public UnitOfWork UnitOfWork
        {
            get { return _UnitOfWork; }
            set { _UnitOfWork = value; }
        }
        
        public Orientation ButtonOrientation
        {
            get { return _ButtonOrientation; }
            set
            {
                _ButtonOrientation = value;
                SetButtonLayout(_ButtonOrientation);
            }
        }

        private void SetButtonLayout(Orientation orientation)
        {
            if (orientation == Orientation.Horizontal)
            {
                btnOK.Location = new Point(0, 0);
                btnApply.Location = new Point(btnOK.Width + 6, 0);
                btnCancel.Location = new Point(btnApply.Left + btnApply.Width + 6, 0);
                this.Size = new Size(btnOK.Width + btnApply.Width + btnCancel.Width + 12, btnOK.Height);
            }
            else
            {
                btnOK.Location = new Point(0, 0);
                btnApply.Location = new Point(0, btnOK.Height + 6);
                btnCancel.Location = new Point(0, btnApply.Top + btnApply.Height + 6);
                this.Size = new Size(btnOK.Width, btnOK.Height + btnApply.Height + btnCancel.Height + 12);
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            StdButtonClickingEventArgs args = new StdButtonClickingEventArgs(ButtonType.OK);
            OnStdButtonClicking(args);

            if (!args.Cancel)
            {
                try
                {
                    if (_UnitOfWork != null)
                        _UnitOfWork.CommitChanges();
                }
                catch (DevExpress.Xpo.DB.Exceptions.ConstraintViolationException)
                {
                    MessageBox.Show("This record cannot be deleted because it is in use further down in the object model.");
                }

                OnStdButtonClicked(new StdButtonClickedEventArgs(ButtonType.OK));

                Form parent = (Form)Parent;
                parent.Close();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            StdButtonClickingEventArgs args = new StdButtonClickingEventArgs(ButtonType.Apply);
            OnStdButtonClicking(args);

            if (!args.Cancel)
            {
                if (_UnitOfWork != null)
                    _UnitOfWork.CommitChanges();

                OnStdButtonClicked(new StdButtonClickedEventArgs(ButtonType.Apply));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StdButtonClickingEventArgs args = new StdButtonClickingEventArgs(ButtonType.Cancel);
            OnStdButtonClicking(args);

            if (!args.Cancel)
            {
                OnStdButtonClicked(new StdButtonClickedEventArgs(ButtonType.Cancel));

                Form parent = (Form)Parent;
                parent.Close();
            }
        }
    }
}
