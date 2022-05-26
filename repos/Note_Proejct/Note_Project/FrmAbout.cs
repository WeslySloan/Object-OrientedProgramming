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
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            //현재 프로젝트에서 사용되는 아이콘
            this.picIcon.Image = this.Icon.ToBitmap();

            this.lbl_Name.Text = SystemInformation.UserName;
            this.lbl_ComputerName.Text = SystemInformation.ComputerName;
            this.lbl_Version.Text = Application.ProductVersion.ToString();
        }


        /// <summary>
        /// 도움말-메모장 정보
        /// 윈도우 7은 Eula.txt파일 없네
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linLbl_Eula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(
                    System.Environment.SystemDirectory + @"\Eula.txt");
            }
            catch
            {
                
            }
        }
    }
}
