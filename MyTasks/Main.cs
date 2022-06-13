using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Project icon downloaded from https://iconarchive.com/show/onebit-4-icons-by-icojam/clipboard-icon.html
// Icon for New Task button downloaded from collection https://iconarchive.com/show/snowish-icons-by-saki.3.html

namespace MyTasks
{
    public partial class Main : Form
    {
        static string fileName = "MyTasks.json";
        TaskList allTasks = new TaskList(fileName);
        PlannerDay[,] shortTerm = new PlannerDay[7, 5];

        // Constructor
        public Main()
        {
            InitializeComponent();
            
            // Add all PlannerDay objects to shortTerm array
            shortTerm[0, 0] = PDay00;
            shortTerm[1, 0] = PDay10;
            shortTerm[2, 0] = PDay20;
            shortTerm[3, 0] = PDay30;
            shortTerm[4, 0] = PDay40;
            shortTerm[5, 0] = PDay50;
            shortTerm[6, 0] = PDay60;
            shortTerm[0, 1] = PDay01;
            shortTerm[1, 1] = PDay11;
            shortTerm[2, 1] = PDay21;
            shortTerm[3, 1] = PDay31;
            shortTerm[4, 1] = PDay41;
            shortTerm[5, 1] = PDay51;
            shortTerm[6, 1] = PDay61;
            shortTerm[0, 2] = PDay02;
            shortTerm[1, 2] = PDay12;
            shortTerm[2, 2] = PDay22;
            shortTerm[3, 2] = PDay32;
            shortTerm[4, 2] = PDay42;
            shortTerm[5, 2] = PDay52;
            shortTerm[6, 2] = PDay62;
            shortTerm[0, 3] = PDay03;
            shortTerm[1, 3] = PDay13;
            shortTerm[2, 3] = PDay23;
            shortTerm[3, 3] = PDay33;
            shortTerm[4, 3] = PDay43;
            shortTerm[5, 3] = PDay53;
            shortTerm[6, 3] = PDay63;
            shortTerm[0, 4] = PDay04;
            shortTerm[1, 4] = PDay14;
            shortTerm[2, 4] = PDay24;
            shortTerm[3, 4] = PDay34;
            shortTerm[4, 4] = PDay44;
            shortTerm[5, 4] = PDay54;
            shortTerm[6, 4] = PDay64;

            // If JSON file does not exist, adds a new general task
            if (!File.Exists(fileName))
            {
                Task t = new Task(1, 1, DateTime.Now, "My first task.");
                allTasks.ListOfTasks = new List<Task>() { t };
            }
            else
            {
                allTasks.Load();
            }
        }

