using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Information_Management.Data_Access_Layer;

namespace Student_Information_Management.Presentation_Layer
{
    public partial class DeleteForm : Form
    {
        DataHandler handler = new DataHandler();

        public DeleteForm()
        {
            InitializeComponent();
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            handler.DeleteStudent(int.Parse(txtEnterStudentNumber.Text));
        }
        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            handler.DeleteModule(int.Parse(txtEnterModuleCode.Text));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            StudentModuleInfoForm mainform = new StudentModuleInfoForm();
            ActiveForm.Hide();
            mainform.Show();
        }
    }
}
