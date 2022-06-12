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
            string result = "국적 : ";
            if (rbKorea.Checked)  // 대한민국이 체크됬을때
                result += "국적 : 대한민국\n";
            else if (rbChina.Checked)  // 중국이 체크됬을때
                result += "국적 : 중국\n";
            else if (rbCanada.Checked)  // 캐나다가 체크됬을때
                result += "국적 : 캐나다\n";
            else if (rbOthers.Checked)  // 그 외에 가 체크됬을때 
                result += "국적 : 그 외의 국가\n";

            if (checkedRB == rbMale)
                result += "성별 : 남성";
            else if (checkedRB == rbFemale)
                result += "성별 : 여성";

            MessageBox.Show(result, "결과");
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