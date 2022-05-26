using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class FrmGo : Form
    {
        private int _LineLength;
        private int _CurrentLine;

        public FrmGo()
        {
            InitializeComponent();
        }

        public FrmGo(int intLineLength, int intCurrentLine)
        {
            this._LineLength = intLineLength;
            this._CurrentLine = intCurrentLine;
            InitializeComponent();
        }
        private void btn_Go_Click(object sender, EventArgs e)
        {
            int intMaxLine = Convert.ToInt32(this.txt_LineNumber.Text);

            try
            {                
                if(intMaxLine > this._LineLength)
                {
                    MessageBox.Show(
                          "줄 번호가 범위를 초과 하였습니다."
                        , "메모장"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);

                    return;

                }
                else if(intMaxLine < 1)
                {
                    MessageBox.Show(
                         "줄 번호가 범위를 벗어납니다."
                       , "메모장"
                       , MessageBoxButtons.OK
                       , MessageBoxIcon.Error);

                    return;
                }
            }
            catch
            {
                return;
            }
            finally
            {
                this.Close(); 
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetLine()
        {
            return Convert.ToInt32(this.txt_LineNumber.Text);
        }

        private void FrmGo_Load(object sender, EventArgs e)
        {
            this.txt_LineNumber.Text = this._CurrentLine.ToString();
        }
    }
}
