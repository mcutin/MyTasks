using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace MyTasks
{
    public class TaskList
    {
        private List<Task> _listOfTasks;
        protected string _fileName;

        public List<Task> ListOfTasks
        {
            get { return _listOfTasks; }
            set { _listOfTasks = value; }
        }

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        // Constructors
        public TaskList() 
        {
            ListOfTasks = new List<Task>();
        }

        public TaskList(string fileName)
        {
            FileName = fileName;
            ListOfTasks = new List<Task>();
        }

        public void Load()
        {
            ListOfTasks.Clear();
            string jsonString = File.ReadAllText(FileName);
            ListOfTasks = JsonSerializer.Deserialize<List<Task>>(jsonString);
        }

        public void Save()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize<List<Task>>(ListOfTasks, options);
            File.WriteAllText(FileName, jsonString);
        }

        public int FirstFreeID()
        {
            // Returns the first free ID in the file
            // This free ID can be assigned to a new task

            int freeID = 1;
            if (ListOfTasks != null)
            {
                bool idFound = true;
                do
                {
                    var lst = from t in ListOfTasks where t.ID == freeID select t;

                    if (lst.Count() != 0)
                    {
                        freeID++;
                    }
                    else
                    {
                        idFound = false;
                    }
                } while (idFound);
            }
            return freeID;
        }
    }
}
