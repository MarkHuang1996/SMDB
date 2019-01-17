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
    public partial class FrmScoreManage : Form
    {
        private ScoreListService objScoreListService = new ScoreListService();
        public FrmScoreManage()
        {
            InitializeComponent();
            //disconnnect the event 
            this.cboClass.SelectedIndexChanged -= new System.EventHandler(this.cboClass_SelectedIndexChanged);
            //initilize the cbobox
            this.cboClass.DataSource = new StudentService().GetAllStudentBySet().Tables[0];
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;
            //connect the event
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            //database
           


        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Class");
                return;
            }
            //ScoList AutoGenerateColumns
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreListService.GetScoreList(this.cboClass.Text);
            //get ScoreInfo
            Dictionary<string, string> dic = objScoreListService.GetScoreInfo(this.cboClass.SelectedIndex.ToString());
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCsharp"];
            this.lblDBAvg.Text = dic["avgDB"];
            this.lblCount.Text = dic["absentCount"];
            //show absentce students
            List<string> list = objScoreListService.GetAbsentList(this.cboClass.SelectedIndex.ToString());
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(list.ToArray());



        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            //ScoList AutoGenerateColumns
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreListService.GetScoreList(null);
            //get ScoreInfo
            Dictionary<string, string> dic = objScoreListService.GetScoreInfo(null);
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCsharp"];
            this.lblDBAvg.Text = dic["avgDB"];
            this.lblCount.Text = dic["absentCount"];
            //show absentce students
            List<string> list = objScoreListService.GetAbsentList(null);
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(list.ToArray());
           
        }
    }
}
