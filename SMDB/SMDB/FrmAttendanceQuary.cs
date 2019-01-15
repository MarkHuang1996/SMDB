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
    
    public partial class FrmAttendanceQuary : Form
    {
        private AttendanceService objAttendanceService = new AttendanceService();
        public FrmAttendanceQuary()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime d1 = Convert.ToDateTime(this.dtpTime.Text);
            DateTime d2 = d1.AddDays(1.0);
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.DataSource = objAttendanceService.GetStudentsByDate(d1, d2, this.txtName.Text.Trim());
            //Style of the list
            new DataGridViewStyle().DgvStyle3(this.dgvStudentList);
            //show count of students
            this.lblCount.Text = objAttendanceService.GetAllStudent().ToString();
            this.lblReal.Text = objAttendanceService.GetAttendStudents(Convert.ToDateTime(this.dtpTime.Text), false).ToString();
            this.label13.Text = (Convert.ToInt32(this.lblCount.Text) - Convert.ToInt32(this.lblReal.Text)).ToString();

        }

        private void dgvStudentList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewStyle.DgvRowPostPaint(this.dgvStudentList,e);
        }
    }
}
