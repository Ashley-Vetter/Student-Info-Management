namespace Student_Information_Management
{
    partial class StudentModuleInfoForm
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
            btnSearchStudent = new Button();
            btnExit = new Button();
            btnSearchModule = new Button();
            dgvStudents = new DataGridView();
            dgvModules = new DataGridView();
            groupBox2 = new GroupBox();
            lblModuleFormHeading = new Label();
            btnUpdateModule = new Button();
            btnAddModule = new Button();
            txtModuleLinks = new TextBox();
            txtModuleDesc = new TextBox();
            txtModuleName = new TextBox();
            txtModuleCode = new TextBox();
            lblModuleLinks = new Label();
            lblModuleDescription = new Label();
            lblModuleName = new Label();
            lblModuleCode = new Label();
            groupBox3 = new GroupBox();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            label3 = new Label();
            txtStudentModuleCode = new TextBox();
            txtFirstName = new TextBox();
            label11 = new Label();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            txtStudNum = new TextBox();
            label10 = new Label();
            txtStreetaddress = new TextBox();
            txtDOB = new TextBox();
            label9 = new Label();
            label6 = new Label();
            txtGender = new TextBox();
            label8 = new Label();
            label5 = new Label();
            txtImage = new TextBox();
            label7 = new Label();
            label4 = new Label();
            lblStudentFormHeading = new Label();
            btnDeleteForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModules).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(296, 341);
            btnSearchStudent.Margin = new Padding(2, 1, 2, 1);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(119, 38);
            btnSearchStudent.TabIndex = 12;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.AliceBlue;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(667, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(218, 50);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSearchModule
            // 
            btnSearchModule.Location = new Point(286, 379);
            btnSearchModule.Margin = new Padding(2, 1, 2, 1);
            btnSearchModule.Name = "btnSearchModule";
            btnSearchModule.Size = new Size(129, 36);
            btnSearchModule.TabIndex = 13;
            btnSearchModule.Text = "Search Module";
            btnSearchModule.UseVisualStyleBackColor = true;
            btnSearchModule.Click += btnSearchModule_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(8, 44);
            dgvStudents.Margin = new Padding(2, 1, 2, 1);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.RowTemplate.Height = 41;
            dgvStudents.Size = new Size(422, 178);
            dgvStudents.TabIndex = 19;
            // 
            // dgvModules
            // 
            dgvModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModules.Location = new Point(5, 44);
            dgvModules.Margin = new Padding(2, 1, 2, 1);
            dgvModules.Name = "dgvModules";
            dgvModules.RowHeadersWidth = 82;
            dgvModules.RowTemplate.Height = 41;
            dgvModules.Size = new Size(422, 178);
            dgvModules.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(btnSearchModule);
            groupBox2.Controls.Add(dgvModules);
            groupBox2.Controls.Add(lblModuleFormHeading);
            groupBox2.Controls.Add(btnUpdateModule);
            groupBox2.Controls.Add(btnAddModule);
            groupBox2.Controls.Add(txtModuleLinks);
            groupBox2.Controls.Add(txtModuleDesc);
            groupBox2.Controls.Add(txtModuleName);
            groupBox2.Controls.Add(txtModuleCode);
            groupBox2.Controls.Add(lblModuleLinks);
            groupBox2.Controls.Add(lblModuleDescription);
            groupBox2.Controls.Add(lblModuleName);
            groupBox2.Controls.Add(lblModuleCode);
            groupBox2.Location = new Point(453, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(432, 456);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            // 
            // lblModuleFormHeading
            // 
            lblModuleFormHeading.AutoSize = true;
            lblModuleFormHeading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblModuleFormHeading.ForeColor = Color.DarkSlateGray;
            lblModuleFormHeading.Location = new Point(137, 13);
            lblModuleFormHeading.Name = "lblModuleFormHeading";
            lblModuleFormHeading.Size = new Size(150, 30);
            lblModuleFormHeading.TabIndex = 24;
            lblModuleFormHeading.Text = "Module Editor";
            // 
            // btnUpdateModule
            // 
            btnUpdateModule.Location = new Point(152, 379);
            btnUpdateModule.Name = "btnUpdateModule";
            btnUpdateModule.Size = new Size(129, 38);
            btnUpdateModule.TabIndex = 23;
            btnUpdateModule.Text = "Update Module";
            btnUpdateModule.UseVisualStyleBackColor = true;
            btnUpdateModule.Click += btnUpdateModule_Click;
            // 
            // btnAddModule
            // 
            btnAddModule.Location = new Point(17, 379);
            btnAddModule.Name = "btnAddModule";
            btnAddModule.Size = new Size(129, 38);
            btnAddModule.TabIndex = 22;
            btnAddModule.Text = "Add Module";
            btnAddModule.UseVisualStyleBackColor = true;
            btnAddModule.Click += btnAddModule_Click;
            // 
            // txtModuleLinks
            // 
            txtModuleLinks.Location = new Point(147, 330);
            txtModuleLinks.Name = "txtModuleLinks";
            txtModuleLinks.Size = new Size(190, 23);
            txtModuleLinks.TabIndex = 21;
            // 
            // txtModuleDesc
            // 
            txtModuleDesc.Location = new Point(147, 299);
            txtModuleDesc.Name = "txtModuleDesc";
            txtModuleDesc.Size = new Size(190, 23);
            txtModuleDesc.TabIndex = 20;
            // 
            // txtModuleName
            // 
            txtModuleName.Location = new Point(147, 269);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.Size = new Size(190, 23);
            txtModuleName.TabIndex = 19;
            // 
            // txtModuleCode
            // 
            txtModuleCode.Location = new Point(147, 236);
            txtModuleCode.Name = "txtModuleCode";
            txtModuleCode.Size = new Size(190, 23);
            txtModuleCode.TabIndex = 18;
            // 
            // lblModuleLinks
            // 
            lblModuleLinks.AutoSize = true;
            lblModuleLinks.Location = new Point(16, 332);
            lblModuleLinks.Name = "lblModuleLinks";
            lblModuleLinks.Size = new Size(78, 15);
            lblModuleLinks.TabIndex = 17;
            lblModuleLinks.Text = "Module Links";
            // 
            // lblModuleDescription
            // 
            lblModuleDescription.AutoSize = true;
            lblModuleDescription.Location = new Point(17, 301);
            lblModuleDescription.Name = "lblModuleDescription";
            lblModuleDescription.Size = new Size(111, 15);
            lblModuleDescription.TabIndex = 16;
            lblModuleDescription.Text = "Module Description";
            // 
            // lblModuleName
            // 
            lblModuleName.AutoSize = true;
            lblModuleName.Location = new Point(16, 270);
            lblModuleName.Name = "lblModuleName";
            lblModuleName.Size = new Size(83, 15);
            lblModuleName.TabIndex = 15;
            lblModuleName.Text = "Module Name";
            // 
            // lblModuleCode
            // 
            lblModuleCode.AutoSize = true;
            lblModuleCode.Location = new Point(16, 239);
            lblModuleCode.Name = "lblModuleCode";
            lblModuleCode.Size = new Size(79, 15);
            lblModuleCode.TabIndex = 14;
            lblModuleCode.Text = "Module Code";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.AliceBlue;
            groupBox3.Controls.Add(btnAddStudent);
            groupBox3.Controls.Add(btnUpdateStudent);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtStudentModuleCode);
            groupBox3.Controls.Add(txtFirstName);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtSurname);
            groupBox3.Controls.Add(txtPhone);
            groupBox3.Controls.Add(txtStudNum);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtStreetaddress);
            groupBox3.Controls.Add(txtDOB);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtGender);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtImage);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnSearchStudent);
            groupBox3.Controls.Add(lblStudentFormHeading);
            groupBox3.Controls.Add(dgvStudents);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(435, 507);
            groupBox3.TabIndex = 29;
            groupBox3.TabStop = false;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(296, 246);
            btnAddStudent.Margin = new Padding(2, 1, 2, 1);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(117, 38);
            btnAddStudent.TabIndex = 48;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(296, 294);
            btnUpdateStudent.Margin = new Padding(2, 1, 2, 1);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(119, 38);
            btnUpdateStudent.TabIndex = 49;
            btnUpdateStudent.Text = " Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 239);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 30;
            label3.Text = "Student Number";
            // 
            // txtStudentModuleCode
            // 
            txtStudentModuleCode.Location = new Point(128, 467);
            txtStudentModuleCode.Name = "txtStudentModuleCode";
            txtStudentModuleCode.Size = new Size(148, 23);
            txtStudentModuleCode.TabIndex = 47;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(128, 266);
            txtFirstName.Margin = new Padding(2, 1, 2, 1);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 36;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 470);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 46;
            label11.Text = "Module Code";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(128, 294);
            txtSurname.Margin = new Padding(2, 1, 2, 1);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 23);
            txtSurname.TabIndex = 35;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(128, 404);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 23);
            txtPhone.TabIndex = 45;
            // 
            // txtStudNum
            // 
            txtStudNum.Location = new Point(128, 236);
            txtStudNum.Margin = new Padding(2, 1, 2, 1);
            txtStudNum.Name = "txtStudNum";
            txtStudNum.Size = new Size(148, 23);
            txtStudNum.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 407);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 44;
            label10.Text = "Phone";
            // 
            // txtStreetaddress
            // 
            txtStreetaddress.Location = new Point(128, 436);
            txtStreetaddress.Margin = new Padding(2, 1, 2, 1);
            txtStreetaddress.Name = "txtStreetaddress";
            txtStreetaddress.Size = new Size(148, 23);
            txtStreetaddress.TabIndex = 34;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(128, 350);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(148, 23);
            txtDOB.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 353);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 42;
            label9.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 439);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 33;
            label6.Text = "Street Address";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(128, 376);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(148, 23);
            txtGender.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 379);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 40;
            label8.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 297);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 32;
            label5.Text = "Surname";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(128, 323);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(148, 23);
            txtImage.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 326);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 38;
            label7.Text = "Image Link";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 269);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 31;
            label4.Text = "First Name";
            // 
            // lblStudentFormHeading
            // 
            lblStudentFormHeading.AutoSize = true;
            lblStudentFormHeading.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblStudentFormHeading.ForeColor = Color.DarkSlateGray;
            lblStudentFormHeading.Location = new Point(151, 13);
            lblStudentFormHeading.Name = "lblStudentFormHeading";
            lblStudentFormHeading.Size = new Size(151, 30);
            lblStudentFormHeading.TabIndex = 29;
            lblStudentFormHeading.Text = "Student Editor";
            // 
            // btnDeleteForm
            // 
            btnDeleteForm.BackColor = Color.AliceBlue;
            btnDeleteForm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteForm.ForeColor = SystemColors.ControlText;
            btnDeleteForm.Location = new Point(453, 474);
            btnDeleteForm.Name = "btnDeleteForm";
            btnDeleteForm.Size = new Size(208, 50);
            btnDeleteForm.TabIndex = 30;
            btnDeleteForm.Text = "Delete Form";
            btnDeleteForm.UseVisualStyleBackColor = false;
            btnDeleteForm.Click += btnDeleteForm_Click;
            // 
            // StudentModuleInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(897, 530);
            Controls.Add(btnDeleteForm);
            Controls.Add(btnExit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new Padding(2, 1, 2, 1);
            Name = "StudentModuleInfoForm";
            Text = "Main Form";
            Load += StudentModuleInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvModules).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSearchStudent;
        private DataGridView dgvStudents;
        private Button btnExit;
        private DataGridView dgvModules;
        private Button btnSearchModule;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblModuleFormHeading;
        private Button btnUpdateModule;
        private Button btnAddModule;
        private TextBox txtModuleLinks;
        private TextBox txtModuleDesc;
        private TextBox txtModuleName;
        private TextBox txtModuleCode;
        private Label lblModuleLinks;
        private Label lblModuleDescription;
        private Label lblModuleName;
        private Label lblModuleCode;
        private Label lblStudentFormHeading;
        private Label label3;
        private TextBox txtStudentModuleCode;
        private TextBox txtFirstName;
        private Label label11;
        private TextBox txtSurname;
        private TextBox txtPhone;
        private TextBox txtStudNum;
        private Label label10;
        private TextBox txtStreetaddress;
        private TextBox txtDOB;
        private Label label9;
        private Label label6;
        private TextBox txtGender;
        private Label label8;
        private Label label5;
        private TextBox txtImage;
        private Label label7;
        private Label label4;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteForm;
    }
}