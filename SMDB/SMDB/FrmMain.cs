using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace SMDB
{
    public partial class FrmMain : Form
    {

        private FrmModifyPwd   objModifyPwd  = null;

        public FrmMain()
        {
            InitializeComponent();
            lblCurrentUser.Text = Program.CurrentAdmin.AdminName + "]";
            this.panel1.BackgroundImage = Image.FromFile("Logo.jpg");
            V
        }

        private void OpenForm(Form objForm)
        {
            objForm.TopLevel = false;//select the form is not top lever;
            objForm.WindowState = FormWindowState.Maximized;
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Parent = this.panel1;
            objForm.Show();
        }
        private void CloseForm()
        {
            foreach (Control item in this.panel1.Controls)
            {
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                    this.panel1.Controls.Remove(item);
                }
            }
        }


        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmAddNewStudent objFrmAddNewStudent = new FrmAddNewStudent();
            OpenForm(objFrmAddNewStudent);
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to Exit the System?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            FrmModifyPwd objPwdChange = new FrmModifyPwd();

            objPwdChange.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


