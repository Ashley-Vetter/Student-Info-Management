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
using Student_Information_Management.Data_Layer;

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
            txtImage.Text,txtDOB.Text,txtGender.Text,txtPhone.Text,txtStreetaddress.Text,int.Parse(txtModulecode.Text));
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
    }
}

