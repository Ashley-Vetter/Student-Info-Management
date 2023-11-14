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
namespace Student_Information_Management.Presentation_Layer
{
    public partial class Module : Form
    {
        DataHandler handler=new DataHandler();
        ModuleData moduleData;

      
        public Module()
        {
            InitializeComponent();
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }
        //add module 
        private void button1_Click(object sender, EventArgs e)
        {
            moduleData = new ModuleData(int.Parse(txtModule.Text), txtModuleName.Text, txtModuleDesc.Text, txtModuleLinks.Text);
            handler.AddModule(moduleData);
            MessageBox.Show("Module successfully added");
        }

        private void Module_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moduleData = new ModuleData(int.Parse(txtModule.Text), txtModuleName.Text, txtModuleDesc.Text, txtModuleLinks.Text);
            handler.UpdateModule(moduleData);
            MessageBox.Show("Module Successfully Updated");
        }
    }
}
