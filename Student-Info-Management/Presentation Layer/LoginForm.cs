using Student_Information_Management.Data_Access_Layer;
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


namespace Student_Information_Management.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        FileHandler fileHandler = new FileHandler();
        StudentModuleInfoForm smForm = new StudentModuleInfoForm();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            fileHandler.WriteSampleLogins();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dataHandler.ValidateUserLogin(txtEnterUsername.Text, txtEnterPassword.Text))
            {
                MessageBox.Show("Successful login");
                ActiveForm.Hide();
                smForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login. Clearing Fields");
                txtEnterUsername.Clear();
                txtEnterPassword.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Invalid login. Do you want to register a new user?", "Invalid Login", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dataHandler.RegisterUser();
            }
            else
            {
                MessageBox.Show("Exiting...");
            }
        }
    }
}
