using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTasks
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            rtfDay11.AppendText("11", Color.Black, HorizontalAlignment.Right , true);
            rtfDay11.AppendText("3", Color.Red, HorizontalAlignment.Left, true);
            rtfDay11.AppendText("1", Color.Green, HorizontalAlignment.Left, true);
            rtfDay11.AppendText("4", Color.Blue, HorizontalAlignment.Left, false);
        }
    }
}
