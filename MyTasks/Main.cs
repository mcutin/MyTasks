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

namespace MyTasks
{
    public partial class Main : Form
    {
        // Fields
        private Day[,] shortPlanMonth = new Day[5, 7];

        // Constructor
        public Main()
        {
            InitializeComponent();

            XMLReader tasks = new XMLReader("tasks.xml");
            tasks.Open();
            statusBarLabel.Text = tasks.TaskCount.ToString() + " tasks listed - Priority: " +
                tasks.TaskLowCount.ToString() + " low, " + tasks.TaskNormalCount.ToString() +
                " normal, " + tasks.TaskHighCount.ToString() + " high";

            dgvTasks.Columns.Add(new DataGridViewImageColumn()); // Col 0 - Priority image
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 1 - Due date
            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn()); // Col 2 - Description

            dgvTasks.Columns[0].Width = 25;
            dgvTasks.Columns[1].Width = 100;

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
            
            //DataSet dataset = new DataSet();
            //dataset.ReadXml("tasks.xml");
            //dgvTasks.DataSource = dataset.Tables[0];
            //dgvTasks.Columns[0].HeaderText = "ID"; // Task ID
            //dgvTasks.Columns[0].Visible = false;
            //dgvTasks.Columns[1].HeaderText = "P"; // Priority level
            //dgvTasks.Columns[1].Width = 25;
            //dgvTasks.Columns[2].HeaderText = "Due to"; // Task due date
            //dgvTasks.Columns[2].Width = 100;
            //dgvTasks.Columns[3].HeaderText = "Description"; //Task description
            //dgvTasks.Columns[3].Width = dgvTasks.Width -
                //dgvTasks.Columns[2].Width - dgvTasks.Columns[1].Width - 4;

            //dgvTasks.Columns.Add(new DataGridViewImageColumn());
            
            //DataGridViewImageCell cell = new DataGridViewImageCell();
            //for (int i = 0; i <= dgvTasks.Rows.Count - 1; i++)
            //{
            //    cell = (DataGridViewImageCell)dgvTasks.Rows[i].Cells[4];
            //    switch (dgvTasks.Rows[i].Cells[1].Value.ToString())
            //    {
            //        case "0":                        
            //            cell.Value = Properties.Resources.Low;
            //            break;
            //        case "1":
            //            cell.Value = Properties.Resources.Normal;
            //            break;
            //        case "2":
            //            cell.Value = Properties.Resources.High;
            //            break;
            //        default:
            //            cell.Value = null;
            //            break;
            //    }
            //}
        }

        // Methods
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
    }
}
