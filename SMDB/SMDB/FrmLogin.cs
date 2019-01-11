using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace SMDB
{
    public partial class FrmLogin : Form
    {
        private AdminService objAdminService = new AdminService();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //data validation

            //1.id validation
            if(this.txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show(" Please enter your  UserId ", "Tips");
                this.txtLoginId.Focus();
                return;
            }

            
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show(" Please enter your  Pssword ", "Tips");
                this.txtLoginPwd.Focus();
                return;
            }

            //Create Admin object
            Admin objAdmin = new Admin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };
            //submit user info
            try
            {
                objAdmin = objAdminService.AdminLogin(objAdmin);
                if(objAdmin == null)
                {
                    MessageBox.Show(" user  id or password is incorrect. Please try again");
                    this.txtLoginId.Focus();
                }
                else
                {
                  
                    Program.CurrentAdmin = objAdmin;  //save the user information
                    this.DialogResult = DialogResult.OK;//select a massage for successful login 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Login failed !!");
            }

        }


    }
}
