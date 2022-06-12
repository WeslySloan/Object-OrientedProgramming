namespace poll
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelQ = new System.Windows.Forms.Panel();
            this.Panel_Result = new System.Windows.Forms.Panel();
            this.GB_Hobby = new System.Windows.Forms.GroupBox();
            this.GB_Singer = new System.Windows.Forms.GroupBox();
            this.Label_Hobby = new System.Windows.Forms.Label();
            this.Label_Singer = new System.Windows.Forms.Label();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.btnPoll = new System.Windows.Forms.Button();
            this.PanelQ.SuspendLayout();
            this.Panel_Result.SuspendLayout();
            this.GB_Hobby.SuspendLayout();
            this.GB_Singer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelQ
            // 
            this.PanelQ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelQ.Controls.Add(this.btnPoll);
            this.PanelQ.Controls.Add(this.GB_Singer);
            this.PanelQ.Controls.Add(this.GB_Hobby);
            this.PanelQ.Location = new System.Drawing.Point(1, 0);
            this.PanelQ.Name = "PanelQ";
            this.PanelQ.Size = new System.Drawing.Size(418, 248);
            this.PanelQ.TabIndex = 0;
            // 
            // Panel_Result
            // 
            this.Panel_Result.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Panel_Result.Controls.Add(this.Label_Singer);
            this.Panel_Result.Controls.Add(this.Label_Hobby);
            this.Panel_Result.Location = new System.Drawing.Point(6, 254);
            this.Panel_Result.Name = "Panel_Result";
            this.Panel_Result.Size = new System.Drawing.Size(413, 106);
            this.Panel_Result.TabIndex = 1;
            this.Panel_Result.Paint += new System.Windows.Forms.PaintEventHandler(this.result_Paint);
            // 
            // GB_Hobby
            // 
            this.GB_Hobby.Controls.Add(this.RB2);
            this.GB_Hobby.Controls.Add(this.RB1);
            this.GB_Hobby.Location = new System.Drawing.Point(24, 12);
            this.GB_Hobby.Name = "GB_Hobby";
            this.GB_Hobby.Size = new System.Drawing.Size(366, 82);
            this.GB_Hobby.TabIndex = 0;
            this.GB_Hobby.TabStop = false;
            this.GB_Hobby.Text = "취미는?";
            // 
            // GB_Singer
            // 
            this.GB_Singer.Controls.Add(this.CB2);
            this.GB_Singer.Controls.Add(this.CB1);
            this.GB_Singer.Location = new System.Drawing.Point(24, 115);
            this.GB_Singer.Name = "GB_Singer";
            this.GB_Singer.Size = new System.Drawing.Size(366, 82);
            this.GB_Singer.TabIndex = 1;
            this.GB_Singer.TabStop = false;
            this.GB_Singer.Text = "좋아하는 가수?";
            this.GB_Singer.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Label_Hobby
            // 
            this.Label_Hobby.AutoSize = true;
            this.Label_Hobby.Location = new System.Drawing.Point(29, 23);
            this.Label_Hobby.Name = "Label_Hobby";
            this.Label_Hobby.Size = new System.Drawing.Size(74, 18);
            this.Label_Hobby.TabIndex = 0;
            this.Label_Hobby.Text = "취미는 :";
            // 
            // Label_Singer
            // 
            this.Label_Singer.AutoSize = true;
            this.Label_Singer.Location = new System.Drawing.Point(29, 60);
            this.Label_Singer.Name = "Label_Singer";
            this.Label_Singer.Size = new System.Drawing.Size(74, 18);
            this.Label_Singer.TabIndex = 1;
            this.Label_Singer.Text = "가수는 :";
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Location = new System.Drawing.Point(30, 39);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(105, 22);
            this.RB1.TabIndex = 0;
            this.RB1.TabStop = true;
            this.RB1.Text = "음악감상";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(199, 39);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(69, 22);
            this.RB2.TabIndex = 1;
            this.RB2.TabStop = true;
            this.RB2.Text = "게임";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Location = new System.Drawing.Point(30, 42);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(88, 22);
            this.CB1.TabIndex = 0;
            this.CB1.Text = "이하이";
            this.CB1.UseVisualStyleBackColor = true;
            this.CB1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(199, 42);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(88, 22);
            this.CB2.TabIndex = 1;
            this.CB2.Text = "김광석";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // btnPoll
            // 
            this.btnPoll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoll.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPoll.Location = new System.Drawing.Point(305, 203);
            this.btnPoll.Name = "btnPoll";
            this.btnPoll.Size = new System.Drawing.Size(85, 34);
            this.btnPoll.TabIndex = 2;
            this.btnPoll.Text = "제출";
            this.btnPoll.UseVisualStyleBackColor = true;
            this.btnPoll.Click += new System.EventHandler(this.btnPoll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 360);
            this.Controls.Add(this.Panel_Result);
            this.Controls.Add(this.PanelQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "설문조사";
            this.PanelQ.ResumeLayout(false);
            this.Panel_Result.ResumeLayout(false);
            this.Panel_Result.PerformLayout();
            this.GB_Hobby.ResumeLayout(false);
            this.GB_Hobby.PerformLayout();
            this.GB_Singer.ResumeLayout(false);
            this.GB_Singer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelQ;
        private System.Windows.Forms.GroupBox GB_Hobby;
        private System.Windows.Forms.Panel Panel_Result;
        private System.Windows.Forms.GroupBox GB_Singer;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.Label Label_Singer;
        private System.Windows.Forms.Label Label_Hobby;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.Button btnPoll;
        private System.Windows.Forms.CheckBox CB2;
    }
}

