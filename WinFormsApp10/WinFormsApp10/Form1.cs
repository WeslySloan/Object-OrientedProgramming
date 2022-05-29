using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void contents_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //���Ͽ���â ���� �� ����
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "���� ����â";
            ofd.FileName = "";
            ofd.Filter = "�ؽ�Ʈ ���� (*.txt) | *.txt";

            //���� ����â �ε�
            DialogResult dr = ofd.ShowDialog();

            //OK��ư Ŭ����
            if (dr == DialogResult.OK)
            {

                //������Ƽ
                //File�� �̴´�
                string fileNamel = ofd.SafeFileName.Substring(0, ofd.SafeFileName.Length - 4);
                StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8);

                int position = ofd.FileName.LastIndexOf("\\");

                string textFileName = ofd.FileName.Substring(position + 1);

                this.Text = textFileName + " - Libo�޸���";

                //��� ����

                contents.Text = sr.ReadToEnd();
                sr.Close();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "�ؽ�Ʈ ���� (*.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)

            {


                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(contents.Text); // ���� ����
                sw.Close();




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            contents.Text = string.Empty;
        }
    }
}