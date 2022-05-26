namespace NotePad
{
    partial class DotNetNote
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.miPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miCut = new System.Windows.Forms.ToolStripMenuItem();
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.miDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.miFind = new System.Windows.Forms.ToolStripMenuItem();
            this.miFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.miReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.miGo = new System.Windows.Forms.ToolStripMenuItem();
            this.miSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.miTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.miWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.miFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.miStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnMainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMainMenu
            // 
            this.mnMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFont,
            this.mnuView,
            this.mnuHelp});
            this.mnMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnMainMenu.Name = "mnMainMenu";
            this.mnMainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.mnMainMenu.Size = new System.Drawing.Size(730, 25);
            this.mnMainMenu.TabIndex = 0;
            this.mnMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.miSeparator,
            this.miPageSetup,
            this.miPrint,
            this.toolStripMenuItem2,
            this.miExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(57, 19);
            this.mnuFile.Text = "파일(&F)";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.miNew.Size = new System.Drawing.Size(203, 22);
            this.miNew.Text = "새로만들기(&N)";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.miOpen.Size = new System.Drawing.Size(203, 22);
            this.miOpen.Text = "열기(&O)...";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.miSave.Size = new System.Drawing.Size(203, 22);
            this.miSave.Text = "저장(&S)";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(203, 22);
            this.miSaveAs.Text = "다른 이름으로 저장(&A)...";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // miSeparator
            // 
            this.miSeparator.Name = "miSeparator";
            this.miSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // miPageSetup
            // 
            this.miPageSetup.Name = "miPageSetup";
            this.miPageSetup.Size = new System.Drawing.Size(203, 22);
            this.miPageSetup.Text = "페이지 설정(&U)...";
            this.miPageSetup.Click += new System.EventHandler(this.miPageSetup_Click);
            // 
            // miPrint
            // 
            this.miPrint.Name = "miPrint";
            this.miPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.miPrint.Size = new System.Drawing.Size(203, 22);
            this.miPrint.Text = "인쇄(&P)...";
            this.miPrint.Click += new System.EventHandler(this.miPrint_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(203, 22);
            this.miExit.Text = "끝내기(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUndo,
            this.toolStripMenuItem3,
            this.miCut,
            this.miCopy,
            this.miPaste,
            this.miDel,
            this.toolStripMenuItem4,
            this.miFind,
            this.miFindNext,
            this.miReplace,
            this.miGo,
            this.miSelectAll,
            this.miTimeDate});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(57, 19);
            this.mnuEdit.Text = "편집(&E)";
            // 
            // miUndo
            // 
            this.miUndo.Enabled = false;
            this.miUndo.Name = "miUndo";
            this.miUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.miUndo.Size = new System.Drawing.Size(184, 22);
            this.miUndo.Text = "실행 취소(&U)";
            this.miUndo.Click += new System.EventHandler(this.miUndo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 6);
            // 
            // miCut
            // 
            this.miCut.Enabled = false;
            this.miCut.Name = "miCut";
            this.miCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.miCut.Size = new System.Drawing.Size(184, 22);
            this.miCut.Text = "잘라 내기(&T)";
            this.miCut.Click += new System.EventHandler(this.miCut_Click);
            // 
            // miCopy
            // 
            this.miCopy.Enabled = false;
            this.miCopy.Name = "miCopy";
            this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miCopy.Size = new System.Drawing.Size(184, 22);
            this.miCopy.Text = "복사(&C)";
            this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
            // 
            // miPaste
            // 
            this.miPaste.Name = "miPaste";
            this.miPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.miPaste.Size = new System.Drawing.Size(184, 22);
            this.miPaste.Text = "붙여넣기(&P)";
            this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
            // 
            // miDel
            // 
            this.miDel.Enabled = false;
            this.miDel.Name = "miDel";
            this.miDel.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.miDel.Size = new System.Drawing.Size(184, 22);
            this.miDel.Text = "삭제(&L)";
            this.miDel.Click += new System.EventHandler(this.miDel_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 6);
            // 
            // miFind
            // 
            this.miFind.Enabled = false;
            this.miFind.Name = "miFind";
            this.miFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.miFind.Size = new System.Drawing.Size(184, 22);
            this.miFind.Text = "찾기(&F)...";
            this.miFind.Click += new System.EventHandler(this.miFind_Click);
            // 
            // miFindNext
            // 
            this.miFindNext.Enabled = false;
            this.miFindNext.Name = "miFindNext";
            this.miFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.miFindNext.Size = new System.Drawing.Size(184, 22);
            this.miFindNext.Text = "다음 찾기(&N)";
            this.miFindNext.Click += new System.EventHandler(this.miFindNext_Click);
            // 
            // miReplace
            // 
            this.miReplace.Name = "miReplace";
            this.miReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.miReplace.Size = new System.Drawing.Size(184, 22);
            this.miReplace.Text = "바꾸기(&R)...";
            this.miReplace.Click += new System.EventHandler(this.miReplace_Click);
            // 
            // miGo
            // 
            this.miGo.Enabled = false;
            this.miGo.Name = "miGo";
            this.miGo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.miGo.Size = new System.Drawing.Size(184, 22);
            this.miGo.Text = "이동(&G)...";
            this.miGo.Click += new System.EventHandler(this.miGo_Click);
            // 
            // miSelectAll
            // 
            this.miSelectAll.Name = "miSelectAll";
            this.miSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.miSelectAll.Size = new System.Drawing.Size(184, 22);
            this.miSelectAll.Text = "모두 선택(&A)";
            this.miSelectAll.Click += new System.EventHandler(this.miSelectAll_Click);
            // 
            // miTimeDate
            // 
            this.miTimeDate.Name = "miTimeDate";
            this.miTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.miTimeDate.Size = new System.Drawing.Size(184, 22);
            this.miTimeDate.Text = "시간/날짜(&D)";
            this.miTimeDate.Click += new System.EventHandler(this.miTimeDate_Click);
            // 
            // mnuFont
            // 
            this.mnuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miWordWrap,
            this.miFont});
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(60, 19);
            this.mnuFont.Text = "서식(&O)";
            // 
            // miWordWrap
            // 
            this.miWordWrap.Checked = true;
            this.miWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miWordWrap.Name = "miWordWrap";
            this.miWordWrap.Size = new System.Drawing.Size(161, 22);
            this.miWordWrap.Text = "자동 줄 바꿈(&W)";
            this.miWordWrap.Click += new System.EventHandler(this.miWordWrap_Click);
            // 
            // miFont
            // 
            this.miFont.Name = "miFont";
            this.miFont.Size = new System.Drawing.Size(161, 22);
            this.miFont.Text = "글꼴(&F)...";
            this.miFont.Click += new System.EventHandler(this.miFont_Click);
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miStatus});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(59, 19);
            this.mnuView.Text = "보기(&V)";
            // 
            // miStatus
            // 
            this.miStatus.Name = "miStatus";
            this.miStatus.Size = new System.Drawing.Size(149, 22);
            this.miStatus.Text = "상태표시줄(&S)";
            this.miStatus.Click += new System.EventHandler(this.miStatus_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.toolStripMenuItem5,
            this.miAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(72, 19);
            this.mnuHelp.Text = "도움말(&H)";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(155, 22);
            this.miHelp.Text = "도움말 보기(&H)";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 6);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(155, 22);
            this.miAbout.Text = "메모장 정보(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // txt_Main
            // 
            this.txt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Main.Location = new System.Drawing.Point(0, 25);
            this.txt_Main.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Main.Size = new System.Drawing.Size(730, 606);
            this.txt_Main.TabIndex = 1;
            this.txt_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Main_MouseClick);
            this.txt_Main.TextChanged += new System.EventHandler(this.txt_Main_TextChanged);
            this.txt_Main.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Main_KeyUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.txt";
            this.openFileDialog1.Filter = "텍스트 문서(.txt)|*.txt|모든 파일|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "*.txt";
            this.saveFileDialog1.Filter = "텍스트 문서(.txt)|*.txt|모든 파일|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 609);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(648, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel2.Text = "Ln 1, Col 1";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DotNetNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 631);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_Main);
            this.Controls.Add(this.mnMainMenu);
            this.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.mnMainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DotNetNote";
            this.Text = "제목 없음";
            this.Load += new System.EventHandler(this.DotNetNote_Load);
            this.mnMainMenu.ResumeLayout(false);
            this.mnMainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region controls
        private System.Windows.Forms.MenuStrip mnMainMenu;
        public System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripMenuItem miPageSetup;
        private System.Windows.Forms.ToolStripMenuItem miPrint;
        private System.Windows.Forms.ToolStripSeparator miSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miCut;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
        private System.Windows.Forms.ToolStripMenuItem miPaste;
        private System.Windows.Forms.ToolStripMenuItem miDel;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem miFind;
        private System.Windows.Forms.ToolStripMenuItem miFindNext;
        private System.Windows.Forms.ToolStripMenuItem miReplace;
        private System.Windows.Forms.ToolStripMenuItem miGo;
        private System.Windows.Forms.ToolStripMenuItem miSelectAll;
        private System.Windows.Forms.ToolStripMenuItem miTimeDate;
        private System.Windows.Forms.ToolStripMenuItem miWordWrap;
        private System.Windows.Forms.ToolStripMenuItem miFont;
        private System.Windows.Forms.ToolStripMenuItem miStatus;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

    }
}

