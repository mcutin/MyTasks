using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

// Ok button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-ok-apply-icon.html
// Cancel button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-cancel-icon.html

namespace MyTasks
{
    public partial class EditTask : Form
    {
        // Fields
        protected XMLReader _allTasks;
        protected int _taskID;

        // Properties
        public XMLReader AllTasks
        {
            get { return _allTasks; }
            set { _allTasks = value; }
        }

        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }

        public EditTask(int id, string description, string dueDate, string priority, XMLReader tasks)
        {
            InitializeComponent();
            taskDescription.Text = description;
            //DateTime date = DateTime.ParseExact(dueDate, "dd/MM/yyyy hh:mm:ss", null);
            DateTime date = DateTime.ParseExact(dueDate, "dd/MM/yyyy", null);
            taskDueDate.Value = date;
            taskPriority.Text = priority;
            this.AllTasks = tasks;
            this.TaskID = id;

        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            string pText = taskPriority.Text;
            ushort pValue = 0; // Default is Low priority
            switch (pText)
            {
                case "Normal":
                    pValue = 1;
                    break;
                case "High":
                    pValue = 2;
                    break;
                default:
                    pValue = 0;
                    break;
            }

            var item = from t in this.AllTasks.Content.Descendants("task")
                       where Int32.Parse(t.Element("id").Value) == this.TaskID
                       select t;
            
            foreach(XElement task in item)
            {
                task.SetElementValue("priority", pValue.ToString());
                task.SetElementValue("dueDate", taskDueDate.Value.ToString("dd/MM/yyyy"));
                task.SetElementValue("description", taskDescription.Text);
            }
            AllTasks.Save();
            this.Close();
        }
    }
}
