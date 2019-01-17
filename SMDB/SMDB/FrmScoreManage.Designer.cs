namespace SMDB
{
    partial class FrmScoreManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScoreManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDBAvg = new System.Windows.Forms.Label();
            this.gbStat = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCSharpAvg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAttendCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvScoreList = new System.Windows.Forms.DataGridView();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSharp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SQLServerDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.gbStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblList);
            this.groupBox1.Location = new System.Drawing.Point(824, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 336);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absence Students";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.Location = new System.Drawing.Point(20, 26);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(138, 277);
            this.lblList.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(30, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(276, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Student Score Manage";
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(630, 79);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(167, 37);
            this.btnStat.TabIndex = 23;
            this.btnStat.Text = "All Student Score";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(908, 71);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 37);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDBAvg
            // 
            this.lblDBAvg.BackColor = System.Drawing.Color.White;
            this.lblDBAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDBAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDBAvg.Location = new System.Drawing.Point(97, 186);
            this.lblDBAvg.Name = "lblDBAvg";
            this.lblDBAvg.Size = new System.Drawing.Size(61, 25);
            this.lblDBAvg.TabIndex = 12;
            this.lblDBAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStat
            // 
            this.gbStat.Controls.Add(this.lblDBAvg);
            this.gbStat.Controls.Add(this.label8);
            this.gbStat.Controls.Add(this.lblCount);
            this.gbStat.Controls.Add(this.lblCSharpAvg);
            this.gbStat.Controls.Add(this.label4);
            this.gbStat.Controls.Add(this.label6);
            this.gbStat.Controls.Add(this.lblAttendCount);
            this.gbStat.Controls.Add(this.label3);
            this.gbStat.Location = new System.Drawing.Point(824, 129);
            this.gbStat.Name = "gbStat";
            this.gbStat.Size = new System.Drawing.Size(176, 232);
            this.gbStat.TabIndex = 22;
            this.gbStat.TabStop = false;
            this.gbStat.Text = "Exam Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "DB Avg：";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(97, 86);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(61, 25);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCSharpAvg
            // 
            this.lblCSharpAvg.BackColor = System.Drawing.Color.White;
            this.lblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSharpAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCSharpAvg.Location = new System.Drawing.Point(97, 134);
            this.lblCSharpAvg.Name = "lblCSharpAvg";
            this.lblCSharpAvg.Size = new System.Drawing.Size(61, 25);
            this.lblCSharpAvg.TabIndex = 12;
            this.lblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Absence ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "C#Avg：";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.Color.White;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAttendCount.Location = new System.Drawing.Point(97, 32);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(61, 25);
            this.lblAttendCount.TabIndex = 12;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total；";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select the Class:";
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreList.ColumnHeadersHeight = 30;
            this.dgvScoreList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.ClassName,
            this.CSharp,
            this.SQLServerDB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreList.Location = new System.Drawing.Point(30, 129);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvScoreList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(767, 577);
            this.dgvScoreList.TabIndex = 21;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(161, 85);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(181, 21);
            this.cboClass.TabIndex = 19;
            this.cboClass.SelectedIndexChanged += new System.EventHandler(this.cboClass_SelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // CSharp
            // 
            this.CSharp.DataPropertyName = "CSharp";
            this.CSharp.HeaderText = "CSharp";
            this.CSharp.Name = "CSharp";
            this.CSharp.ReadOnly = true;
            // 
            // SQLServerDB
            // 
            this.SQLServerDB.DataPropertyName = "SQLServerDB";
            this.SQLServerDB.HeaderText = "SQLServer";
            this.SQLServerDB.Name = "SQLServerDB";
            this.SQLServerDB.ReadOnly = true;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbStat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.cboClass);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmScoreManage";
            this.Text = "FrmScoreManage";
            this.groupBox1.ResumeLayout(false);
            this.gbStat.ResumeLayout(false);
            this.gbStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lblList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDBAvg;
        private System.Windows.Forms.GroupBox gbStat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCSharpAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAttendCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvScoreList;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSharp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SQLServerDB;
    }
}