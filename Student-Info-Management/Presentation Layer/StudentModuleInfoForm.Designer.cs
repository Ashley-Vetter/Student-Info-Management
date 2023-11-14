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
            btnSearchModule = new Button();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvModules).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Student Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 148);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Module Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 23);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Student Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 52);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 84);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Surname";
            // 
            // txtStudentNumberSearch
            // 
            txtStudentNumberSearch.Location = new Point(51, 55);
            txtStudentNumberSearch.Margin = new Padding(2, 1, 2, 1);
            txtStudentNumberSearch.Name = "txtStudentNumberSearch";
            txtStudentNumberSearch.Size = new Size(139, 23);
            txtStudentNumberSearch.TabIndex = 6;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(144, 84);
            txtSurname.Margin = new Padding(2, 1, 2, 1);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(148, 23);
            txtSurname.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(144, 56);
            txtFirstName.Margin = new Padding(2, 1, 2, 1);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtModuleCodeSearch
            // 
            txtModuleCodeSearch.Location = new Point(51, 164);
            txtModuleCodeSearch.Margin = new Padding(2, 1, 2, 1);
            txtModuleCodeSearch.Name = "txtModuleCodeSearch";
            txtModuleCodeSearch.Size = new Size(139, 23);
            txtModuleCodeSearch.TabIndex = 10;
            // 
            // txtStudNum
            // 
            txtStudNum.Location = new Point(144, 23);
            txtStudNum.Margin = new Padding(2, 1, 2, 1);
            txtStudNum.Name = "txtStudNum";
            txtStudNum.Size = new Size(148, 23);
            txtStudNum.TabIndex = 11;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(73, 85);
            btnSearchStudent.Margin = new Padding(2, 1, 2, 1);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(97, 36);
            btnSearchStudent.TabIndex = 12;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearch_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(311, 14);
            btnAddStudent.Margin = new Padding(2, 1, 2, 1);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(106, 35);
            btnAddStudent.TabIndex = 14;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(311, 56);
            btnUpdateStudent.Margin = new Padding(2, 1, 2, 1);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(106, 35);
            btnUpdateStudent.TabIndex = 15;
            btnUpdateStudent.Text = " Update Student";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnDeleteForm
            // 
            btnDeleteForm.Location = new Point(311, 102);
            btnDeleteForm.Margin = new Padding(2, 1, 2, 1);
            btnDeleteForm.Name = "btnDeleteForm";
            btnDeleteForm.Size = new Size(106, 35);
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
            groupBox1.Location = new Point(441, 158);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(230, 280);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search and Display";
            // 
            // btnSearchModule
            // 
            btnSearchModule.Location = new Point(73, 195);
            btnSearchModule.Margin = new Padding(2, 1, 2, 1);
            btnSearchModule.Name = "btnSearchModule";
            btnSearchModule.Size = new Size(97, 36);
            btnSearchModule.TabIndex = 13;
            btnSearchModule.Text = "Search Module";
            btnSearchModule.UseVisualStyleBackColor = true;
            btnSearchModule.Click += btnSearchModule_Click;
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
            groupBox2.Location = new Point(-1, 148);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(438, 290);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info ";
            // 
            // btnModuleForm
            // 
            btnModuleForm.Location = new Point(311, 152);
            btnModuleForm.Name = "btnModuleForm";
            btnModuleForm.Size = new Size(104, 23);
            btnModuleForm.TabIndex = 22;
            btnModuleForm.Text = "Module Form";
            btnModuleForm.UseVisualStyleBackColor = true;
            btnModuleForm.Click += btnModuleForm_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(311, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(104, 26);
            btnExit.TabIndex = 22;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtModulecode
            // 
            txtModulecode.Location = new Point(144, 257);
            txtModulecode.Name = "txtModulecode";
            txtModulecode.Size = new Size(148, 23);
            txtModulecode.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 257);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 25;
            label11.Text = "Module Code";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(144, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 23);
            txtPhone.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 197);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 23;
            label10.Text = "Phone";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(144, 140);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(148, 23);
            txtDOB.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 140);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 21;
            label9.Text = "Date Of Birth";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(144, 166);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(148, 23);
            txtGender.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 169);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 19;
            label8.Text = "Gender";
            // 
            // txtImage
            // 
            txtImage.Location = new Point(144, 113);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(148, 23);
            txtImage.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 116);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 17;
            label7.Text = "Image Link";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 226);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 5;
            label6.Text = "Street Address";
            // 
            // txtStreetaddress
            // 
            txtStreetaddress.Location = new Point(144, 226);
            txtStreetaddress.Margin = new Padding(2, 1, 2, 1);
            txtStreetaddress.Name = "txtStreetaddress";
            txtStreetaddress.Size = new Size(148, 23);
            txtStreetaddress.TabIndex = 7;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(8, 5);
            dgvStudents.Margin = new Padding(2, 1, 2, 1);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.RowTemplate.Height = 41;
            dgvStudents.Size = new Size(337, 140);
            dgvStudents.TabIndex = 19;
            // 
            // dgvModules
            // 
            dgvModules.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModules.Location = new Point(354, 5);
            dgvModules.Margin = new Padding(2, 1, 2, 1);
            dgvModules.Name = "dgvModules";
            dgvModules.RowHeadersWidth = 82;
            dgvModules.RowTemplate.Height = 41;
            dgvModules.Size = new Size(337, 141);
            dgvModules.TabIndex = 23;
            // 
            // StudentModuleInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 447);
            Controls.Add(dgvModules);
            Controls.Add(dgvStudents);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 1, 2, 1);
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