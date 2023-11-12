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

namespace Student_Information_Management
{
    public partial class StudentModuleInfoForm : Form
    {
        DataHandler handler = new DataHandler();
        BindingSource bs = new BindingSource();
        public StudentModuleInfoForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            ActiveForm.Hide();
            form.Show();
        }

        private void StudentModuleInfoForm_Load(object sender, EventArgs e)
        {
            bs.DataSource = handler.displayStudent();
            dgvStudentInfo.DataSource = bs;

            bs.DataSource = handler.displayModule();
            dgvModuleInfo.DataSource = bs;
        }

        private void btnSearchStu_Click(object sender, EventArgs e)
        {
            this.dgvStudentInfo.DataSource = null;
            bs.DataSource = null;
            bs.DataSource = handler.searchStudent(int.Parse(tbxStuSearch.Text));
            dgvStudentInfo.DataSource = bs;

        }

        private void btnSearchMod_Click(object sender, EventArgs e)
        {
            this.dgvModuleInfo.DataSource = null;
            bs.DataSource = null;
            bs.DataSource = handler.searchModule(int.Parse(tbxModSearch.Text));
            dgvModuleInfo.DataSource = bs;
        }
    }
}
