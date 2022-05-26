using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class DotNetNote : Form
    {
        #region Constructors
        public DotNetNote()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Members
        private bool _IsTextChanged; //텍스트가 변경되었는지 여부
        #endregion

        private void DotNetNote_Load(object sender, EventArgs e)
        {
            //this.saveFileDialog1.ShowDialog();
        }

        #region EventHandlers
        /// <summary>
        /// 파일-새로만들기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miNew_Click(object sender, EventArgs e)
        {
            if(_IsTextChanged)
            {
                SaveOrClearOrCancel("New");
            }
            else
            {
                ClearText();
            }
        }

        /// <summary>
        /// 텍스트가 변경되었을때
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Main_TextChanged(object sender, EventArgs e)
        {
            _IsTextChanged = true; //텍스트 변경 적용
            miUndo.Enabled = true; //취소 메뉴 활성화            

            miCut.Enabled = true; //잘라내기
            miCopy.Enabled = true; // 복사메뉴 활성화
            miDel.Enabled = true; //삭제
            miFind.Enabled = true; //찾기 활성화
            miFindNext.Enabled = true; //다음찾기
            miGo.Enabled = true; //이동 메뉴 활성화

            if (this.txt_Main.SelectedText.Length > 0)
            {
            }



        }

        /// <summary>
        /// 파일-열기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOpen_Click(object sender, EventArgs e)
        {

            if (_IsTextChanged)
            {
                SaveOrClearOrCancel("Open");
            }
            else
            {
                OpenText();
            }
        }

        //파일-저장
        private void miSave_Click(object sender, EventArgs e)
        {
            SaveText(); //저장메서드 호출
        }
        /// <summary>
        /// 파일-다른이름으로저장
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult objDr = saveFileDialog1.ShowDialog();

            if (objDr != DialogResult.Cancel)
            {
                string strFileName = saveFileDialog1.FileName;
                SaveFile(strFileName);
            }
        }

        /// <summary>
        /// 파일-페이지설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miPageSetup_Click(object sender, EventArgs e)
        {
            //[1] PrintDocument.DocumentName = 문서 지정
            printDocument1.DocumentName = txt_Main.Text;

            //[2] PageSetupDialog.Document = PrintDocument
            pageSetupDialog1.Document = this.printDocument1;

            //[3] 페이지 설정 창 띄우기
            pageSetupDialog1.ShowDialog();
        }

        /// <summary>
        /// 파일-인쇄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = txt_Main.Text;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {
                    MessageBox.Show("인쇄하는 도중 에러가 발생하였습니다."
                        , "인쇄 오류"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 페이지 인쇄 이벤트 핸들러
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender
            , System.Drawing.Printing.PrintPageEventArgs e)
        {
            StreamReader objSr = new StreamReader(this.txt_Main.Text);

            //현재 문서의 글꼴과 사이즈
            Font printFont = new Font(
                txt_Main.Font.Name
                , txt_Main.Font.Size);

            float linesPerPage = 0; //페이지의 라인 수
            float yPosition = 0; // 페이지 상단에서 떨어진 위치(문자열 출력)
            int count = 0; // 페이지 줄번호

            float leftMargin = e.MarginBounds.Left; //왼쪽 여백
            float topMargin = e.MarginBounds.Top;   //오른쪽 여백

            string line = null; // 각 행의 데이터 저장
            linesPerPage = e.MarginBounds.Height /
                printFont.GetHeight(e.Graphics);  //페이지 당 줄 라인 수 계산

            while (count < linesPerPage &&
                ((line = objSr.ReadLine()) != null))
            {
                yPosition = topMargin +
                    (count * printFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(
                      line
                    , printFont
                    , Brushes.Black
                    , leftMargin
                    , yPosition
                    , new StringFormat());

                count++;
            }

            if (line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            objSr.Close();

        }

        /// <summary>
        /// 파일-끝내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, EventArgs e)
        {
            if (_IsTextChanged)
            {
                DialogResult objDr = MessageBox.Show(
                    this.Text + " " +
                    "파일의 내용이 변경되었습니다.\r\n변경된 내용을 저장하시겠습니까?"
                    , "메모장"
                    , MessageBoxButtons.YesNoCancel
                    , MessageBoxIcon.Exclamation);

                switch (objDr)
                {
                    case DialogResult.Yes:
                        SaveText();  //텍스트 저장
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                this.Close(); //
                //Application.Exit();
            }
        }

        /// <summary>
        /// 편집-실행취소 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miUndo_Click(object sender, EventArgs e)
        {
            if (this.txt_Main.CanUndo)
            {
                this.txt_Main.Undo();
            }
        }

        /// <summary>
        /// 편집-잘라내기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCut_Click(object sender, EventArgs e)
        {
            //1방법
            //this.txt_Main.Cut();

            //2방법
            Clipboard.SetDataObject(txt_Main.SelectedText);
            txt_Main.SelectedText = String.Empty;
        }

        /// <summary>
        /// 편집-복사메뉴 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCopy_Click(object sender, EventArgs e)
        {
            //this.txt_Main.Copy();

            Clipboard.SetDataObject(txt_Main.SelectedText);

        }

        /// <summary>
        /// 편집-붙여넣기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miPaste_Click(object sender, EventArgs e)
        {
            //this.txt_Main.Paste();

            //[1] 클립보드의 내용이 텍스트 형식인지 검사 후 붙여넣기
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                this.txt_Main.SelectedText =
                    Clipboard.GetDataObject().GetData(DataFormats.Text, true).ToString();
            }
        }

        /// <summary>
        /// 편집-삭제 메뉴 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miDel_Click(object sender, EventArgs e)
        {
            this.txt_Main.SelectedText = String.Empty;
        }

        /// <summary>
        /// 편집-찾기 메뉴 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miFind_Click(object sender, EventArgs e)
        {
            FrmFind f = new FrmFind(this);
            //FrmFind f = new FrmFind();

            f.Show();
        }

        /// <summary>
        /// 편집-다음찾기  FrmFind 메서드 참조해서 나중에 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miFindNext_Click(object sender, EventArgs e)
        {
            miFind_Click(null, null);
        }

        /// <summary>
        /// 편집-바꾸기 메뉴 구현
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miReplace_Click(object sender, EventArgs e)
        {

            FrmReplace f = new FrmReplace(this);
            //FrmFind f = new FrmFind();

            f.Show();
        }

        /// <summary>
        /// 편집-이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miGo_Click(object sender, EventArgs e)
        {
            //전체 라인수
            int intLineLength = txt_Main.Lines.Length;
            
            //현재 라인수
            int intCurrentLine = Library.GetLineAndColumn(this.txt_Main).Line;


            FrmGo go = new FrmGo(intLineLength,intCurrentLine);

            if(go.ShowDialog() == DialogResult.OK)
            {
                int intLineNum = 0;

                if(go.GetLine() != 1)
                {
                    for (int i = 0; i < go.GetLine() - 1; i++)
                    { 
                        intLineNum += txt_Main.Lines[intLineNum].Length + 2;
                    }

                }
                txt_Main.SelectionStart = intLineNum;
                txt_Main.ScrollToCaret();
            }
            go.ShowDialog();
        }

#endregion //

        #region Private Methods
        /// <summary>
        /// 텍스트저장 파일을 저장할지 결정
        /// </summary>
        private void SaveText()
        {
            //새파일일때
            if(this.Text == "제목 없음")
            {
                DialogResult objDr = saveFileDialog1.ShowDialog();

                if(objDr !=  DialogResult.Cancel)
                {
                    string strFileName = saveFileDialog1.FileName;
                    SaveFile(strFileName);

                }
            }
            //기존파일일때
            else
            {
                string strFileName = this.Text; //파일 전체 이름
                SaveFile(strFileName);
            }
        }
        /// <summary>
        /// 실제 파일을 저장하는 메서드
        /// </summary>
        /// <param name="strFileName">저장될 파일의 전체 경로</param>
        private void SaveFile(string strFileName)
        {
            StreamWriter objSw = new StreamWriter(strFileName);

            objSw.Write(this.txt_Main.Text);
            objSw.Flush();
            objSw.Close();

            _IsTextChanged = false;
            this.Text = strFileName; //제목에 파일명 출력
        }

        /// <summary>
        /// 텍스트 박스 리셋
        /// </summary>
        private void ClearText()
        {
            this.txt_Main.ResetText(); //텍스트박스 리셋
            this.Text = "제목 없음";
            _IsTextChanged = false;
        }

        /// <summary>
        /// 저장 또는 텍스트박스 클리어 또는 취소 기능 메서드
        /// </summary>
        private void SaveOrClearOrCancel(string strFlag)
        {
            if (_IsTextChanged)
            {
                DialogResult objDr = MessageBox.Show(
                    this.Text + " " +
                    "파일의 내용이 변경되었습니다.\r\n변경된 내용을 저장하시겠습니까?"
                    , "메모장"
                    , MessageBoxButtons.YesNoCancel
                    , MessageBoxIcon.Exclamation);

                switch (objDr)
                {
                    case DialogResult.Yes:
                        SaveText();  //텍스트 저장

                        if (strFlag.Equals("New"))
                            ClearText(); //텍스트 클리어(리셋)
                        else
                            OpenText();

                        break;
                    case DialogResult.No:
                        if (strFlag.Equals("New"))
                            ClearText(); //텍스트 클리어(리셋)
                        else
                            OpenText();  //열기

                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                ClearText();
            }
        }

        //열기 기능 메서드
        private void OpenText()
        {
            DialogResult objDr = openFileDialog1.ShowDialog();

            if (objDr != DialogResult.Cancel)
            {
                string strFileName = openFileDialog1.FileName;
                StreamReader objSr = new StreamReader(strFileName);

                this.txt_Main.Text = objSr.ReadToEnd();
                objSr.Close();

                _IsTextChanged = false;
                this.Text = strFileName;
            }
        }
        #endregion


        /// <summary>
        /// 편집-전체선택
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSelectAll_Click(object sender, EventArgs e)
        {
            this.txt_Main.SelectAll();
        }

        /// <summary>
        /// 편집-시간날짜 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miTimeDate_Click(object sender, EventArgs e)
        {
            this.txt_Main.SelectedText = String.Format(@"{0} {1}"
                ,DateTime.Now.ToShortTimeString()
                ,DateTime.Now.ToShortDateString());
        }

        /// <summary>
        /// 서식-자동 줄 바꿈 메뉴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miWordWrap_Click(object sender, EventArgs e)
        {
            this.txt_Main.WordWrap = !(this.txt_Main.WordWrap);
            this.miWordWrap.Checked = !(this.miWordWrap.Checked);
        }


        /// <summary>
        /// 서식-글꼴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                txt_Main.Font = fontDialog1.Font;
        }

        /// <summary>
        /// 보기-상태표시줄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miStatus_Click(object sender, EventArgs e)
        {
            if(this.statusStrip1.Visible)
            {
                this.statusStrip1.Visible = false;
                this.miStatus.Checked = false;
            }
            else
            {
                this.statusStrip1.Visible = true;
                this.miStatus.Checked = true;
                int intLine = Library.GetLineAndColumn(txt_Main).Line;
                int intColumn = Library.GetLineAndColumn(txt_Main).Column;

                string strMsg = String.Format(@"Ln {0}, Col {1}"
                    , intLine
                    , intColumn);

                this.toolStripStatusLabel2.Text = strMsg;
            }
        }

        private void txt_Main_KeyUp(object sender, KeyEventArgs e)
        {
            StatusLineColumn();
        }

        private void txt_Main_MouseClick(object sender, MouseEventArgs e)
        {
            StatusLineColumn();
        }

        private void StatusLineColumn()
        {
            int intLine = Library.GetLineAndColumn(txt_Main).Line;
            int intColumn = Library.GetLineAndColumn(txt_Main).Column;

            string strMsg = String.Format(@"Ln {0}, Col {1}"
                , intLine
                , intColumn);

            this.toolStripStatusLabel2.Text = strMsg;
        }

        /// <summary>
        /// 도움말 항목 메뉴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miHelp_Click(object sender, EventArgs e)
        {
            // 시스템(Windows) 디렉터리

            string strDirectory = System.Environment.SystemDirectory;

            //한단계 상위 경로 폴더 뽑아내기
            strDirectory = strDirectory.Substring(0, strDirectory.LastIndexOf("\\"));

            // Help 폴더 안의 Notepad.chm 파일경로
            strDirectory += @"\Help\Notepad.chm";

            // 파일이 있는지 확인 후 도움말 띄우기
            // Windows7은 없음 확인
            if(System.IO.File.Exists(strDirectory))
            {
                System.Windows.Forms.Help.ShowHelp(this, strDirectory);
            }
            else
            {
                MessageBox.Show(
                      strDirectory + "에 도움말 파일이 없습니다."
                    , "메모장"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// 도움말-메모장 정보 메뉴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miAbout_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }


        

        

         

        

       
    }
}
