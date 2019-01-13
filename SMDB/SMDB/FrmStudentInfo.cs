using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace SMDB
{
    public partial class FrmStudentInfo : Form
    {

        public FrmStudentInfo(StudentExt objStudentExt)
        {
            InitializeComponent();
            this.lblFName.Text = objStudentExt.FirstName;
            this.lblLName.Text = objStudentExt.LastName;
            this.lblStudentNo.Text = objStudentExt.StudentIdNo.ToString();
            this.lblPhoneNumber.Text = objStudentExt.PhoneNumber;
            this.lblAddress.Text = objStudentExt.Address;
            this.lblBirthday.Text = objStudentExt.Birthday.ToShortDateString();
            this.lblGender.Text = objStudentExt.Gender;
            this.lblClass.Text = objStudentExt.ClassName;
          this.pbStu.Image =   objStudentExt.StuImage.Length == 0 ? Image.FromFile("default.jpg") :
                (Image)new SerializeObjectToString().DeserializeObject(objStudentExt.StuImage);
            

        }


            private void FrmStudentInfo_Load(object sender, EventArgs e)
            {

            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
