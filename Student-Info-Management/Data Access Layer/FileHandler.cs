using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Student_Information_Management.Data_Access_Layer
{
    internal class FileHandler
    {
        static string path = "SampleLogins.txt";
        public void WriteSampleLogins()
        {
            // Create sample logins and write them to the file
            string[] sampleLogins = { "Admin:admin", "NSeloana490:Nthabiseng#577490", "PSmal298:Peter#577298", "AVetter605:Ashley#577605", "SMathosa415:Simphiwe#577415", "MDeLange610:Marcel#577610" };
            File.WriteAllLines(path, sampleLogins);
        }

    }
}
