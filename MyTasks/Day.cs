using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTasks
{
    internal class Day
    {
		// Fields
		private DateTime dayDate = DateTime.Today;
		private int highTasks;
		private int normalTasks;
		private int lowTasks;
	
        // Constructor
		public Day(DateTime date, int Low = 0, int Normal = 0, int High = 0)
        {
            this.dayDate = date;
            this.LowTasks = Low;
            this.NormalTasks = Normal;
            this.HighTasks = High;
        }

        public DateTime DayDate
        {
            get
            {
                return dayDate;
            }

            set
            {
                dayDate = value;
            }
        }

        public int LowTasks
        {
            get
            {
                return lowTasks;
            }

            set
            {
                lowTasks = value;
            }
        }

        public int NormalTasks
        {
            get
            {
                return normalTasks;
            }

            set
            {
                normalTasks = value;
            }
        }

        public int HighTasks
        {
            get
            {
                return highTasks;
            }

            set
            {
                highTasks = value;
            }
        }

        public int DayOfMonth
        {
            get
            {
                return dayDate.Day;
            }
        }

        public int DayOfWeek
        {
            get
            {
                return (int)dayDate.DayOfWeek;
            }
        }
    }
}
