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
                MessageBox.Show("File not found: " + e.FileName + "\nSystem message: " + e.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

//   class XML_Reader
//    {
//        public string DHI_type;
//        public int DHI_no_gauges;
//        public string coef_file;
//        public string[,] exported_steps = new string[20, 6];

//        public void readXML(string xml_file)
//        {
//            //XElement xml_content = XElement.Load(xml_file);

//            DHI_type = xml_content.Element("DHI_type").Value;
//            DHI_no_gauges = xml_content.Element("DHI_number_of_gauges").Value;
//            coef_file = xml_content.Element("DHI_coefficients").Value;
//            IEnumerable<XElement> steps = xml_content.Descendants("step");
//            var i = 0;
//            foreach (var step in steps)
//            {
//                exported_steps[i, 0] = step.Attribute("step").Value;
//                var step_description = step.Descendants("description");
//                string desc = step.Element("description").Value;
//                exported_steps[i, 1] = step.Element("description").Value;
//                exported_steps[i, 2] = step.Element("analog_holding").Value;
//                exported_steps[i, 3] = step.Element("register").Value;
//                exported_steps[i, 4] = step.Element("no_registers").Value;
//                exported_steps[i, 5] = step.Element("values").Value;
//                Console.WriteLine(exported_steps[i, 1]);
//                i++;
//            }
//            Console.WriteLine("DHI type:\t" + DHI_type);
//            Console.WriteLine("Number of gauges:\t" + DHI_no_gauges.ToString());
//            Console.WriteLine("Coefficients file:\t" + coef_file);
//            Console.WriteLine();
//            for (int i = 0; i < 20; i++)
//            {
//                if (exported_steps[i, 0] <> null)
//                {
//                    Console.WriteLine("Step " + exported_steps[i, 0] + "\t" + exported_steps[i, 1]);
//                }
//            }
//        }
//    }
//}
