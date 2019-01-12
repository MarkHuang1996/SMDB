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
    public partial class FrmAddNewStudent : Form
    {
        private StudentService objStudentService = new StudentService();
        private StudentClassService objStudentClassService = new StudentClassService();
        public FrmAddNewStudent()
        {
            InitializeComponent();
            //cboBOX
            this.cboClassName.DataSource = objStudentClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoseImage_Click(object sender, EventArgs e)
        {

            //Student Image Choose
            OpenFileDialog objFileDialog = new OpenFileDialog();
            DialogResult result = objFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pbStu.Image = Image.FromFile(objFileDialog.FileName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region Data Not Empty Validate

            if (this.txtFName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the Student First Name");
                this.txtFName.Focus();
                return;
            }
            if (this.txtLName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the Student Last Name");
                this.txtLName.Focus();
                return;
            }
            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("Select the Student Gender");
                return;
            }
            if (DateTime.Now.Year - Convert.ToDateTime(this.dateTimePicker1.Text).Year < 16)
            {
                MessageBox.Show("Student age cant beyond  16");
                this.dateTimePicker1.Focus();
                return;
            }
            if (this.cboClassName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Class !");

                return;
            }
            if (this.txtStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student ID can't  empty");
                this.txtStudentId.Focus();
                return;
            }
            if (this.txtPhoneNumber.Text.Trim().Length == 0)
            {
                MessageBox.Show("PhoneNumber can't  empty");
                this.txtPhoneNumber.Focus();
                return;
            }


            #endregion
            #region Data Format Validate
            if (!DataValidate.IsIdentityStudentID(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("StudentId Must have 10 figures");
                this.txtStudentId.Focus();
                return;
            }

            #endregion

            //Judge the StudentIsExisted

            if (this.objStudentService.IsStudentIDExitsed(this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("StudentId Existed ,Please entry different StudentId ");
                this.txtStudentId.Focus();
                return;
            }


            //encapsulation

            Student objStudent = new Student()
            {
                FirstName = this.txtFName.Text.Trim(),
                LastName = this.txtLName.Text.Trim(),
                Gender = rdoMale.Checked ? "Male" : "Female",
                Birthday = Convert.ToDateTime(this.dateTimePicker1.Text),
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dateTimePicker1.Text).Year,
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),
                StudentIdNo = Convert.ToInt32(this.txtStudentId.Text.Trim()),
                PhoneNumber = this.txtPhoneNumber.Text.Trim(),
                Address = this.txtAddress.Text.Trim(),
                StuImage = this.pbStu.Image == null ? "" : new Common.SerializeObjectToString().SerializeObject(this.pbStu.Image)
            };
            try
            {
                int result = objStudentService.AddStudent(objStudent);
                if (result == 1)
                {
                    DialogResult dresult = MessageBox.Show("Add Successful ! keep going ?", "other Studnet ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dresult == DialogResult.OK)
                    {
                        //clean controls in groupbox
                        foreach (Control item in this.gbStudentInfo.Controls)
                        {
                            if (item is TextBox)
                            {
                                item.Text = "";
                            }
                            else if (item is RadioButton)
                            {
                                ((RadioButton)item).Checked = false;

                            }
                            else if (item is ComboBox)
                            {
                                ((ComboBox)item).SelectedIndex = -1;
                            }
                        }
                        this.pbStu.Image = null;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
