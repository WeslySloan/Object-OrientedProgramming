namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rbKorea = new System.Windows.Forms.RadioButton();
            this.rbChina = new System.Windows.Forms.RadioButton();
            this.rbCanada = new System.Windows.Forms.RadioButton();
            this.rbOthers = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.국적 = new System.Windows.Forms.GroupBox();
            this.성별 = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.국적.SuspendLayout();
            this.성별.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbKorea
            // 
            this.rbKorea.AutoSize = true;
            this.rbKorea.Location = new System.Drawing.Point(6, 30);
            this.rbKorea.Name = "rbKorea";
            this.rbKorea.Size = new System.Drawing.Size(95, 19);
            this.rbKorea.TabIndex = 1;
            this.rbKorea.TabStop = true;
            this.rbKorea.Text = "radioButton1";
            this.rbKorea.UseVisualStyleBackColor = true;
            this.rbKorea.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbChina
            // 
            this.rbChina.AutoSize = true;
            this.rbChina.Location = new System.Drawing.Point(6, 75);
            this.rbChina.Name = "rbChina";
            this.rbChina.Size = new System.Drawing.Size(95, 19);
            this.rbChina.TabIndex = 2;
            this.rbChina.TabStop = true;
            this.rbChina.Text = "radioButton2";
            this.rbChina.UseVisualStyleBackColor = true;
            // 
            // rbCanada
            // 
            this.rbCanada.AutoSize = true;
            this.rbCanada.Location = new System.Drawing.Point(107, 30);
            this.rbCanada.Name = "rbCanada";
            this.rbCanada.Size = new System.Drawing.Size(95, 19);
            this.rbCanada.TabIndex = 3;
            this.rbCanada.TabStop = true;
            this.rbCanada.Text = "radioButton3";
            this.rbCanada.UseVisualStyleBackColor = true;
            this.rbCanada.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbOthers
            // 
            this.rbOthers.AutoSize = true;
            this.rbOthers.Location = new System.Drawing.Point(107, 75);
            this.rbOthers.Name = "rbOthers";
            this.rbOthers.Size = new System.Drawing.Size(95, 19);
            this.rbOthers.TabIndex = 4;
            this.rbOthers.TabStop = true;
            this.rbOthers.Text = "radioButton4";
            this.rbOthers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 국적
            // 
            this.국적.Controls.Add(this.rbKorea);
            this.국적.Controls.Add(this.rbChina);
            this.국적.Controls.Add(this.rbCanada);
            this.국적.Controls.Add(this.rbOthers);
            this.국적.Location = new System.Drawing.Point(66, 147);
            this.국적.Name = "국적";
            this.국적.Size = new System.Drawing.Size(200, 100);
            this.국적.TabIndex = 7;
            this.국적.TabStop = false;
            this.국적.Text = "groupBox1";
            // 
            // 성별
            // 
            this.성별.Controls.Add(this.rbMale);
            this.성별.Controls.Add(this.rbFemale);
            this.성별.Location = new System.Drawing.Point(483, 147);
            this.성별.Name = "성별";
            this.성별.Size = new System.Drawing.Size(200, 108);
            this.성별.TabIndex = 8;
            this.성별.TabStop = false;
            this.성별.Text = "groupBox2";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 53);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(95, 19);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "radioButton6";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(107, 53);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 19);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "radioButton9";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.성별);
            this.Controls.Add(this.국적);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.국적.ResumeLayout(false);
            this.국적.PerformLayout();
            this.성별.ResumeLayout(false);
            this.성별.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private RadioButton rbKorea;
        private RadioButton rbChina;
        private RadioButton rbCanada;
        private RadioButton rbOthers;
        private Button button1;
        private GroupBox 국적;
        private GroupBox 성별;
        private RadioButton rbMale;
        private RadioButton rbFemale;
    }
}