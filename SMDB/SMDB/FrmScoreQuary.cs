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
    public partial class FrmScoreQuary : Form
    {
        private ScoreListService objScoreListService = new ScoreListService();
        private DataSet ds = null;//

        public FrmScoreQuary()
        {
            InitializeComponent();
            this.cboClass.DataSource = new StudentService().GetAllStudentBySet().Tables[0];
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;

            ds = objScoreListService.GetAllScoreBySet();
            this.dgvScoreList.DataSource = ds.Tables[0];
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ds  == null) return;
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName = '" + this.cboClass.Text.Trim() + "'";
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (ds == null || this.txtScore.Text.Trim().Length == 0) return;
            if (!DataValidate.IsInteger(this.txtScore.Text.Trim())) return;
            else
            {
                this.ds.Tables[0].DefaultView.RowFilter = "CSharp >" + this.txtScore.Text.Trim();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            this.ds.Tables[0].DefaultView.RowFilter = "ClassName like '%%'";
        }
    }
}
