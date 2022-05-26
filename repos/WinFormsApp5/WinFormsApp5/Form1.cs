//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Open_Click(object sender, EventArgs e)
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

        //private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        //{

        //}



        //private void Reset_Click(object sender, EventArgs e)
        //{
        //    contents.Text = string.Empty;
        //}





        //private void Save_Click(object sender, EventArgs e)
        //{

        //    SaveFileDialog sfd = new SaveFileDialog();

        //    sfd.Filter = "�ؽ�Ʈ ���� (*.txt) | *.txt";

        //    if (sfd.ShowDialog() == DialogResult.OK)

        //    {


        //        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

        //        StreamWriter sw = new StreamWriter(fs);

        //        sw.WriteLine(contents.Text); // ���� ����
        //        sw.Close();




        //    }


    }


    }
}