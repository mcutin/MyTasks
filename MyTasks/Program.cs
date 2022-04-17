using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTasks
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Check for tasks.xml file 
            if (!File.Exists("tasks.xml"))
            {
                MessageBox.Show("Failed to load tasks. Check if tasks.xml file exists inside application folder.\n\nExiting application.",
                    "Error loading tasks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Application.Run(new Main());
            }
        }
    }
}
