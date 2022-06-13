using System;
using System.Linq;
using System.Windows.Forms;

// Ok button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-ok-apply-icon.html
// Cancel button icon downloaded from https://iconarchive.com/show/oxygen-icons-by-oxygen-icons.org/Actions-dialog-cancel-icon.html

namespace MyTasks
{
    public partial class EditTask : Form
    {
        // Fields
        protected TaskList _taskList;
        protected int _taskID;

        // Properties
        public TaskList TaskList
        {
            get { return _taskList; }
            set { _taskList = value; }
        }

        public int TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }

        public EditTask(int id, string description, string dueDate, string priority, TaskList list)
        {
            InitializeComponent();
            taskDescription.Text = description;
            DateTime date = DateTime.ParseExact(dueDate, "dd/MM/yyyy", null);
            taskDueDate.Value = date;
            taskPriority.Text = priority;
            TaskList = list;
            TaskID = id;
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

            Task itemToEdit = TaskList.ListOfTasks.Single<Task>(r => r.ID == TaskID);

            itemToEdit.Priority = (byte)pValue;
            itemToEdit.DueDate = DateTime.Parse(taskDueDate.Value.ToString());
            itemToEdit.Description = taskDescription.Text;

            TaskList.Save();
            this.Close();
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

        private void taskDescription_TextChanged(object sender, EventArgs e)
        {
            EnableOkButton();
        }

        private void taskDescription_Leave(object sender, EventArgs e)
        {
            EnableOkButton();
        }
    }
}
