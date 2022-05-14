using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        List<Task> taskList = new List<Task>();
        PlannerDay[,] shortTerm = new PlannerDay[7, 5];

        // Constructor
        public Main()
        {
            InitializeComponent();
            
            // Initilalize short plan array
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 5; row++)
                {
                    // Instatiates all necessary PlannerDay objects
                    shortTerm[col, row] = new PlannerDay();
                    // Add each object to groupShortTermPlan
                    groupShortTermPlan.Controls.Add(shortTerm[col, row]);
                    // Define each object location inside groupShortTermPlan
                    shortTerm[col, row].Location = new Point(15 + col * shortTerm[col, row].Width,
                                                         65 + row * shortTerm[col, row].Height);
                }
            }
        }

        // Methods
        public void LoadTasks()
        {
            taskList.Clear();
            tasks.Open();

            // Populate taskList with tasks loaded from XML file
            IEnumerable<XElement> allTasks = from t in tasks.Content.Descendants("task") select t;
            foreach (XElement task in allTasks)
            {
                Int32.TryParse(task.Element("id").Value, out int tempID);
                Int32.TryParse(task.Element("priority").Value, out int tempPriority);
                DateTime tempDate = DateTime.ParseExact(task.Element("dueDate").Value, "dd/MM/yyyy", null);
                string tempDescription = task.Element("description").Value;
                Task tempTask = new Task(tempID, tempPriority, tempDate, tempDescription);
                taskList.Add(tempTask);
            }
            
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();
            UpdateShortTermPlan();
        }

        private void FormatTaskList()
        {
            dgvTasks.Columns.Clear();
            dgvTasks.Columns.Add(new DataGridViewImageColumn()); // Col 0 - Priority image
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 1 - Due date
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 2 - Description
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 3 - ID
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 4 - Priority number

            dgvTasks.Columns[0].Width = 25;
            dgvTasks.Columns[1].Width = 100;
            dgvTasks.Columns[2].Width = dgvTasks.Width - dgvTasks.Margin.All -
                dgvTasks.Columns[0].Width - dgvTasks.Columns[1].Width;
            dgvTasks.Columns[3].Visible = false;
            dgvTasks.Columns[4].Visible = false;
        }

        private void UpdateTaskList()
        {
            // Check order
            var orderedList = radioDueDate.Checked ? taskList.OrderBy(t => t.DueDate).ThenByDescending(t => t.Priority) :
                    taskList.OrderByDescending(t => t.Priority).ThenBy(t => t.DueDate);
            
            // Clear datagridview
            dgvTasks.Rows.Clear();
            
            // Populate datagridview again
            foreach (Task t in orderedList)
            {
                dgvTasks.Rows.Add();
                DataGridViewImageCell prioImg = (DataGridViewImageCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[0];
                DataGridViewTextBoxCell date = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[1];
                DataGridViewTextBoxCell description = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[2];
                DataGridViewTextBoxCell id = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[3];
                DataGridViewTextBoxCell prioNum = (DataGridViewTextBoxCell)dgvTasks.Rows[dgvTasks.Rows.Count - 1].Cells[4];
                switch (t.Priority)
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
                date.Value = t.DueDate;
                description.Value = t.Description;
                id.Value = t.ID;
                prioNum.Value = t.Priority;
            }
            HighlightDay(DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null));
        }

        private void UpdateStatusBar()
        {
            int lowP = 0;
            int normalP = 0;
            int highP = 0;
            foreach(Task t in taskList)
            {
                switch (t.Priority)
                {
                    case 0:
                        lowP++;
                        break;
                    case 1:
                        normalP++;
                        break;
                    case 2:
                        highP++;
                        break;
                    default:
                        break;
                }
            }
            statusBarLabel.Text = taskList.Count().ToString() + " tasks listed - Priority: " +
                lowP.ToString() + " low, " + normalP.ToString() + " normal, " + highP.ToString() + " high";
        }

        private void UpdateShortTermPlan()
        {
            // Clear all days in short term plan before updating
            ClearAllCalendar();

            // Fill in all the data for each Day in short term plan

            // Returns the oldest task date
            DateTime date = DateTime.MaxValue;
            foreach (Task t in taskList)
            {
                if (date > t.DueDate)
                {
                    date = t.DueDate;
                }
            }

            UpdateCalendar(shortTerm, date);

            // Dates needed to properly update groupShortTermPlan.Text
            DateTime lastDate;
            
            for (int row = 0; row <= 4; row++)
            {
                for (int col = 0; col <= 6; col++)
                {
                    if (shortTerm[col, row].Visible)
                    {
                        // Fill in date of day
                        shortTerm[col, row].Date = date;

                        // Fill in tasks per priority
                        // Low
                        IEnumerable<Task> lp = from t in taskList
                                                   where t.Priority == 0 && t.DueDate == date
                                                   select t;

                        shortTerm[col, row].Low = lp.Count();
                        // Normal
                        IEnumerable<Task> np = from t in taskList
                                                   where t.Priority == 1 && t.DueDate == date
                                                   select t;

                        shortTerm[col, row].Normal = np.Count();
                        // High
                        IEnumerable<Task> hp = from t in taskList
                                                   where t.Priority == 2 && t.DueDate == date
                                                   select t;

                        shortTerm[col, row].High = hp.Count();

                        // Increment date
                        date = date.AddDays(1);
                    }
                }
            }
            //DateTime selDate = DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null);
            HighlightDay(DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null));

            // Update groupShortTermPlan Text property
            lastDate = shortTerm[6, 4].Date;            
            groupShortTermPlan.Text = "Short term plan - " + ShortTermPeriod(date, lastDate);
        }

        private string ShortTermPeriod(DateTime firstDay, DateTime lastDay)
        {
            string monthST;
            if (firstDay.Month == lastDay.Month)
            {
                monthST = firstDay.ToString("MMMM", new CultureInfo("en-US"));
            }
            else if (firstDay.Month == lastDay.Month - 1)
            {
                monthST = firstDay.ToString("MMMM", new CultureInfo("en-US")) + "/" +
                    lastDay.ToString("MMMM", new CultureInfo("en-US"));
            }
            else
            {
                DateTime dat = firstDay.AddMonths(1);
                monthST = firstDay.ToString("MMMM", new CultureInfo("en-US")) + "/" +
                    dat.ToString("MMMM", new CultureInfo("en-US")) + "/" +
                    lastDay.ToString("MMMM", new CultureInfo("en-US"));
            }

            return monthST;
        }

        private void UpdateCalendar(PlannerDay[,] shortTerm, DateTime oldestDate)
        {
            // Current month is based on oldest task
            // Check day of the week of oldest task due date
            DayOfWeek dow = oldestDate.DayOfWeek;

            switch (dow)
            {
                case DayOfWeek.Monday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[0, 1].Visible = true;
                    shortTerm[0, 2].Visible = true;
                    shortTerm[0, 3].Visible = true;
                    shortTerm[0, 4].Visible = true;
                    shortTerm[0, 5].Visible = true;
                    shortTerm[0, 6].Visible = true;
                    break;
                case DayOfWeek.Tuesday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[1, 0].Visible = false;
                    shortTerm[2, 0].Visible = true;
                    shortTerm[3, 0].Visible = true;
                    shortTerm[4, 0].Visible = true;
                    shortTerm[5, 0].Visible = true;
                    shortTerm[6, 0].Visible = true;
                    break;
                case DayOfWeek.Wednesday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[1, 0].Visible = false;
                    shortTerm[2, 0].Visible = false;
                    shortTerm[3, 0].Visible = true;
                    shortTerm[4, 0].Visible = true;
                    shortTerm[5, 0].Visible = true;
                    shortTerm[6, 0].Visible = true;
                    break;
                case DayOfWeek.Thursday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[1, 0].Visible = false;
                    shortTerm[2, 0].Visible = false;
                    shortTerm[3, 0].Visible = false;
                    shortTerm[4, 0].Visible = true;
                    shortTerm[5, 0].Visible = true;
                    shortTerm[6, 0].Visible = true;
                    break;
                case DayOfWeek.Friday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[1, 0].Visible = false;
                    shortTerm[2, 0].Visible = false;
                    shortTerm[3, 0].Visible = false;
                    shortTerm[4, 0].Visible = false;
                    shortTerm[5, 0].Visible = true;
                    shortTerm[6, 0].Visible = true;
                    break;
                case DayOfWeek.Saturday:
                    shortTerm[0, 0].Visible = false;
                    shortTerm[1, 0].Visible = false;
                    shortTerm[2, 0].Visible = false;
                    shortTerm[3, 0].Visible = false;
                    shortTerm[4, 0].Visible = false;
                    shortTerm[5, 0].Visible = false;
                    shortTerm[6, 0].Visible = true;
                    break;
                default:
                    shortTerm[0, 0].Visible = true;
                    shortTerm[1, 0].Visible = true;
                    shortTerm[2, 0].Visible = true;
                    shortTerm[3, 0].Visible = true;
                    shortTerm[4, 0].Visible = true;
                    shortTerm[5, 0].Visible = true;
                    shortTerm[6, 0].Visible = true;
                    break;
            }
        }

        private void ClearAllCalendar()
        {
            for(int col = 0; col < 7; col++)
            {
                for(int row = 0; row < 5; row++)
                {
                    shortTerm[col, row].Clear();
                }
            }
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.ShowDialog();
            tasks.Update();
            LoadTasks();
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();
            UpdateShortTermPlan();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void dgvTasks_Click(object sender, EventArgs e)
        {
            DateTime selDate = DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy HH:mm:ss", null);
            HighlightDay(selDate);
        }

        private void radioDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDueDate.Checked)
            {
                UpdateTaskList();
            }
        }

        private void radioPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPriority.Checked)
            {
                UpdateTaskList();
            }
        }

        private void lblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About aboutDlg = new About();
            aboutDlg.ShowDialog();
        }

        private void dgvTasks_DoubleClick(object sender, EventArgs e)
        {
            Int32.TryParse(dgvTasks.SelectedCells[3].Value.ToString(), out int id);
            string description = dgvTasks.SelectedCells[2].Value.ToString();
            string date = dgvTasks.SelectedCells[1].Value.ToString();
            Int32.TryParse(dgvTasks.SelectedCells[4].Value.ToString(), out int prio);
            string priority;
            switch (prio)
            {
                case 0:
                    priority = "Low";
                    break;
                case 1:
                    priority = "Normal";
                    break;
                case 2:
                    priority = "High";
                    break;
                default:
                    priority = "Low";
                    break;
            }
            EditTask editTask = new EditTask(id, description, date, priority);
            editTask.ShowDialog();
            tasks.Update();
            LoadTasks();
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();
            UpdateShortTermPlan();
        }

        private void HighlightDay(DateTime date)
        {
            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 5; row++)
                {
                    if(shortTerm[col, row].Date == date)
                    {
                        shortTerm[col, row].Highlight = true;
                    }
                    else
                    {
                        shortTerm[col, row].Highlight = false;
                    }
                }
            }
        }
    }
}
