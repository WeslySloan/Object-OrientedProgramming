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
    public partial class FrmReplace : Form
    {
        public FrmReplace()
        {
            InitializeComponent();
        }

        private DotNetNote dnn = null; //메인 폼을 가리키는 객체

        public FrmReplace(DotNetNote objDotNetNote)
        {
            dnn = objDotNetNote;
            InitializeComponent();
        }

        private void FrmReplace_Load(object sender, EventArgs e)
        {
            txt_Find.Focus();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(
                    this.txt_Find.Text + "을(를) 찾을 수 없습니다."
                    , "메모장"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
            }
        }

        /// <summary>
        /// 찾기 전용 메서드 : 찾지 못하면 false
        /// </summary>
        private bool FindText()
        {
            int nFind;
            int nLen;
            string strTempText;
            string strTempFind;

            if (chk_Case.Checked)
            {
                strTempText = dnn.txt_Main.Text; //찾을 대상
                strTempFind = txt_Find.Text; //찾을 단어
            }
            else
            {
                strTempText = dnn.txt_Main.Text.ToLower(); //소문자
                strTempFind = txt_Find.Text.ToLower(); //소문자
            }

            nLen = txt_Find.Text.Length; //텍스트 길이

            //위로 / 아래로 검색
            if (rdo_Up.Checked)
            {
                if ((dnn.txt_Main.SelectionStart - dnn.txt_Main.SelectionLength) < 0)
                    nFind = -1;
                else
                    nFind = strTempText.LastIndexOf(
                        strTempFind
                        , dnn.txt_Main.SelectionStart
                          - dnn.txt_Main.SelectionLength
                          );
            }
            else // 아래로
            {
                nFind = strTempText.IndexOf(
                    strTempFind
                    , dnn.txt_Main.SelectionStart
                      + dnn.txt_Main.SelectionLength);

            }

            if (nFind == -1)
                return false;
            else
            {
                dnn.txt_Main.SelectionStart = nFind;
                dnn.txt_Main.SelectionLength = nLen;
                dnn.txt_Main.Focus();
                return true;
            }
        }

        /// <summary>
        /// 바꾸기 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Replace_Click(object sender, EventArgs e)
        {
            if (!FindText())
            {
                MessageBox.Show(
                    this.txt_Find.Text + "을(를) 찾을 수 없습니다."
                    , "메모장"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    );
            }
            else
            {
                //텍스트 변경
                dnn.txt_Main.SelectedText = this.txt_Replace.Text;
                dnn.txt_Main.SelectionStart =
                    dnn.txt_Main.SelectionStart - txt_Replace.Text.Length;

                dnn.txt_Main.SelectionLength = txt_Replace.Text.Length;
            }
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            while(FindText())
            {
                dnn.txt_Main.SelectedText = this.txt_Replace.Text;
            }
        }

        private void Find_TextChanged(object sender, EventArgs e)
        {
            this.btn_Find.Enabled = true;
            this.btn_Replace.Enabled = true;
            this.btn_ReplaceAll.Enabled = true;
        }

        
    }
}
