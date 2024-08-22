using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using Student_Information_Management.Business_Logic_Layer;

namespace Student_Information_Management.Data_Access_Layer
{
    internal class DataHandler
    {
        static string path = "SampleLogins.txt";
        //connection string to sql server
        static string conn = "Server= HALSEY\\SQLEXPRESS;Initial Catalog= StudentManager; Integrated Security=SSPI";
        private string query;
        SqlConnection connection = new SqlConnection(conn);
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable table;

        //
        //      Login Logic
        //
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
                    return true;
                }
            }
            return false;
        }

        //
        //      Students
        //
        public DataTable DisplayStudent()//when the display form loads, the datagrid view that holds the student information will display all student information
        {
            query = "SELECT * FROM Students";
            adapter = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void AddStudent(StudentData student)
        {
            query = $"INSERT INTO Students " +
                            $"VALUES ('{student.StudNumber}', '{student.Firstname}', '{student.Surname}', '{student.StudImage}', " +
                            $"'{student.DateOfBirth}', '{student.Gender}', '{student.Phone}', '{student.StuAddress}','{student.ModuleCode}')";

            try
            {
                using (connection = new SqlConnection(conn))
                {
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateStudent(StudentData student)
        {
            query = $"UPDATE Students " +
                            $"SET studentNumber = '{student.StudNumber}', firstName = '{student.Firstname}', surname = '{student.Surname}', studentImage = '{student.StudImage}', " +
                            $"dob = '{student.DateOfBirth}', gender = '{student.Gender}', phone = '{student.Phone}', stuAddress = '{student.StuAddress}', moduleCodes = '{student.ModuleCode}'" +
                            $"WHERE studentNumber = '{student.StudNumber}'";

            try
            {
                using (connection = new SqlConnection(conn))
                {        
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public void DeleteStudent(int studentNumber)//method that is used by a button that deletes a student entry
        {
            query = $"DELETE FROM Students WHERE studentNumber = '{studentNumber}'";

            try
            {
                using (connection = new SqlConnection(conn))
                {
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public DataTable SearchStudent(int studentnumber)
        {
            query = $"SELECT * FROM Students WHERE studentnumber = '{studentnumber}'";
            adapter = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //
        //      Modules
        //
        public DataTable DisplayModule()
        {
            query = "SELECT * FROM Modules";
            adapter = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void AddModule(ModuleData moduleData)
        {
            query = $"INSERT INTO Modules " +
                          $"VALUES ('{moduleData.Modulecode}','{moduleData.ModuleName}', '{moduleData.ModuleDescription}','{moduleData.Links}')";

            try
            {
                using (connection = new SqlConnection(conn))
                {
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Module Added!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void UpdateModule(ModuleData moduleData)
        {
            query = $"UPDATE Modules  " +
                          $"SET moduleCode = '{moduleData.Modulecode}', moduleName = '{moduleData.ModuleName}', moduleDescription = '{moduleData.ModuleDescription}'," +
                          $" links = '{moduleData.Links}' WHERE moduleCode = '{moduleData.Modulecode}'";

            try
            {
                using (connection = new SqlConnection(conn))
                {
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modules Updated!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        }


        public void DeleteModule(int moduleCode)//method that is used by a button that deletes a module entry
        {
            query = $"DELETE FROM Modules WHERE moduleCode = '{moduleCode}'";
            try
            {
                using (connection = new SqlConnection(conn))
                {
                    cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Module Deleted!");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public DataTable SearchModule(int moduleCode)
        {
            query = $"SELECT * FROM Modules WHERE moduleCode = '{moduleCode}'";
            adapter = new SqlDataAdapter(query, conn);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
