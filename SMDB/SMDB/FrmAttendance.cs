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
    public partial class FrmAttendance : Form
    {
        private AttendanceService objAttendance = new AttendanceService();
        private StudentService objStudentService = new StudentService();
        public FrmAttendance()
        {
            InitializeComponent();
            //get Attendce studnt 
            this.lblCount.Text = objAttendance.GetAllStudent().ToString();
            ShowStar();

        }

        private void ShowStar()
        {
            this.lblReal.Text = objAttendance.GetAttendStudents(DateTime.Now, true).ToString();
            this.lblAbsenceCount.Text = (Convert.ToInt32(this.lblCount.Text) - Convert.ToInt32(this.lblReal.Text)).ToString();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lblYear.Text = DateTime.Now.Year.ToString();
            this.lblMonth.Text = DateTime.Now.Month.ToString();
            this.lblDay.Text = DateTime.Now.Day.ToString();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.lblWeek.Text = DateTime.Now.DayOfWeek.ToString();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtStuCardNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtStuCardNo.Text.Trim().Length == 0 || e.KeyValue != 13) return;
            //show student info 
            StudentExt objStudentExt = objStudentService.GetStudentByStudentNo(this.txtStuCardNo.Text.Trim());
            if(objStudentExt == null)
            {
                MessageBox.Show("Faile");
                this.txtStuCardNo.SelectAll();
                this.lblStuClass.Text = "";
                this.lblFName.Text = "";
                this.lblLName.Text = "";
                this.pbStu.Image = null;

            }
            else
            {
                this.lblStuClass.Text = objStudentExt.ClassName;
                this.lblFName.Text = objStudentExt.FirstName;
                this.lblLName.Text = objStudentExt.LastName ;
                if(objStudentExt.StuImage!=null && objStudentExt.StuImage.Length != 0)
                {
                    this.pbStu.Image = (Image)new SerializeObjectToString().DeserializeObject(objStudentExt.StuImage);
                }
                else
                {
                    this.pbStu.Image = Image.FromFile("default.jpg");
                }
                string result = objAttendance.AddRecord(this.txtStuCardNo.Text.Trim());
                if (result != "success")
                {
                    this.lblInfo.Text = "Fale ! !";
                    MessageBox.Show(result);
                }
                else
                {
                    this.lblInfo.Text = "success!";
                    ShowStar();
                    this.txtStuCardNo.Text = "";
                    this.txtStuCardNo.Focus();//wait for next student 
                }

                
               
            }


        }
    }
}
