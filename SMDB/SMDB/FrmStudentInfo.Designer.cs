namespace SMDB
{
    partial class FrmStudentInfo
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
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(465, 27);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(226, 213);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 47;
            this.pbStu.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(552, 254);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 37);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Address：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 89;
            this.label5.Text = "Phone Number：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "BOD：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Gender：";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(68, 56);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(79, 13);
            this.lblStudentId.TabIndex = 90;
            this.lblStudentId.Text = "StudentIdNo：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Last Name：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "First Name：";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.BackColor = System.Drawing.Color.LightGray;
            this.lblStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentNo.Enabled = false;
            this.lblStudentNo.Location = new System.Drawing.Point(138, 47);
            this.lblStudentNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(132, 22);
            this.lblStudentNo.TabIndex = 94;
            // 
            // lblFName
            // 
            this.lblFName.BackColor = System.Drawing.Color.LightGray;
            this.lblFName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFName.Enabled = false;
            this.lblFName.Location = new System.Drawing.Point(138, 89);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(104, 22);
            this.lblFName.TabIndex = 94;
            // 
            // lblLName
            // 
            this.lblLName.BackColor = System.Drawing.Color.LightGray;
            this.lblLName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLName.Enabled = false;
            this.lblLName.Location = new System.Drawing.Point(310, 89);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(102, 22);
            this.lblLName.TabIndex = 94;
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.LightGray;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGender.Enabled = false;
            this.lblGender.Location = new System.Drawing.Point(138, 135);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 22);
            this.lblGender.TabIndex = 94;
            // 
            // lblBirthday
            // 
            this.lblBirthday.BackColor = System.Drawing.Color.LightGray;
            this.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBirthday.Enabled = false;
            this.lblBirthday.Location = new System.Drawing.Point(288, 135);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(108, 22);
            this.lblBirthday.TabIndex = 94;
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.Color.LightGray;
            this.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClass.Enabled = false;
            this.lblClass.Location = new System.Drawing.Point(138, 178);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(132, 22);
            this.lblClass.TabIndex = 94;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.LightGray;
            this.lblPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhoneNumber.Enabled = false;
            this.lblPhoneNumber.Location = new System.Drawing.Point(138, 217);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(198, 22);
            this.lblPhoneNumber.TabIndex = 94;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.LightGray;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Enabled = false;
            this.lblAddress.Location = new System.Drawing.Point(138, 249);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(198, 22);
            this.lblAddress.TabIndex = 94;
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 306);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudentInfo";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
    }
}