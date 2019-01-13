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
using Models;


namespace SMDB
{
    
    public partial class FrmEditStudent : Form
    {
        private StudentClassService objStudentClassService = new StudentClassService();
        private StudentService objStudentService = new StudentService();

        public FrmEditStudent(StudentExt objStudentExt)
        {
            InitializeComponent();
            this.cboClassName.DataSource = objStudentClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            




            this.txtFName.Text = objStudentExt.FirstName;
            this.txtLName.Text = objStudentExt.LastName;
            this.txtStudentNo.Text = objStudentExt.StudentIdNo.ToString();
            this.txtStudentNo.Enabled = false;
            this.txtPhoneNumber.Text = objStudentExt.PhoneNumber;
            this.txtAddress.Text = objStudentExt.Address;
            this.dateTimePicker1.Text = objStudentExt.Birthday.ToShortDateString();
            if (objStudentExt.Gender == "Male")
            {
                rdoMale.Checked = true;
            }

            else rdoFemale.Checked = true;
            this.cboClassName.Text = objStudentExt.ClassName;
            this.pbStu.Image = objStudentExt.StuImage.Length == 0 ? Image.FromFile("default.jpg") :
                  (Image)new SerializeObjectToString().DeserializeObject(objStudentExt.StuImage);
        }

       
        private void FrmEditStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFileDialog = new OpenFileDialog();
            DialogResult result = objOpenFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objOpenFileDialog.FileName);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Student objStudent = new Student()
            {
                StudentIdNo = Convert.ToInt32(this.txtStudentNo.Text.Trim()),
                FirstName = this.txtFName.Text.Trim(),
                LastName = this.txtLName.Text.Trim(),
                Gender = rdoFemale.Checked ? "Female" : "Male",
                Birthday = Convert.ToDateTime(this.dateTimePicker1.Text),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dateTimePicker1.Text).Year,
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                Address = this.txtAddress.Text.Trim(),
                StuImage = this.pbStu.Image == null ? "" : new SerializeObjectToString().SerializeObject(this.pbStu.Image)

            };
            try
            {
                int result = objStudentService.EditStudentInfo(objStudent);
                if(result == 1)
                {
                    MessageBox.Show("Update Successful !!");
                }
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
    }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