        // Methods

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
            var orderedList = radioDueDate.Checked ? allTasks.ListOfTasks.OrderBy(t => t.DueDate).ThenByDescending(t => t.Priority) :
                    allTasks.ListOfTasks.OrderByDescending(t => t.Priority).ThenBy(t => t.DueDate);
            
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
                date.Value = t.DueDate.ToString("dd/MM/yyyy");
                description.Value = t.Description;
                id.Value = t.ID;
                prioNum.Value = t.Priority;
            }
            dgvTasks.Rows[0].Selected = true;
            HighlightDay(DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null));
        }

        private void UpdateStatusBar()
        {
            int lowP = 0;
            int normalP = 0;
            int highP = 0;
            foreach(Task t in allTasks.ListOfTasks)
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
            statusBarLabel.Text = allTasks.ListOfTasks.Count().ToString() + " tasks listed - Priority: " +
                lowP.ToString() + " low, " + normalP.ToString() + " normal, " + highP.ToString() + " high";
        }

        private void UpdateShortTermPlan()
        {
            // Clear all days in short term plan before updating
            ClearAllCalendar();

            // Fill in all the data for each Day in short term plan

            // Returns the oldest task date
            DateTime firstDate = DateTime.MaxValue;
            foreach (Task t in allTasks.ListOfTasks)
            {
                if (firstDate > t.DueDate)
                {
                    firstDate = t.DueDate;
                }
            }

            UpdateCalendar(shortTerm, firstDate);

            // Dates needed to properly update groupShortTermPlan.Text
            DateTime date = firstDate;
            DateTime lastDate;
            
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (shortTerm[col, row].Visible)
                    {
                        // Fill in date of day
                        shortTerm[col, row].Date = date;

                        // Fill in tasks per priority
                        // Low
                        IEnumerable<Task> lp = from t in allTasks.ListOfTasks
                                                   where t.Priority == 0 && t.DueDate == date
                                                   select t;

                        foreach(Task t in lp) { }
                        shortTerm[col, row].Low = lp.Count();
                        // Normal
                        IEnumerable<Task> np = from t in allTasks.ListOfTasks
                                                   where t.Priority == 1 && t.DueDate == date
                                                   select t;

                        foreach(Task t in np) { }
                        shortTerm[col, row].Normal = np.Count();
                        // High
                        IEnumerable<Task> hp = from t in allTasks.ListOfTasks
                                                   where t.Priority == 2 && t.DueDate == date
                                                   select t;

                        foreach(Task t in hp) { }
                        shortTerm[col, row].High = hp.Count();

                        // Increment date
                        date = date.AddDays(1);
                    }
                }
            }
            HighlightDay(DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null));

            // Update groupShortTermPlan Text property
            lastDate = shortTerm[6, 4].Date;            
            groupShortTermPlan.Text = "Short term plan - " + ShortTermPeriod(firstDate, lastDate);
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
                    PDay00.Visible = false;
                    PDay10.Visible = true;
                    PDay20.Visible = true;
                    PDay30.Visible = true;
                    PDay40.Visible = true;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
                    break;
                case DayOfWeek.Tuesday:
                    PDay00.Visible = false;
                    PDay10.Visible = false;
                    PDay20.Visible = true;
                    PDay30.Visible = true;
                    PDay40.Visible = true;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
                    break;
                case DayOfWeek.Wednesday:
                    PDay00.Visible = false;
                    PDay10.Visible = false;
                    PDay20.Visible = false;
                    PDay30.Visible = true;
                    PDay40.Visible = true;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
                    break;
                case DayOfWeek.Thursday:
                    PDay00.Visible = false;
                    PDay10.Visible = false;
                    PDay20.Visible = false;
                    PDay30.Visible = false;
                    PDay40.Visible = true;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
                    break;
                case DayOfWeek.Friday:
                    PDay00.Visible = false;
                    PDay10.Visible = false;
                    PDay20.Visible = false;
                    PDay30.Visible = false;
                    PDay40.Visible = false;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
                    break;
                case DayOfWeek.Saturday:
                    PDay00.Visible = false;
                    PDay10.Visible = false;
                    PDay20.Visible = false;
                    PDay30.Visible = false;
                    PDay40.Visible = false;
                    PDay50.Visible = false;
                    PDay60.Visible = true;
                    break;
                default:
                    PDay00.Visible = true;
                    PDay10.Visible = true;
                    PDay20.Visible = true;
                    PDay30.Visible = true;
                    PDay40.Visible = true;
                    PDay50.Visible = true;
                    PDay60.Visible = true;
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

        private void UpdateAll()
        {
            UpdateStatusBar();
            FormatTaskList();
            UpdateTaskList();
            UpdateShortTermPlan();
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask(allTasks);
            newTask.ShowDialog();
            allTasks.Load();
            UpdateAll();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void dgvTasks_Click(object sender, EventArgs e)
        {
            DateTime selDate = DateTime.ParseExact(dgvTasks.SelectedRows[0].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
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
            EditTask(dgvTasks);
        }

        private void EditTask(DataGridView dgv)
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
            EditTask editTask = new EditTask(id, description, date, priority, allTasks);
            editTask.ShowDialog();
            allTasks.Load();
            UpdateAll();
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

        private void dgvTasks_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Based on code from https://stackoverflow.com/a/9820529/5952443
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.dgvTasks.ClearSelection();
                    this.dgvTasks.Rows[rowSelected].Selected = true;
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }

        private void dgvContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem menuOption = e.ClickedItem;
            if(menuOption.Name == "completeTask")
            {
                DeleteTask();
            }
            else if(menuOption.Name == "editTaskTSMenu")
            {
                EditTask(dgvTasks);
            }
        }

        private void DeleteTask()
        {
            DialogResult userAnswer = MessageBox.Show("Are you sure you want to flag this task completed and remove it?",
                "Complete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(userAnswer == DialogResult.Yes)
            {
                Int32.TryParse(dgvTasks.SelectedRows[0].Cells[3].Value.ToString(), out int selectedID);
                Task itemToRemove = allTasks.ListOfTasks.Single<Task>(r => r.ID == selectedID);
                allTasks.ListOfTasks.Remove(itemToRemove);
                allTasks.Save();
                allTasks.Load();
                UpdateAll();
            }
        }

        private void dgvTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteTask();
            }
            return;
        }
    }
}
