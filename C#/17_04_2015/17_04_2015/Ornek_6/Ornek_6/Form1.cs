using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label1.Text = "Start = " + monthCalendar1.SelectionRange.Start.ToLongDateString() + ",   End = " +
                          monthCalendar1.SelectionRange.End.ToLongDateString();
        }
    }
}
