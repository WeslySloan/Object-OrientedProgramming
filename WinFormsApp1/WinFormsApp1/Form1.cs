//namespace WinFormsApp1
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void radioButton5_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void radioButton3_CheckedChanged(object sender, EventArgs e)
//        {

//        }

//        private void radioButton1_CheckedChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private RadioButton checkedRB;
        private string gender;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            string result = "���� : ";
            if (rbKorea.Checked)  // ���ѹα��� üũ������
                result += "���� : ���ѹα�\n";
            else if (rbChina.Checked)  // �߱��� üũ������
                result += "���� : �߱�\n";
            else if (rbCanada.Checked)  // ĳ���ٰ� üũ������
                result += "���� : ĳ����\n";
            else if (rbOthers.Checked)  // �� �ܿ� �� üũ������ 
                result += "���� : �� ���� ����\n";

            if (checkedRB == rbMale)
                result += "���� : ����";
            else if (checkedRB == rbFemale)
                result += "���� : ����";

            MessageBox.Show(result, "���");
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbMale;
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkedRB = rbFemale;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}