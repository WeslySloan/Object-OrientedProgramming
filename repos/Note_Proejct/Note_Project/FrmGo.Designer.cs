namespace NotePad
{
    partial class FrmGo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_LineNumber = new System.Windows.Forms.TextBox();
            this.lbl_LineNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(99, 88);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "이동";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(181, 88);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_LineNumber
            // 
            this.txt_LineNumber.Location = new System.Drawing.Point(14, 43);
            this.txt_LineNumber.Name = "txt_LineNumber";
            this.txt_LineNumber.Size = new System.Drawing.Size(242, 21);
            this.txt_LineNumber.TabIndex = 2;
            // 
            // lbl_LineNumber
            // 
            this.lbl_LineNumber.AutoSize = true;
            this.lbl_LineNumber.Location = new System.Drawing.Point(12, 18);
            this.lbl_LineNumber.Name = "lbl_LineNumber";
            this.lbl_LineNumber.Size = new System.Drawing.Size(62, 12);
            this.lbl_LineNumber.TabIndex = 3;
            this.lbl_LineNumber.Text = "줄 번호(&L)";
            // 
            // FrmGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.lbl_LineNumber);
            this.Controls.Add(this.txt_LineNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGo";
            this.ShowIcon = false;
            this.Text = "줄 이동";
            this.Load += new System.EventHandler(this.FrmGo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_LineNumber;
        private System.Windows.Forms.Label lbl_LineNumber;
    }
}