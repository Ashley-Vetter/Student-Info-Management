using Student_Information_Management.Data_Layer;
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

namespace Student_Information_Management
{
    public partial class StudentModuleInfoForm : Form
    {
        StudentData studentData;
        DataHandler handler;
        BindingSource bsStudents = new BindingSource();
        BindingSource bsModules = new BindingSource();

        private void StudentModuleInfoForm_Load(object sender, EventArgs e)
        {
            handler = new DataHandler();

            bsStudents.DataSource = handler.displayStudent();
            dgvStudents.DataSource = bsStudents;

            bsModules.DataSource = handler.displayModule();
            dgvModules.DataSource = bsModules;
        }
        public StudentModuleInfoForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            studentData = new StudentData(int.Parse(txtStudNum.Text), txtFirstName.Text, txtSurname.Text,
            txtImage.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtStreetaddress.Text, int.Parse(txtModulecode.Text));
            handler.AddStudent(studentData);
            MessageBox.Show("Student Succesfully Added");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // link to module form
        private void btnModuleForm_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Module form = new Module();
            form.Show();
        }


        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            //on click, it hides the active form and opens up the delete form
            ActiveForm.Hide();
            Delete form = new Delete();
            form.Show();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            studentData = new StudentData(int.Parse(txtStudNum.Text), txtFirstName.Text, txtSurname.Text,
            txtImage.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtStreetaddress.Text, int.Parse(txtModulecode.Text));
            handler.UpdateStudent(studentData);
            MessageBox.Show("Student Succesfully Updated");
        }

        private void btnDisplayStudents_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayModules_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

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

