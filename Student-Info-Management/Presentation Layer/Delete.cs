using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Information_Management.Business_Logic_Layer;
using Student_Information_Management.Data_Access_Layer;
using Student_Information_Management.Data_Layer;
using Student_Information_Management.Presentation_Layer;

namespace Student_Information_Management.Presentation_Layer
{
    public partial class Delete : Form
    {
        DataHandler handler = new DataHandler();
        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelStu_Click(object sender, EventArgs e)
        {
            handler.deleteStudent(int.Parse(tbxDelStu.Text));//calls a method and deletes student info on click
        }

        private void btnDelMod_Click(object sender, EventArgs e)
        {
            handler.deleteModule(int.Parse(tbxDelMod.Text));//calls a method and deletes module info on click
        }

        private void btnToMain_Click(object sender, EventArgs e)
        {
            StudentModuleInfoForm mainform = new StudentModuleInfoForm();
            ActiveForm.Hide();
            mainform.Show();
        }
    }
}
