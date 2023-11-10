using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using Student_Information_Management.Business_Logic_Layer;
using Student_Information_Management.Data_Layer;
using Student_Information_Management.Presentation_Layer;

namespace Student_Information_Management.Data_Access_Layer
{
    internal class FileHandler
    {
        static string path = "SampleLogins.txt";
        public void WriteSampleLogins()
        {
            // Create sample logins and write them to the file
            string[] sampleLogins = { "Admin:admin", "Nthabi:nthabi123", "Frank:frank123", "Ashley:ashley123", "Simphiwe:simphiwe123", "Marcel:marcel123" };
            File.WriteAllLines(path, sampleLogins);
        }
    }
}
