using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;


namespace SMDB
{
    public partial class FrmModifyPwd : Form
    {
        private AdminService objAdminService = new AdminService();
        public FrmModifyPwd()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //check the old password 
            if (this.txtOldPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the Old password", "erro");
                this.txtOldPwd.Focus();
                return;
            }
            if (this.txtOldPwd.Text.Trim() != Program.CurrentAdmin.LoginPwd.ToString())
            {
                MessageBox.Show(" Old password  incurrect ! ", "erro");
                this.txtOldPwd.Focus();
                this.txtOldPwd.SelectAll();
                return;
            }
            if (this.txtNewPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the new password", "erro");
                this.txtNewPwd.Focus();
                return;
            }
            if (this.txtNewPwd.Text.Trim() != this.txtNewPwdConfirm.Text.Trim())
            {
                MessageBox.Show("Passwords are not same !!", "erro");
                this.txtNewPwd.Focus();
                return;
            }

            //submit the new password
            int result = objAdminService.PsswordChange( Program.CurrentAdmin.LoginId.ToString(),this.txtNewPwd.Text.Trim());
            if (result == 1)
            {
                MessageBox.Show("Password is changed !!", "Tips");
                Program.CurrentAdmin.LoginPwd = this.txtNewPwdConfirm.Text.Trim();
                this.Close();
            }

        }
    }
}
