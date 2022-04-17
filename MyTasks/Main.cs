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

// Project icon downloaded from https://iconarchive.com/show/onebit-4-icons-by-icojam/clipboard-icon.html
// Icon for New Task button downloaded from collection https://iconarchive.com/show/snowish-icons-by-saki.3.html

namespace MyTasks
{
    public partial class Main : Form
    {
        XMLReader tasks = new XMLReader("tasks.xml");
        // Fields
        private Day[,] shortPlanMonth = new Day[5, 7];

        // Constructor
        public Main()
        {
            InitializeComponent();  
        }

        // Methods
        public void LoadTasks()
        {            
            tasks.Open();
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();            
        }

        private void FormatTaskList()
        {
            dgvTasks.Columns.Clear();
            dgvTasks.Columns.Add(new DataGridViewImageColumn()); // Col 0 - Priority image
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 1 - Due date
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 2 - Description

            dgvTasks.Columns[0].Width = 25;
            dgvTasks.Columns[1].Width = 100;
            dgvTasks.Columns[2].Width = dgvTasks.Width - dgvTasks.Margin.All -
                dgvTasks.Columns[0].Width - dgvTasks.Columns[1].Width;
        }

        private void UpdateTaskList()
        {            
            IEnumerable<XElement> allTasks = tasks.Content.Descendants("task");
            foreach (var task in allTasks)
            {
                dgvTasks.Rows.Add();
                DataGridViewImageCell prioImg = (DataGridViewImageCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[0];
                DataGridViewTextBoxCell date = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[1];
                DataGridViewTextBoxCell description = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[2];
                Int32.TryParse(task.Element("priority").Value, out int priority);
                switch (priority)
                {
                    case 0:
                        prioImg.Value = Properties.Resources.Low;
                        break;
                    case 1:
                        prioImg.Value = Properties.Resources.Normal;
                        break;
                    case 2:
                        prioImg.Value = Properties.Resources.High;
                        break;
                    default:
                        prioImg.Value = null;
                        break;
                }
                date.Value = task.Element("dueDate").Value;
                description.Value = task.Element("description").Value;
            }
        }

        private void UpdateStatusBar()
        {
            statusBarLabel.Text = tasks.TaskCount.ToString() + " tasks listed - Priority: " +
                tasks.TaskLowCount.ToString() + " low, " + tasks.TaskNormalCount.ToString() +
                " normal, " + tasks.TaskHighCount.ToString() + " high";
        }

        public void UpdateShortTermPlan()
        {
            // To be implemented
        }

        public void UpdateDay(RichTextBox day, DateTime date)
        {
            Int32.TryParse(day.Name.Substring(Name.Length - 1), out int dayOfWeek);
            Int32.TryParse(day.Name.Substring(Name.Length - 2, 1), out int week);

            shortPlanMonth[week, dayOfWeek].DayDate = date;
        }

        private void dgvTasks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event to handle task editing
            MessageBox.Show("Double clicked row: " + e.RowIndex.ToString(), "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.ShowDialog();
            tasks.Update();
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
    }
}
