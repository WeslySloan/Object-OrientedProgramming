namespace MyNotePad
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메모장정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbContents = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기(&N)";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.열기ToolStripMenuItem.Text = "열기(&O)";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.저장ToolStripMenuItem.Text = "저장(&S)";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장(&A)";
            this.다른이름으로저장ToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기(X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈ToolStripMenuItem,
            this.글꼴ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식ToolStripMenuItem.Text = "서식(&O)";
            // 
            // 자동줄바꿈ToolStripMenuItem
            // 
            this.자동줄바꿈ToolStripMenuItem.Name = "자동줄바꿈ToolStripMenuItem";
            this.자동줄바꿈ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.자동줄바꿈ToolStripMenuItem.Text = "자동 줄바꿈";
            this.자동줄바꿈ToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈ToolStripMenuItem_Click);
            // 
            // 글꼴ToolStripMenuItem
            // 
            this.글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            this.글꼴ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.글꼴ToolStripMenuItem.Text = "글꼴";
            this.글꼴ToolStripMenuItem.Click += new System.EventHandler(this.글꼴ToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상태표시줄ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.보기ToolStripMenuItem.Text = "보기(&V)";
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            this.상태표시줄ToolStripMenuItem.Checked = true;
            this.상태표시줄ToolStripMenuItem.CheckOnClick = true;
            this.상태표시줄ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            this.상태표시줄ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.상태표시줄ToolStripMenuItem.Text = "상태 표시줄";
            this.상태표시줄ToolStripMenuItem.Click += new System.EventHandler(this.상태표시줄ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메모장정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // 메모장정보ToolStripMenuItem
            // 
            this.메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            this.메모장정보ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.메모장정보ToolStripMenuItem.Text = "메모장 정보";
            this.메모장정보ToolStripMenuItem.Click += new System.EventHandler(this.메모장정보ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel1.Text = "만든이 : 김현수";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(240, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // tbContents
            // 
            this.tbContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContents.Location = new System.Drawing.Point(0, 24);
            this.tbContents.Multiline = true;
            this.tbContents.Name = "tbContents";
            this.tbContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContents.Size = new System.Drawing.Size(466, 394);
            this.tbContents.TabIndex = 2;
            this.tbContents.WordWrap = false;
            this.tbContents.TextChanged += new System.EventHandler(this.tbContents_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 440);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox tbContents;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

