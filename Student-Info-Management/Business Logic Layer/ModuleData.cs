using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Management.Business_Logic_Layer
{
    internal class ModuleData
    {
        int modulecode;
        string moduleName;
        string moduleDescription;
        string links;

        public ModuleData(int modulecode, string moduleName, string moduleDescription, string links)
        {
            this.Modulecode = modulecode;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDescription;
            this.Links = links;
        }

        public int Modulecode { get => modulecode; set => modulecode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string? Links { get => links; set => links = value; }
    }
}
