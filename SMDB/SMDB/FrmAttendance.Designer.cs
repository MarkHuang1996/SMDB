namespace SMDB
{
    partial class FrmAttendance
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendance));
            this.label8 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gp01 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.txtStuCardNo = new System.Windows.Forms.TextBox();
            this.lblAbsenceCount = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblStuClass = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gp01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(460, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 81);
            this.label8.TabIndex = 89;
            this.label8.Text = "LastName";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(646, 321);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(146, 42);
            this.lblInfo.TabIndex = 96;
            this.lblInfo.Text = "Clock in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(77, -73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 62);
            this.label1.TabIndex = 111;
            this.label1.Text = "考勤打卡进行中...";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(12, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 81);
            this.label10.TabIndex = 89;
            this.label10.Text = "Students";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gp01
            // 
            this.gp01.Controls.Add(this.label4);
            this.gp01.Controls.Add(this.label3);
            this.gp01.Controls.Add(this.label11);
            this.gp01.Controls.Add(this.label8);
            this.gp01.Controls.Add(this.label12);
            this.gp01.Controls.Add(this.label7);
            this.gp01.Controls.Add(this.label10);
            this.gp01.Controls.Add(this.lblFName);
            this.gp01.Controls.Add(this.lblInfo);
            this.gp01.Controls.Add(this.lblCount);
            this.gp01.Controls.Add(this.lblReal);
            this.gp01.Controls.Add(this.txtStuCardNo);
            this.gp01.Controls.Add(this.lblAbsenceCount);
            this.gp01.Controls.Add(this.lblLName);
            this.gp01.Controls.Add(this.lblStuClass);
            this.gp01.Location = new System.Drawing.Point(507, 135);
            this.gp01.Margin = new System.Windows.Forms.Padding(6);
            this.gp01.Name = "gp01";
            this.gp01.Padding = new System.Windows.Forms.Padding(6);
            this.gp01.Size = new System.Drawing.Size(1492, 412);
            this.gp01.TabIndex = 99;
            this.gp01.TabStop = false;
            this.gp01.Text = "[Attendance Info]";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(931, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 81);
            this.label4.TabIndex = 89;
            this.label4.Text = "Absence";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(439, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 81);
            this.label3.TabIndex = 89;
            this.label3.Text = "Attendance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(967, 171);
            this.label11.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 81);
            this.label11.TabIndex = 89;
            this.label11.Text = "Class";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(10, 292);
            this.label12.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 81);
            this.label12.TabIndex = 89;
            this.label12.Text = "StudentNo";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(12, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 81);
            this.label7.TabIndex = 89;
            this.label7.Text = "FirstName";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFName
            // 
            this.lblFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFName.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFName.ForeColor = System.Drawing.Color.Black;
            this.lblFName.Location = new System.Drawing.Point(242, 171);
            this.lblFName.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(194, 81);
            this.lblFName.TabIndex = 80;
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(209, 54);
            this.lblCount.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(223, 81);
            this.lblCount.TabIndex = 81;
            this.lblCount.Text = "0";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReal
            // 
            this.lblReal.BackColor = System.Drawing.Color.White;
            this.lblReal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReal.Location = new System.Drawing.Point(697, 54);
            this.lblReal.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(200, 81);
            this.lblReal.TabIndex = 83;
            this.lblReal.Text = "0";
            this.lblReal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStuCardNo
            // 
            this.txtStuCardNo.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStuCardNo.Location = new System.Drawing.Point(316, 305);
            this.txtStuCardNo.Margin = new System.Windows.Forms.Padding(6);
            this.txtStuCardNo.Name = "txtStuCardNo";
            this.txtStuCardNo.Size = new System.Drawing.Size(276, 62);
            this.txtStuCardNo.TabIndex = 0;
            // 
            // lblAbsenceCount
            // 
            this.lblAbsenceCount.BackColor = System.Drawing.Color.White;
            this.lblAbsenceCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAbsenceCount.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAbsenceCount.ForeColor = System.Drawing.Color.Red;
            this.lblAbsenceCount.Location = new System.Drawing.Point(1142, 54);
            this.lblAbsenceCount.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblAbsenceCount.Name = "lblAbsenceCount";
            this.lblAbsenceCount.Size = new System.Drawing.Size(255, 81);
            this.lblAbsenceCount.TabIndex = 82;
            this.lblAbsenceCount.Text = "0";
            this.lblAbsenceCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLName
            // 
            this.lblLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLName.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLName.ForeColor = System.Drawing.Color.Black;
            this.lblLName.Location = new System.Drawing.Point(697, 169);
            this.lblLName.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(220, 81);
            this.lblLName.TabIndex = 85;
            this.lblLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStuClass
            // 
            this.lblStuClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblStuClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStuClass.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStuClass.ForeColor = System.Drawing.Color.Black;
            this.lblStuClass.Location = new System.Drawing.Point(1142, 171);
            this.lblStuClass.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.lblStuClass.Name = "lblStuClass";
            this.lblStuClass.Size = new System.Drawing.Size(255, 81);
            this.lblStuClass.TabIndex = 84;
            this.lblStuClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentList.EnableHeadersVisualStyles = false;
            this.dgvStudentList.Location = new System.Drawing.Point(81, 581);
            this.dgvStudentList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvStudentList.RowTemplate.Height = 23;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(1918, 658);
            this.dgvStudentList.TabIndex = 112;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(81, 135);
            this.pbStu.Margin = new System.Windows.Forms.Padding(6);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(356, 410);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 110;
            this.pbStu.TabStop = false;
            // 
            // lblWeek
            // 
            this.lblWeek.BackColor = System.Drawing.Color.Black;
            this.lblWeek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeek.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.ForeColor = System.Drawing.Color.Red;
            this.lblWeek.Location = new System.Drawing.Point(1127, 37);
            this.lblWeek.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(90, 60);
            this.lblWeek.TabIndex = 107;
            this.lblWeek.Text = "0";
            this.lblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.BackColor = System.Drawing.Color.Black;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Red;
            this.lblDay.Location = new System.Drawing.Point(475, 37);
            this.lblDay.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(90, 60);
            this.lblDay.TabIndex = 109;
            this.lblDay.Text = "00";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.BackColor = System.Drawing.Color.Black;
            this.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMonth.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Red;
            this.lblMonth.Location = new System.Drawing.Point(307, 37);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(90, 60);
            this.lblMonth.TabIndex = 108;
            this.lblMonth.Text = "00";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(675, 37);
            this.lblTime.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(268, 60);
            this.lblTime.TabIndex = 106;
            this.lblTime.Text = "00 : 00  00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.Black;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Red;
            this.lblYear.Location = new System.Drawing.Point(83, 37);
            this.lblYear.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(146, 60);
            this.lblYear.TabIndex = 105;
            this.lblYear.Text = "0000";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 81);
            this.label6.TabIndex = 101;
            this.label6.Text = "/";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 81);
            this.label5.TabIndex = 104;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 81);
            this.label2.TabIndex = 103;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1693, 50);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 73);
            this.btnClose.TabIndex = 100;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(957, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(34, 0, 34, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 81);
            this.label9.TabIndex = 102;
            this.label9.Text = "Week";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2198, 1276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gp01);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label9);
            this.Name = "FrmAttendance";
            this.Text = "FrmAttendance";
            this.gp01.ResumeLayout(false);
            this.gp01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gp01;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.TextBox txtStuCardNo;
        private System.Windows.Forms.Label lblAbsenceCount;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblStuClass;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
    }
}