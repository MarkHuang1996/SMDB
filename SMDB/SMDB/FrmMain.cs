using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDB
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.lblCurrentUser.Text = Program.CurrentAdmin.AdminName + " ]";
            this.panel1.BackgroundImage = Image.FromFile("Logo.jpg");
            
        }

        private void OpenForm(Form objForm)
        {
            objForm.TopLevel = false;
            objForm.WindowState = FormWindowState.Maximized;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Parent = this.panel1;
            objForm.Show();
            
        }
        private void CloseForm()
        {
            //check controls in panel
            foreach (Control item in this.panel1.Controls)
            {
                if(item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                    this.panel1.Controls.Remove(item);
                }

            }
        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmAddNewStudent objFrmAddNewStudent = new FrmAddNewStudent();
            this.OpenForm(objFrmAddNewStudent);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmStudentManage objFrmStudentManage = new FrmStudentManage();
            this.OpenForm(objFrmStudentManage);
        }

        private void attenceCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmAttendance objFrmAttendance = new FrmAttendance();
            this.OpenForm(objFrmAttendance);
        }

        private void attendanceQuaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmAttendanceQuary objFrmAttendanceQuary = new FrmAttendanceQuary();
            this.OpenForm(objFrmAttendanceQuary);
        }

        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmScoreManage objFrmScoreManage = new FrmScoreManage();
            this.OpenForm(objFrmScoreManage);
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {
            this.CloseForm();
            FrmScoreQuary frmScoreQuary = new FrmScoreQuary();
            this.OpenForm(frmScoreQuary);
        }
    }
}
