using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyTasks
{
    [ToolboxItem(true)]
    public partial class PlannerDay : UserControl
    {
        // Fields
        protected DateTime _date;
        protected int _low;
        protected int _normal;
        protected int _high;
        protected bool _highlight = false;
        //protected bool _enabled = true;

        // Properties

        /// <summary>
        /// Gets or sets the date to be shown in control.
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set
            { 
                _date = value;
                if(value != null)
                {
                    lblDay.Text = value.Day.ToString();
                }
                else
                {
                    lblDay.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of low priority tasks in the day. Value is shown only if greater than zero.
        /// </summary>
        public int Low
        {
            get { return _low; }
            set
            {
                _low = value;
                if (value > 0)
                {
                    lblLow.Text = value.ToString();
                }
                else
                {
                    lblLow.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of normal priority tasks in the day. Value is shown only if greater than zero.
        /// </summary>
        public int Normal
        {
            get { return _normal; }
            set
            {
                _normal = value;
                if (value > 0)
                {
                    lblNormal.Text = value.ToString();
                }
                else
                {
                    lblNormal.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// Gets or sets the number of high priority tasks in the day. Value is shown only if greater than zero.
        /// </summary>
        public int High
        {
            get { return _high; }
            set
            {
                _high = value;
                if (value > 0)
                {
                    lblHigh.Text = value.ToString();
                }
                else
                {
                    lblHigh.Text = String.Empty;
                }
            }
        }

        /// <summary>
        /// When set to <c>true</c> bacck color property is changed to highlight object.
        /// </summary>
        public bool Highlight
        {
            get { return _highlight; }
            set
            {
                _highlight = value;
                if (value)
                {
                    lblDay.BackColor = Color.LemonChiffon;
                    lblLow.BackColor = Color.LemonChiffon;
                    lblNormal.BackColor = Color.LemonChiffon;
                    lblHigh.BackColor = Color.LemonChiffon;
                }
                else
                {
                    lblDay.BackColor = Color.White;
                    lblLow.BackColor= Color.White;
                    lblNormal.BackColor = Color.White;
                    lblHigh.BackColor = Color.White;
                }
            }
        }

        //public bool Enabled
        //{
        //    get { return _enabled; }
        //    set
        //    {
        //        _enabled = value;
        //        if (_enabled)
        //        {
        //            this.Visible = true;
        //        }
        //        else
        //        {
        //            //lblDay.Text = String.Empty;
        //            //lblDay.BackColor = SystemColors.Control;
        //            //lblHigh.Text = String.Empty;
        //            //lblHigh.BackColor = SystemColors.Control;
        //            //lblNormal.Text = String.Empty;
        //            //lblNormal.BackColor = SystemColors.Control;
        //            //lblLow.Text = String.Empty;
        //            //lblLow.BackColor = SystemColors.Control;
        //            this.Visible = false;
        //        }
                
        //    }
        //}
        public PlannerDay()
        {
            InitializeComponent();
        }

        // Methods

        /// <summary>
        /// Clear all fields in <c>PlannerDay</c> object.
        /// </summary>
        public void Clear()
        {
            lblDay.Text = String.Empty;
            lblLow.Text = String.Empty;
            lblNormal.Text = String.Empty;
            lblHigh.Text = String.Empty;
        }

        /// <summary>
        /// Clear all tasks in <c>PlannerDay</c> object.
        /// </summary>
        public void ClearTasks()
        {
            lblLow.Text = String.Empty;
            lblNormal.Text = String.Empty;
            lblHigh.Text = String.Empty;
        }
    }
}
