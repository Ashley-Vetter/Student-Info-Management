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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStudentNumberSearch = new TextBox();
            txtSurname = new TextBox();
            txtFirstName = new TextBox();
            txtModuleCodeSearch = new TextBox();
            txtStudNum = new TextBox();
            btnSearchStudent = new Button();
            btnAddStudent = new Button();
            btnUpdateStudent = new Button();
            btnDeleteForm = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnModuleForm = new Button();
            btnExit = new Button();
            txtModulecode = new TextBox();
            label11 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtDOB = new TextBox();
            label9 = new Label();
            txtGender = new TextBox();
            label8 = new Label();
            txtImage = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtStreetaddress = new TextBox();
            dgvStudents = new DataGridView();
            dgvModules = new DataGridView();
            btnSearchModule = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModules).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 315);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(222, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter Module Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 49);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 2;
            label3.Text = "Student Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 4;
            label5.Text = "Surname";
            // 
            // txtStudentNumberSearch
            // 
            txtStudentNumberSearch.Location = new Point(95, 117);
            txtStudentNumberSearch.Margin = new Padding(4, 2, 4, 2);
            txtStudentNumberSearch.Name = "txtStudentNumberSearch";
            txtStudentNumberSearch.Size = new Size(255, 39);
            txtStudentNumberSearch.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(267, 179);
            txtSurname.Margin = new Padding(4, 2, 4, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(271, 39);
            txtSurname.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(267, 119);
            txtFirstName.Margin = new Padding(4, 2, 4, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(271, 39);
            txtFirstName.TabIndex = 9;
            // 
            // txtModuleCodeSearch
            // 
            txtModuleCodeSearch.Location = new Point(94, 349);
            txtModuleCodeSearch.Margin = new Padding(4, 2, 4, 2);
            txtModuleCodeSearch.Name = "txtModuleCodeSearch";
            txtModuleCodeSearch.Size = new Size(255, 39);
            txtModuleCodeSearch.TabIndex = 10;
            // 
            // txtStudNum
            // 
            txtStudNum.Location = new Point(267, 49);
            txtStudNum.Margin = new Padding(4, 2, 4, 2);
            txtStudNum.Name = "txtStudNum";
            txtStudNum.Size = new Size(271, 39);
            txtStudNum.TabIndex = 11;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(136, 181);
            btnSearchStudent.Margin = new Padding(4, 2, 4, 2);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(180, 77);
            btnSearchStudent.TabIndex = 12;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearch_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(578, 30);
            btnAddStudent.Margin = new Padding(4, 2, 4, 2);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(197, 75);
            btnAddStudent.TabIndex = 14;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(578, 119);
            btnUpdateStudent.Margin = new Padding(4, 2, 4, 2);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(197, 75);
            btnUpdateStudent.TabIndex = 15;
            btnUpdateStudent.Text = " Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteForm
            // 
            btnDeleteForm.Location = new Point(578, 218);
            btnDeleteForm.Margin = new Padding(4, 2, 4, 2);
            btnDeleteForm.Name = "btnDeleteForm";
            btnDeleteForm.Size = new Size(197, 75);
            btnDeleteForm.TabIndex = 16;
            btnDeleteForm.Text = "Delete";
            btnDeleteForm.UseVisualStyleBackColor = true;
            btnDeleteForm.Click += btnDeleteForm_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchModule);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSearchStudent);
            groupBox1.Controls.Add(txtModuleCodeSearch);
            groupBox1.Controls.Add(txtStudentNumberSearch);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(819, 338);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(427, 597);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search and Display";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModuleForm);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(txtModulecode);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDOB);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtGender);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtImage);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnDeleteForm);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnUpdateStudent);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnAddStudent);
            groupBox2.Controls.Add(txtStreetaddress);
            groupBox2.Controls.Add(txtStudNum);
            groupBox2.Controls.Add(txtSurname);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Location = new Point(-2, 316);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(813, 619);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info ";
            // 
            // btnModuleForm
            // 
            btnModuleForm.Location = new Point(578, 324);
            btnModuleForm.Margin = new Padding(6);
            btnModuleForm.Name = "btnModuleForm";
            btnModuleForm.Size = new Size(193, 49);
            btnModuleForm.TabIndex = 22;
            btnModuleForm.Text = "Module Form";
            btnModuleForm.UseVisualStyleBackColor = true;
            btnModuleForm.Click += btnModuleForm_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(578, 525);
            btnExit.Margin = new Padding(6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 55);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtModulecode
            // 
            txtModulecode.Location = new Point(267, 548);
            txtModulecode.Margin = new Padding(6);
            txtModulecode.Name = "txtModulecode";
            txtModulecode.Size = new Size(271, 39);
            txtModulecode.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 548);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(160, 32);
            label11.TabIndex = 25;
            label11.Text = "Module Code";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(267, 414);
            txtPhone.Margin = new Padding(6);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(271, 39);
            txtPhone.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 420);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 32);
            label10.TabIndex = 23;
            label10.Text = "Phone";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(267, 299);
            txtDOB.Margin = new Padding(6);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(271, 39);
            txtDOB.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 299);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(154, 32);
            label9.TabIndex = 21;
            label9.Text = "Date Of Birth";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(267, 354);
            txtGender.Margin = new Padding(6);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(271, 39);
            txtGender.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 361);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(92, 32);
            label8.TabIndex = 19;
            label8.Text = "Gender";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(267, 241);
            txtImage.Margin = new Padding(6);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(271, 39);
            txtImage.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 247);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(130, 32);
            label7.TabIndex = 17;
            label7.Text = "Image Link";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 482);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(167, 32);
            label6.TabIndex = 5;
            label6.Text = "Street Address";
            // 
            // txtStreetaddress
            // 
            txtStreetaddress.Location = new Point(267, 482);
            txtStreetaddress.Margin = new Padding(4, 2, 4, 2);
            txtStreetaddress.Name = "txtStreetaddress";
            txtStreetaddress.Size = new Size(271, 39);
            txtStreetaddress.TabIndex = 7;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(15, 11);
            dgvStudents.Margin = new Padding(4, 2, 4, 2);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.RowTemplate.Height = 41;
            dgvStudents.Size = new Size(626, 299);
            dgvStudents.TabIndex = 19;
            // 
            // dgvModules
            // 
            dgvModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModules.Location = new Point(657, 10);
            dgvModules.Name = "dgvModules";
            dgvModules.RowHeadersWidth = 82;
            dgvModules.RowTemplate.Height = 41;
            dgvModules.Size = new Size(626, 300);
            dgvModules.TabIndex = 23;
            // 
            // btnSearchModule
            // 
            btnSearchModule.Location = new Point(136, 415);
            btnSearchModule.Margin = new Padding(4, 2, 4, 2);
            btnSearchModule.Name = "btnSearchModule";
            btnSearchModule.Size = new Size(180, 77);
            btnSearchModule.TabIndex = 13;
            btnSearchModule.Text = "Search Module";
            btnSearchModule.UseVisualStyleBackColor = true;
            // 
            // StudentModuleInfoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 954);
            Controls.Add(dgvModules);
            Controls.Add(dgvStudents);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "StudentModuleInfoForm";
            Text = "Form1";
            Load += StudentModuleInfoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvModules).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStudentNumberSearch;
        private TextBox txtSurname;
        private TextBox txtFirstName;
        private TextBox txtModuleCodeSearch;
        private TextBox txtStudNum;
        private Button btnSearchStudent;
        private Button btnAddStudent;
        private Button btnUpdateStudent;
        private Button btnDeleteForm;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvStudents;
        private TextBox txtImage;
        private Label label7;
        private TextBox txtDOB;
        private Label label9;
        private TextBox txtGender;
        private Label label8;
        private TextBox txtModulecode;
        private Label label11;
        private TextBox txtPhone;
        private Label label10;
        private Label label6;
        private TextBox txtStreetaddress;
        private Button btnModuleForm;
        private Button btnExit;
        private DataGridView dgvModules;
        private Button btnSearchModule;
    }
}