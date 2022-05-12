using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ok button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-ok-apply-icon.html
// Cancel button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-cancel-icon.html

namespace MyTasks
{
    public partial class EditTask : Form
    {
        public EditTask(int id, string description, string dueDate, string priority)
        {
            InitializeComponent();
            taskDescription.Text = description;
            DateTime date = DateTime.ParseExact(dueDate, "dd/MM/yyyy hh:mm:ss", null);
            taskDueDate.Value = date;
            taskPriority.Text = priority;
            //switch (priority)
            //{
            //    case "Low":
            //        taskPriority.SelectedIndex = 0;
            //        break;
            //    case "Normal":
            //        taskPriority.SelectedIndex = 1;
            //        break;
            //    case "High":
            //        taskPriority.SelectedIndex = 2;
            //        break;
            //    default:
            //        taskPriority.SelectedIndex = 0;
            //        break;
            //}
        }
    }
}
