using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPoll_Click(object sender, EventArgs e)
        {
            if(this.CB1.Checked!=false||this.CB2.Checked!=false)
            {
                foreach(RadioButton c in this.GB_Hobby.Controls)
                {
                    if (c.Checked == true)
                        this.Label_Hobby.Text = c.Text;
                }
                this.Label_Singer.Text = "";
                foreach (CheckBox c in this.GB_Singer.Controls)
                {
                    if(c.Checked==true)
                    {
                        this.Label_Singer.Text += c.Text +"  ";
                    }
                }
            }
        }
    }
}
