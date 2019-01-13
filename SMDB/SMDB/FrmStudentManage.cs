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
    public partial class FrmStudentManage : Form
    {
        private StudentService objStudentService = new StudentService();
        private StudentClassService objStudentClassService = new StudentClassService();

        List<StudentExt> list = null;
        public FrmStudentManage()
        {
            InitializeComponent();
            this.cboClass.DataSource = objStudentClassService.GetAllClasses();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            list = objStudentService.GetStudentByClassId(this.cboClass.SelectedValue.ToString());
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.DataSource = list;
        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
          
        }

        private void btnNameDESC_Click(object sender, EventArgs e)
        {

            this.list.Sort(new NameDESC());//sort 
            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = list;
        }

        private void btnStuIdDESC_Click(object sender, EventArgs e)
        {
            this.list.Sort(new StudentNoDESC());//sort 
            this.dgvStudentList.DataSource = null;
            this.dgvStudentList.DataSource = list;
        }

        private void btnQueryById_Click(object sender, EventArgs e)
        {
            if (this.txtStudentId.Text.Trim().Length == 0)
            {
                MessageBox.Show("StudentId can't be empty !");
                this.txtStudentId.Focus();
                return;
            }
            StudentExt objStudent = objStudentService.GetStudentByStudentNo(this.txtStudentId.Text.Trim());
            if (objStudent == null)
            {
                MessageBox.Show("Can't find the student !");
                this.txtStudentId.Focus();
                this.txtStudentId.SelectAll();
                return;
            }
            else
            {
                //Create Studentinf form
                FrmStudentInfo objFrmStudentInfo = new FrmStudentInfo(objStudent);
                objFrmStudentInfo.Show();
            }
        }

        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (this.txtStudentId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("StudentId can't be empty !");
                    this.txtStudentId.Focus();
                    return;
                }
                else
                {
                    btnQueryById_Click(null, null);
                }
            }
          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(this.dgvStudentList.RowCount == 0 || this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("Student Info can't be empty !");
                return;
            }

            //get the Student info
            string StudentNo = this.dgvStudentList.CurrentRow.Cells["StudentNo"].Value.ToString();
            StudentExt objStudentExt = objStudentService.GetStudentByStudentNo(StudentNo);
            // using Excel Models 

        }

        private void btnEidt_Click(object sender, EventArgs e)
        {
            if(this.dgvStudentList.CurrentRow == null || this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("Select  a Student");
                return;

            }
            string studentNo = this.dgvStudentList.CurrentRow.Cells["StudentIdNo"].Value.ToString();
            StudentExt objStudentExt = objStudentService.GetStudentByStudentNo(studentNo);
            //show edit from
            FrmEditStudent objFrmEditStudent = new FrmEditStudent(objStudentExt);
            DialogResult result = objFrmEditStudent.ShowDialog();
            if(result == DialogResult.OK)
            {
                btnQuery_Click(null, null);
            }


        }
    }


    class NameDESC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return y.FirstName.CompareTo(x.FirstName);
        }
    }


    class StudentNoDESC : IComparer<StudentExt>
    {
        public int Compare(StudentExt x, StudentExt y)
        {
            return y.StudentIdNo.CompareTo(x.StudentIdNo);
        }
    }
}
