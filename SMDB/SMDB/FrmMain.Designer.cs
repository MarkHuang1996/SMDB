namespace SMDB
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbModifyPwd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbScoreAnalysis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbAddStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attenceCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryAndAnalysisQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoureYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsInfoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManagerTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pwdChangePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            resources.ApplyResources(this.lblCurrentUser, "lblCurrentUser");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.lblCurrentUser});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // tsbExit
            // 
            resources.ApplyResources(this.tsbExit, "tsbExit");
            this.tsbExit.Name = "tsbExit";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // tsbModifyPwd
            // 
            resources.ApplyResources(this.tsbModifyPwd, "tsbModifyPwd");
            this.tsbModifyPwd.Name = "tsbModifyPwd";
            this.tsbModifyPwd.Click += new System.EventHandler(this.tsbModifyPwd_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsbQuery
            // 
            resources.ApplyResources(this.tsbQuery, "tsbQuery");
            this.tsbQuery.Name = "tsbQuery";
            // 
            // tsbScoreAnalysis
            // 
            resources.ApplyResources(this.tsbScoreAnalysis, "tsbScoreAnalysis");
            this.tsbScoreAnalysis.Name = "tsbScoreAnalysis";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // tsbAddStudent
            // 
            resources.ApplyResources(this.tsbAddStudent, "tsbAddStudent");
            this.tsbAddStudent.Name = "tsbAddStudent";
            this.tsbAddStudent.Click += new System.EventHandler(this.tsbAddStudent_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddStudent,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tsbScoreAnalysis,
            this.tsbQuery,
            this.toolStripSeparator4,
            this.tsbModifyPwd,
            this.toolStripSeparator6,
            this.tsbExit});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attenceCheckToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            resources.ApplyResources(this.attendanceToolStripMenuItem, "attendanceToolStripMenuItem");
            // 
            // attenceCheckToolStripMenuItem
            // 
            this.attenceCheckToolStripMenuItem.Name = "attenceCheckToolStripMenuItem";
            resources.ApplyResources(this.attenceCheckToolStripMenuItem, "attenceCheckToolStripMenuItem");
            // 
            // quickSearchToolStripMenuItem
            // 
            this.quickSearchToolStripMenuItem.Name = "quickSearchToolStripMenuItem";
            resources.ApplyResources(this.quickSearchToolStripMenuItem, "quickSearchToolStripMenuItem");
            // 
            // queryAndAnalysisQToolStripMenuItem
            // 
            this.queryAndAnalysisQToolStripMenuItem.Name = "queryAndAnalysisQToolStripMenuItem";
            resources.ApplyResources(this.queryAndAnalysisQToolStripMenuItem, "queryAndAnalysisQToolStripMenuItem");
            // 
            // scoureYToolStripMenuItem
            // 
            this.scoureYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryAndAnalysisQToolStripMenuItem,
            this.quickSearchToolStripMenuItem});
            this.scoureYToolStripMenuItem.Name = "scoureYToolStripMenuItem";
            resources.ApplyResources(this.scoureYToolStripMenuItem, "scoureYToolStripMenuItem");
            // 
            // studentsInfoIToolStripMenuItem
            // 
            this.studentsInfoIToolStripMenuItem.Name = "studentsInfoIToolStripMenuItem";
            resources.ApplyResources(this.studentsInfoIToolStripMenuItem, "studentsInfoIToolStripMenuItem");
            // 
            // addNewStudentAToolStripMenuItem
            // 
            this.addNewStudentAToolStripMenuItem.Name = "addNewStudentAToolStripMenuItem";
            resources.ApplyResources(this.addNewStudentAToolStripMenuItem, "addNewStudentAToolStripMenuItem");
            // 
            // studentManagerTToolStripMenuItem
            // 
            this.studentManagerTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentAToolStripMenuItem,
            this.studentsInfoIToolStripMenuItem});
            this.studentManagerTToolStripMenuItem.Name = "studentManagerTToolStripMenuItem";
            resources.ApplyResources(this.studentManagerTToolStripMenuItem, "studentManagerTToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // pwdChangePToolStripMenuItem
            // 
            this.pwdChangePToolStripMenuItem.Name = "pwdChangePToolStripMenuItem";
            resources.ApplyResources(this.pwdChangePToolStripMenuItem, "pwdChangePToolStripMenuItem");
            // 
            // systemsToolStripMenuItem
            // 
            this.systemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pwdChangePToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.systemsToolStripMenuItem.Name = "systemsToolStripMenuItem";
            resources.ApplyResources(this.systemsToolStripMenuItem, "systemsToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemsToolStripMenuItem,
            this.studentManagerTToolStripMenuItem,
            this.scoureYToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbModifyPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbScoreAnalysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbAddStudent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attenceCheckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryAndAnalysisQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoureYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsInfoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentManagerTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pwdChangePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
    }
}

