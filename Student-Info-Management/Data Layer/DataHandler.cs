using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Student_Information_Management.Data_Access_Layer;
using Student_Information_Management.Business_Logic_Layer;
using Student_Information_Management.Presentation_Layer;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Student_Information_Management.Data_Layer
{
    internal class DataHandler
    {
        static string path = "SampleLogins.txt";
        static string conn = "Server = (local); Initial Catalog = StudentManager; Integrated Security = SSPI";
        SqlConnection connection = new SqlConnection(conn);

        string query;
        SqlCommand cmd;
        SqlDataAdapter sa;
        DataTable dt;

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

        public void deleteStudent(int studentNumber)//method that is used by a button that deletes a student entry
        {
            query = $"DELETE FROM students WHERE studentNumber = '{studentNumber}'";
            try
            {
                using (connection)
                {
                    using (cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Student deleted!");
                    }
                }
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public DataTable displayStudent()//when the display form loads, the datagrid view that holds the student information will display all student information
        {
            query = "SELECT * FROM students";
            sa = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            sa.Fill(dt);
            return dt;
        }

        public void deleteModule(int moduleCode)//method that is used by a button that deletes a module entry
        {
            query = $"DELETE FROM students WHERE moduleCode = '{moduleCode}'";
            try
            {
                using (connection)
                {
                    using (cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Module deleted!");
                    }
                }
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public DataTable displayModule()//when the display form loads, the datagrid view that holds the module information will display all module information
        {
            query = "SELECT * FROM modules";
            sa = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            sa.Fill(dt);
            return dt;
        }

        public DataTable searchStudent(int studentNumber)
        {
            query = $"SELECT * FROM students WHERE studentNumber = '{studentNumber}'";
            sa = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            sa.Fill(dt);
            return dt;
        }

        public DataTable searchModule(int moduleCode)
        {
            query = $"SELECT * FROM modules WHERE moduleCode = '{moduleCode}'";
            sa = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            sa.Fill(dt);
            return dt;
        }
    }
}
