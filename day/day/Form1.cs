using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day
{
    public partial class Form1 : Form
    {
        public enum activitytype { Personal, Work, Entertainment }
        public class dates
        {
            public bool Starred { get; set; }
            public string name { get; set; }
           public activitytype type { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = e.Start.ToShortDateString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text=monthCalendar1.SelectionStart.ToString();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            dates d=new dates();
            d.name=nametext.Text;
            d.Starred=starcheck.Checked;
            d.type = (activitytype)Enum.Parse(typeof(activitytype), usecombo.Text);

        }
        public void showPlan(dates d)
        {
            nametext.Text=d.name;
            starcheck.Checked = d.Starred;
            usecombo.Text = d.type.ToString();
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            showPlan();
        }

       
    }
}
