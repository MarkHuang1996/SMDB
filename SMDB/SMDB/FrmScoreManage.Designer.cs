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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.groupBox1.SuspendLayout();
            this.gbStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblList);
            this.groupBox1.Location = new System.Drawing.Point(1647, 714);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(352, 646);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Absence Students";
            // 
            // lblList
            // 
            this.lblList.FormattingEnabled = true;
            this.lblList.ItemHeight = 25;
            this.lblList.Location = new System.Drawing.Point(40, 50);
            this.lblList.Margin = new System.Windows.Forms.Padding(6);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(272, 529);
            this.lblList.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(61, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(554, 62);
            this.label9.TabIndex = 24;
            this.label9.Text = "Student Score Manage";
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(1261, 151);
            this.btnStat.Margin = new System.Windows.Forms.Padding(6);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(334, 71);
            this.btnStat.TabIndex = 23;
            this.btnStat.Text = "All Student Score";
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1815, 137);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 71);
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
            this.lblDBAvg.Location = new System.Drawing.Point(194, 358);
            this.lblDBAvg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDBAvg.Name = "lblDBAvg";
            this.lblDBAvg.Size = new System.Drawing.Size(122, 48);
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
            this.gbStat.Location = new System.Drawing.Point(1647, 249);
            this.gbStat.Margin = new System.Windows.Forms.Padding(6);
            this.gbStat.Name = "gbStat";
            this.gbStat.Padding = new System.Windows.Forms.Padding(6);
            this.gbStat.Size = new System.Drawing.Size(352, 446);
            this.gbStat.TabIndex = 22;
            this.gbStat.TabStop = false;
            this.gbStat.Text = "Exam Info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 369);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "DB Avg：";
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.White;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCount.Location = new System.Drawing.Point(194, 165);
            this.lblCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(122, 48);
            this.lblCount.TabIndex = 12;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCSharpAvg
            // 
            this.lblCSharpAvg.BackColor = System.Drawing.Color.White;
            this.lblCSharpAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSharpAvg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCSharpAvg.Location = new System.Drawing.Point(194, 258);
            this.lblCSharpAvg.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCSharpAvg.Name = "lblCSharpAvg";
            this.lblCSharpAvg.Size = new System.Drawing.Size(122, 48);
            this.lblCSharpAvg.TabIndex = 12;
            this.lblCSharpAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Absence ：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "C#Avg：";
            // 
            // lblAttendCount
            // 
            this.lblAttendCount.BackColor = System.Drawing.Color.White;
            this.lblAttendCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttendCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblAttendCount.Location = new System.Drawing.Point(194, 62);
            this.lblAttendCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAttendCount.Name = "lblAttendCount";
            this.lblAttendCount.Size = new System.Drawing.Size(122, 48);
            this.lblAttendCount.TabIndex = 12;
            this.lblAttendCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total；";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select the Class:";
            // 
            // dgvScoreList
            // 
            this.dgvScoreList.AllowUserToAddRows = false;
            this.dgvScoreList.AllowUserToDeleteRows = false;
            this.dgvScoreList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvScoreList.ColumnHeadersHeight = 30;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreList.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvScoreList.Location = new System.Drawing.Point(61, 249);
            this.dgvScoreList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvScoreList.Name = "dgvScoreList";
            this.dgvScoreList.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvScoreList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvScoreList.RowTemplate.Height = 23;
            this.dgvScoreList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvScoreList.Size = new System.Drawing.Size(1534, 1110);
            this.dgvScoreList.TabIndex = 21;
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(322, 163);
            this.cboClass.Margin = new System.Windows.Forms.Padding(6);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(358, 33);
            this.cboClass.TabIndex = 19;
            // 
            // FrmScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2061, 1408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbStat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvScoreList);
            this.Controls.Add(this.cboClass);
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
    }
}