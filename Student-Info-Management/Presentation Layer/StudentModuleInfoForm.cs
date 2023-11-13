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

        public StudentModuleInfoForm()
        {
            InitializeComponent();
        }
        //add student btn
        private void button3_Click(object sender, EventArgs e)
        {
            studentData = new StudentData(int.Parse(txtStudNum.Text), txtFirstName.Text, txtSurname.Text,
            txtImage.Text, txtDOB.Text, txtGender.Text, txtPhone.Text, txtStreetaddress.Text, int.Parse(txtModulecode.Text));
            handler.AddStudent(studentData);
            MessageBox.Show("Student Succesfully added");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        // link to module form
        private void button7_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Module form = new Module();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Wrap code in a try-catch avoid to handle potential exceptions
            try
            {
                // Validate user input before parsing
                if (int.TryParse(txtStudNum.Text , out int studentNumber) &&
                    int.TryParse(txtModulecode.Text, out int moduleCode))
                {
                    //'dataHandler.SearchStudent' returns a DataTable
                    DataTable result = handler.SearchStudent(studentNumber, moduleCode);

                    // Display the result in a DataGridView (replace it with your actual logic)
                    dataGridView1.DataSource = result;
                }
                else
                {
                    // return the case where the user input is not valid
                    MessageBox.Show("Please enter valid integers for Student Number and Module Code.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
               // log the exception and inform the user
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

