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
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            taskPriority.Text = "Normal"; // Priority default value
            this.ActiveControl = taskDescription; // Sets initial focus to task description
        }

        private void taskDescription_Leave(object sender, EventArgs e)
        {
            EnableOkButton();
        }

        private void taskDescription_TextChanged(object sender, EventArgs e)
        {
            EnableOkButton();
        }

        private void EnableOkButton()
        {
            // Check if condition for Ok button to be enabled is met
            if (string.IsNullOrEmpty(taskDescription.Text))
            {
                this.btnOk.Enabled = false;
            }
            else
            {
                this.btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Saves new task to XML file

            XMLReader taskDB = new XMLReader("tasks.xml");
            taskDB.Open();
            int newID = taskDB.FirstFreeID();
            int newPriority = 1; // Default priority is Normal
            if (taskPriority.Text == "Low")
            {
                newPriority = 0;
            }
            else if (taskPriority.Text == "High")
            {
                newPriority = 2;
            }
            taskDB.Content.Add(new XElement("task", 
                new XElement("id", newID.ToString()),
                new XElement("priority", newPriority.ToString()),
                new XElement("dueDate", taskDueDate.Value.ToString("dd/MM/yyyy")),
                new XElement("description", taskDescription.Text)));
            taskDB.Content.Save("tasks.xml");
        }
    }
}
