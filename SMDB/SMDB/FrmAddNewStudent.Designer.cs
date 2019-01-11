namespace SMDB
{
    partial class FrmAddNewStudent
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.pbStu = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboClassName = new System.Windows.Forms.ComboBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(537, 872);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 38);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Cancle";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 872);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 38);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImageIndex = 4;
            this.btnClear.Location = new System.Drawing.Point(567, 243);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 58);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "CleanPhoto ";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseVideo.ImageIndex = 1;
            this.btnCloseVideo.Location = new System.Drawing.Point(567, 123);
            this.btnCloseVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(154, 58);
            this.btnCloseVideo.TabIndex = 53;
            this.btnCloseVideo.Text = "CloseCamera";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            // 
            // btnTake
            // 
            this.btnTake.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTake.ImageIndex = 3;
            this.btnTake.Location = new System.Drawing.Point(404, 243);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(154, 58);
            this.btnTake.TabIndex = 54;
            this.btnTake.Text = "TakePhoto";
            this.btnTake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTake.UseVisualStyleBackColor = true;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartVideo.ImageIndex = 0;
            this.btnStartVideo.Location = new System.Drawing.Point(404, 123);
            this.btnStartVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(154, 58);
            this.btnStartVideo.TabIndex = 55;
            this.btnStartVideo.Text = "StartCamera ";
            this.btnStartVideo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartVideo.UseVisualStyleBackColor = true;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoseImage.ImageIndex = 2;
            this.btnChoseImage.Location = new System.Drawing.Point(404, 358);
            this.btnChoseImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(154, 58);
            this.btnChoseImage.TabIndex = 52;
            this.btnChoseImage.Text = "Select a Photo";
            this.btnChoseImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoseImage.UseVisualStyleBackColor = true;
            // 
            // pbVideo
            // 
            this.pbVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbVideo.Location = new System.Drawing.Point(56, 120);
            this.pbVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(292, 295);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideo.TabIndex = 50;
            this.pbVideo.TabStop = false;
            // 
            // pbStu
            // 
            this.pbStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStu.Location = new System.Drawing.Point(765, 120);
            this.pbStu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbStu.Name = "pbStu";
            this.pbStu.Size = new System.Drawing.Size(310, 295);
            this.pbStu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStu.TabIndex = 51;
            this.pbStu.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(46, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 46);
            this.label7.TabIndex = 47;
            this.label7.Text = "Add New Student";
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.dateTimePicker1);
            this.gbStudentInfo.Controls.Add(this.cboClassName);
            this.gbStudentInfo.Controls.Add(this.rdoFemale);
            this.gbStudentInfo.Controls.Add(this.rdoMale);
            this.gbStudentInfo.Controls.Add(this.txtAddress);
            this.gbStudentInfo.Controls.Add(this.label6);
            this.gbStudentInfo.Controls.Add(this.txtPhoneNumber);
            this.gbStudentInfo.Controls.Add(this.label5);
            this.gbStudentInfo.Controls.Add(this.label4);
            this.gbStudentInfo.Controls.Add(this.label3);
            this.gbStudentInfo.Controls.Add(this.label2);
            this.gbStudentInfo.Controls.Add(this.txtLName);
            this.gbStudentInfo.Controls.Add(this.label9);
            this.gbStudentInfo.Controls.Add(this.txtFName);
            this.gbStudentInfo.Controls.Add(this.label1);
            this.gbStudentInfo.Location = new System.Drawing.Point(54, 525);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(1021, 286);
            this.gbStudentInfo.TabIndex = 57;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Infomation";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(506, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // cboClassName
            // 
            this.cboClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClassName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClassName.FormattingEnabled = true;
            this.cboClassName.Location = new System.Drawing.Point(850, 130);
            this.cboClassName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboClassName.Name = "cboClassName";
            this.cboClassName.Size = new System.Drawing.Size(156, 28);
            this.cboClassName.TabIndex = 50;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(251, 132);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 48;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(162, 132);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 47;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(622, 211);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(384, 26);
            this.txtAddress.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Address：";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(223, 209);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(226, 26);
            this.txtPhoneNumber.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Phone Number：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(748, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Course：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "BOD：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Gender：";
            // 
            // txtLName
            // 
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLName.Location = new System.Drawing.Point(505, 54);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(149, 26);
            this.txtLName.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Last Name：";
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Location = new System.Drawing.Point(189, 58);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(149, 26);
            this.txtFName.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "First Name：";
            // 
            // FrmAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 934);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.pbStu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmAddNewStudent";
            this.Text = "FrmAddNewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStu)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.PictureBox pbVideo;
        private System.Windows.Forms.PictureBox pbStu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboClassName;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label1;
    }
}