using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Management.Data_Layer
{
    internal class ModuleData
    {
        int modulecode;
        string moduleName;
        string mdouleDescription;
        string links;

        public ModuleData(int modulecode, string moduleName, string mdouleDescription, string links)
        {
            this.Modulecode = modulecode;
            this.ModuleName = moduleName;
            this.MdouleDescription = mdouleDescription;
            this.Links = links;
        }

        public int Modulecode { get => modulecode; set => modulecode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string MdouleDescription { get => mdouleDescription; set => mdouleDescription = value; }
        public string Links { get => links; set => links = value; }
    }
}
