using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Management.Business_Logic_Layer
{
    internal class StudentData
    {
        int studNumber;
        string firstname;
        string surname;
        string studImage;
        string dateOfBirth;
        string gender;
        string phone;
        string stuAddress;
        int moduleCode;

        public int StudNumber { get => studNumber; set => studNumber = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Surname { get => surname; set => surname = value; }
        public string StudImage { get => studImage; set => studImage = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string StuAddress { get => stuAddress; set => stuAddress = value; }
        public int ModuleCode { get => moduleCode; set => moduleCode = value; }

        public StudentData(int studNumber, string firstname, string surname, string studImage, string dateOfBirth, string gender, string phone, string stuAddress, int moduleCode)
        {
            this.StudNumber = studNumber;
            this.Firstname = firstname;
            this.Surname = surname;
            this.StudImage = studImage;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.Phone = phone;
            this.StuAddress = stuAddress;
            this.ModuleCode = moduleCode;
        }

    }
}
