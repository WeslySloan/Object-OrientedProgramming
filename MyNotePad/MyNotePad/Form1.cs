using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        string filename = "";

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();
            
            filename = openFileDialog1.FileName;

            string Data = System.IO.File.ReadAllText(filename);

            tbContents.Text = Data;
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( filename == "")
            {
                this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                this.saveFileDialog1.ShowDialog();
                           
                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);

                filename = saveFileDialog1.FileName;
            }
            else
            {         
                System.IO.File.WriteAllText(filename, tbContents.Text);
            }

        }

        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            this.saveFileDialog1.ShowDialog();
                       
            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 자동줄바꿈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;

        } 

        private void 글꼴ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;            
        }

        private void 상태표시줄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = 상태표시줄ToolStripMenuItem.Checked;


        }

        private void 메모장정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hinfo f = new Hinfo();
            f.ShowDialog();
        }

        private void tbContents_TextChanged(object sender, EventArgs e)
        {

        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortTimeString();
        }


    }
}
