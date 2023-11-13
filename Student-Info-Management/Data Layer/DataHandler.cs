using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using Student_Information_Management.Data_Access_Layer;
using Student_Information_Management.Business_Logic_Layer;
using Student_Information_Management.Presentation_Layer;
using System.Collections;
using System.Data;

namespace Student_Information_Management.Data_Layer
{
    internal class DataHandler
    {
        string query;
        SqlConnection connection = new SqlConnection(conn);
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable table;

        //connection string to sql server
        static string conn = "Server= np:\\\\.\\pipe\\LOCALDB#11554CD3\\tsql\\query; Initial Catalog= StudentManager; Integrated Security=SSPI";
        //insert students
        public void AddStudent(StudentData student)
        {
            query = $"INSERT INTO students " +
                            $"VALUES ('{student.StudNumber}', '{student.Firstname}', '{student.Surname}', '{student.StudImage}', " +
                            $"'{student.DateOfBirth}', '{student.Gender}', '{student.Phone}', '{student.StuAddress}','{student.ModuleCode}')";

            try
            {
                using (connection)
                {
                    using (cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }
        
        public void AddModule( ModuleData moduleData)
        {

            query = $"INSERT INTO modules  " +
                          $"VALUES ('{moduleData.Modulecode}','{moduleData.ModuleName}', '{moduleData.MdouleDescription}','{moduleData.Links}')";

            try
            {
                using (connection)
                {
                    using (cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

        }
    


        static string path = "SampleLogins.txt";
        public bool ValidateUserLogin(string username, string password)
        {
            // Read user credentials from the file
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string storedUsername = parts[0].Trim();
                    string storedPassword = parts[1].Trim();

                    if (username == storedUsername && password == storedPassword)
                    {
                        return true; // Login successful
                    }
                }
            }
            return false; // Login failed
        }

        public void RegisterUser()
        {
            // Get new user input
            string newUsername = Interaction.InputBox("Enter a new username:", "User Registration", "");
            // Check if the username already exists
            if (UsernameExists(newUsername))
            {
                MessageBox.Show("Username already exists. Please choose a different one.");
                RegisterUser();
                return;
            }

            string newPassword = Interaction.InputBox("Enter a password:", "User Registration", "");

            // Write the new user to the file
            File.AppendAllText(path, $"{newUsername}:{newPassword}\n");

            MessageBox.Show("Registration successful! You can now log in with your new credentials.");
        }


        private bool UsernameExists(string username)
        {
            // Read user credentials from the file
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 1 && parts[0].Trim() == username)
                {
                    return true; // Username exists
                }
            }

            return false; // Username does not exist
        }
        public DataTable SearchStudent(int studNumber, int moduleCode)
        {
         query = $"SELECT * FROM modules WHERE ModuleCode AND StudentNumber = '{moduleCode}', {studNumber} ";
         adapter = new SqlDataAdapter(query, conn);
         table = new DataTable();
         adapter.Fill(table);
         MessageBox.Show("Search button clicked!");
         return table;
         //Call this method in the StudentModuleInfo form to search for student using module code and student number 

        }
    }
}
