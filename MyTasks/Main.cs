﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            UpdateShortTermPlan();
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
            // Initilalize short plan array
            Day[,] shortTerm = new Day[5, 7];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    shortTerm[i, j] = new Day();
                }
            }

            // Current moth is based on oldest task
            // Check day of the week of oldest task due date
            DayOfWeek dow = tasks.OldestDate.DayOfWeek;

            switch (dow)
            {
                case DayOfWeek.Monday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = true;
                    shortTerm[0, 2].Enabled = true;
                    shortTerm[0, 3].Enabled = true;
                    shortTerm[0, 4].Enabled = true;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
                case DayOfWeek.Tuesday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = false;
                    shortTerm[0, 2].Enabled = true;
                    shortTerm[0, 3].Enabled = true;
                    shortTerm[0, 4].Enabled = true;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
                case DayOfWeek.Wednesday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = false;
                    shortTerm[0, 2].Enabled = false;
                    shortTerm[0, 3].Enabled = true;
                    shortTerm[0, 4].Enabled = true;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
                case DayOfWeek.Thursday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = false;
                    shortTerm[0, 2].Enabled = false;
                    shortTerm[0, 3].Enabled = false;
                    shortTerm[0, 4].Enabled = true;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
                case DayOfWeek.Friday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = false;
                    shortTerm[0, 2].Enabled = false;
                    shortTerm[0, 3].Enabled = false;
                    shortTerm[0, 4].Enabled = false;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
                case DayOfWeek.Saturday:
                    shortTerm[0, 0].Enabled = false;
                    shortTerm[0, 1].Enabled = false;
                    shortTerm[0, 2].Enabled = false;
                    shortTerm[0, 3].Enabled = false;
                    shortTerm[0, 4].Enabled = false;
                    shortTerm[0, 5].Enabled = false;
                    shortTerm[0, 6].Enabled = true;
                    break;
                default:
                    shortTerm[0, 0].Enabled = true;
                    shortTerm[0, 1].Enabled = true;
                    shortTerm[0, 2].Enabled = true;
                    shortTerm[0, 3].Enabled = true;
                    shortTerm[0, 4].Enabled = true;
                    shortTerm[0, 5].Enabled = true;
                    shortTerm[0, 6].Enabled = true;
                    break;
            }

            // Fill in all the data for each Day in short term plan
            DateTime date = tasks.OldestDate;

            for (int row = 0; row <= 4; row++)
            {
                for (int col = 0; col <= 6; col++)
                {
                    if (shortTerm[row, col].Enabled)
                    {
                        // Fill in date of day
                        shortTerm[row, col].DayDate = date;

                        // Fill in tasks per priority
                        // Low
                        IEnumerable<XElement> lp = from t in tasks.Content.Elements("task")
                                                   where t.Element("dueDate").ToString() == date.ToString("dd/MM/yyyy")
                                                   && (int)t.Element("priority") == 0
                                                   select t;
                        shortTerm[row, col].LowTasks = lp.Count();
                        // Normal
                        IEnumerable<XElement> np = from t in tasks.Content.Elements("task")
                                                   where t.Element("dueDate").ToString() == date.ToString("dd/MM/yyyy")
                                                   && (int)t.Element("priority") == 1
                                                   select t;
                        shortTerm[row, col].NormalTasks = np.Count();
                        // High
                        IEnumerable<XElement> hp = from t in tasks.Content.Elements("task")
                                                   where t.Element("dueDate").ToString() == date.ToString("dd/MM/yyyy")
                                                   && (int)t.Element("priority") == 2
                                                   select t;
                        shortTerm[row, col].HighTasks = hp.Count();

                        // Increment date
                        date = date.AddDays(1);
                    }
                }
            }
            UpdateDay(rtfDay11, shortTerm);
            UpdateDay(rtfDay12, shortTerm);
            UpdateDay(rtfDay13, shortTerm);
            UpdateDay(rtfDay14, shortTerm);
            UpdateDay(rtfDay15, shortTerm);
            UpdateDay(rtfDay16, shortTerm);
            UpdateDay(rtfDay17, shortTerm);
            UpdateDay(rtfDay21, shortTerm);
            UpdateDay(rtfDay22, shortTerm);
            UpdateDay(rtfDay23, shortTerm);
            UpdateDay(rtfDay24, shortTerm);
            UpdateDay(rtfDay25, shortTerm);
            UpdateDay(rtfDay26, shortTerm);
            UpdateDay(rtfDay27, shortTerm);
            UpdateDay(rtfDay31, shortTerm);
            UpdateDay(rtfDay32, shortTerm);
            UpdateDay(rtfDay33, shortTerm);
            UpdateDay(rtfDay34, shortTerm);
            UpdateDay(rtfDay35, shortTerm);
            UpdateDay(rtfDay36, shortTerm);
            UpdateDay(rtfDay37, shortTerm);
            UpdateDay(rtfDay41, shortTerm);
            UpdateDay(rtfDay42, shortTerm);
            UpdateDay(rtfDay43, shortTerm);
            UpdateDay(rtfDay44, shortTerm);
            UpdateDay(rtfDay45, shortTerm);
            UpdateDay(rtfDay46, shortTerm);
            UpdateDay(rtfDay47, shortTerm);
            UpdateDay(rtfDay51, shortTerm);
            UpdateDay(rtfDay52, shortTerm);
            UpdateDay(rtfDay53, shortTerm);
            UpdateDay(rtfDay54, shortTerm);
            UpdateDay(rtfDay55, shortTerm);
            UpdateDay(rtfDay56, shortTerm);
            UpdateDay(rtfDay57, shortTerm);

            // Update groupShortTermPlan Text property
            string month = tasks.OldestDate.ToString("MMMM",new CultureInfo("en-US"));
            groupShortTermPlan.Text = "Short term plan - " + month;
        }

        public void UpdateDay(RichTextBox day, Day[,] shortTerm)
        {
            Int32.TryParse(day.Name.Substring(day.Name.Length - 1, 1), out int d);
            Int32.TryParse(day.Name.Substring(day.Name.Length - 2, 1), out int w);
            d--;
            w--;

            if (shortTerm[w, d].Enabled)
            {
                // Reflect new data on each rtfDay object
                day.AppendText(shortTerm[w, d].DayDate.Day.ToString(), Color.Black,
                    FontStyle.Bold, HorizontalAlignment.Right);
                if (shortTerm[w, d].HighTasks > 0)
                {
                    day.AppendText(shortTerm[w, d].HighTasks.ToString(), Color.Red);
                }
                else
                {
                    day.AppendText(Environment.NewLine);
                }
                if (shortTerm[w, d].NormalTasks > 0)
                {
                    day.AppendText(shortTerm[w, d].NormalTasks.ToString(), Color.Green);
                }
                else
                {
                    day.AppendText(Environment.NewLine);
                }
                if (shortTerm[w, d].LowTasks > 0)
                {
                    day.AppendText(shortTerm[w, d].LowTasks.ToString(), Color.Blue);
                }
            }
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
            UpdateShortTermPlan();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }
    }
}
