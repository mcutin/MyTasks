using System;

namespace MyTasks
{
    public class Task
    {
        // Fields
        protected ushort _id; // unsigned 16-bit integer is far more than enough
        protected byte _priority; // 8-bit integer is also far more than enough
        protected DateTime _dueDate;
        protected string _description;

        // Constructors
        public Task()
        {
            // Empty constructor exists only to allow JSON deserialization
        }

        public Task(int id, int priority, DateTime date, string desc)
        {
            ID = (ushort)id;
            Priority = (byte)priority;
            DueDate = date;
            Description = desc;
        }

        // Properties
        public ushort ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public byte Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set 
            {
                string tmp = value.ToString("dd/MM/yyyy");
                _dueDate = DateTime.Parse(tmp);
            }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
