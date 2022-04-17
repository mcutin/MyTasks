using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MyTasks
{
    internal class XMLReader
    {
        // Fields
        private string file;
        private XElement content;
        private int taskCount;
        private int taskLowCount;
        private int taskHighCount;
        private int taskNormalCount;

        // Constructor
        public XMLReader(string xmlFile)
        {
            File = xmlFile;
        }

        // Properties
        public string File
        {
            get
            {
                return file;
            }

            set
            {
                file = value;
            }
        }

        public XElement Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public int TaskCount
        {
            get
            {
                return taskCount;
            }

            set
            {
                taskCount = value;
            }
        }

        public int TaskLowCount
        {
            get
            {
                return taskLowCount;
            }

            set
            {
                taskLowCount = value;
            }
        }

        public int TaskHighCount
        {
            get
            {
                return taskHighCount;
            }

            set
            {
                taskHighCount = value;
            }
        }

        public int TaskNormalCount
        {
            get
            {
                return taskNormalCount;
            }

            set
            {
                taskNormalCount = value;
            }
        }

        // Methods
        private int UpdateTaskCount()
        {
            // Returns the amount of existing tasks inside the XML file

            IEnumerable<XElement> tasks = this.Content.Descendants("task");
            int countTasks = 0;
            foreach (var task in tasks)
            {
                countTasks++;
            }
            return countTasks;
        }

        private int PriorityTaskCount(int p)
        {
            // Returns the amount of tasks according to the priority informed
            if (p >= 0 && p <= 2)
            {
                IEnumerable<XElement> prioTask = from t in this.Content.Elements("task")
                                                 where (int)t.Element("priority") == p
                                                 select t;
                int counter = 0;
                foreach (var task in prioTask)
                {
                    string prio;
                    switch (Int32.Parse(task.Element("priority").Value))
                    {
                        case 0:
                            prio = "Low";
                            break;
                        case 1:
                            prio = "Normal";
                            break;
                        case 2:
                            prio = "High";
                            break;
                        default:
                            prio = "N/D";
                            break;
                    }
                    Debug.WriteLine("Task ID: " + task.Element("id").Value.ToString() +
                        ", " + prio + " priority");
                    counter++;
                }
                return counter;
            }
            else
            {
                return Int32.MaxValue; // Return 2147483647 if p is invalid
            }
        }

        public bool Open()
        {
            try
            {
                this.Content = XElement.Load(this.File);
                this.TaskCount = UpdateTaskCount();
                this.TaskHighCount = PriorityTaskCount(2);
                this.TaskLowCount = PriorityTaskCount(0);
                this.TaskNormalCount = PriorityTaskCount(1);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("File not found: " + e.FileName, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (IOException e)
            {
                MessageBox.Show("Unknown I/O exception.\nError code: " + e.HResult +
                    "\nSystem message: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Update()
        {
            // Updates XMLReader Content to ensure any changes in the
            // XML file are reflected in memory content
            this.Content.RemoveAll();
            this.Open();
        }

        public int FirstFreeID()
        {
            // Returns the first free ID in the XML file
            // This free ID can be assigned to a new task
            
            int freeID = 1;
            bool idFound = true;
            do
            {
                IEnumerable<XElement> ids = from t in this.Content.Descendants("task")
                                            where (int)t.Element("id") == freeID
                                            select t;
                if (ids.Count() != 0)
                {
                    freeID++;
                }
                else
                {
                    idFound = false;
                }
            } while (idFound);
            return freeID;
        }
    }
}
