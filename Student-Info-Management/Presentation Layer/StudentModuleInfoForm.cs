using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Information_Management.Presentation_Layer;
using Student_Information_Management.Data_Access_Layer;
using Student_Information_Management.Business_Logic_Layer;

namespace Student_Information_Management
{
    public partial class StudentModuleInfoForm : Form
    {
        StudentData studentData;
        ModuleData moduleData;
        DataHandler handler;
        BindingSource bsStudents = new BindingSource();
        BindingSource bsModules = new BindingSource();

        public StudentModuleInfoForm()
        {
            InitializeComponent();
        }

        private void StudentModuleInfoForm_Load(object sender, EventArgs e)
        {
            handler = new DataHandler();

            bsStudents.DataSource = handler.DisplayStudent();
            dgvStudents.DataSource = bsStudents;

            bsModules.DataSource = handler.DisplayModule();
            dgvModules.DataSource = bsModules;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //
        //      Student Group
        //

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            studentData = new StudentData(int.Parse(txtStudNum.Text), txtFirstName.Text, txtSurname.Text,
            txtImage.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtStreetaddress.Text, int.Parse(txtStudentModuleCode.Text));
            handler.AddStudent(studentData);
            bsStudents.DataSource = handler.DisplayStudent();
            dgvStudents.DataSource = bsStudents;
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            studentData = new StudentData(int.Parse(txtStudNum.Text), txtFirstName.Text, txtSurname.Text,
            txtImage.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtStreetaddress.Text, int.Parse(txtStudentModuleCode.Text));
            handler.UpdateStudent(studentData);
            bsStudents.DataSource = handler.DisplayStudent();
            dgvStudents.DataSource = bsStudents;
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtStudNum.Text != "")
            {
                bsStudents.DataSource = handler.SearchStudent(int.Parse(txtStudNum.Text));
                dgvStudents.DataSource = bsStudents;
            }
            else if (txtStudNum.Text == "")
            {
                bsStudents.DataSource = handler.DisplayStudent();
                txtFirstName.Clear();
                txtSurname.Clear();
                txtImage.Clear();
                txtDOB.Clear();
                txtGender.Clear();
                txtPhone.Clear();
                txtStreetaddress.Clear();
                txtStudentModuleCode.Clear();
            }
        }


        //      Module Group
        private void btnAddModule_Click(object sender, EventArgs e)
        {
            moduleData = new ModuleData(int.Parse(txtModuleCode.Text), txtModuleName.Text, txtModuleDesc.Text, txtModuleLinks.Text);
            handler.AddModule(moduleData);
            bsModules.DataSource = handler.DisplayModule();
            dgvModules.DataSource = bsModules;
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            moduleData = new ModuleData(int.Parse(txtModuleCode.Text), txtModuleName.Text, txtModuleDesc.Text, txtModuleLinks.Text);
            handler.UpdateModule(moduleData);
            bsModules.DataSource = handler.DisplayModule();
            dgvModules.DataSource = bsModules;
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            if (txtModuleCode.Text != "")
            {
                bsModules.DataSource = handler.SearchModule(int.Parse(txtModuleCode.Text));
                dgvModules.DataSource = bsModules;
            }
            else if (txtModuleCode.Text == "")
            {
                bsModules.DataSource = handler.DisplayModule();
                txtModuleCode.Clear();
                txtModuleDesc.Clear();
                txtModuleLinks.Clear();
                txtModuleName.Clear();
            }

        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            ActiveForm.Hide();
            deleteForm.Show();
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Validate user input before parsing
        //        if (int.TryParse(txtStudNum.Text, out int studentNumber) &&
        //            int.TryParse(txtModulecode.Text, out int moduleCode))
        //        {
        //            //'dataHandler.SearchStudent' returns a DataTable
        //            DataTable result = handler.SearchStudent(studentNumber, moduleCode);

        //            // Display the result in a DataGridView (replace it with your actual logic)
        //            dgvStudents.DataSource = result;
        //        }
        //        else
        //        {
        //            // return the case where the user input is not valid
        //            MessageBox.Show("Please enter valid integers for Student Number and Module Code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // log the exception and inform the user
        //        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}

