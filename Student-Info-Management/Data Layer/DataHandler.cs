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

namespace Student_Information_Management.Data_Layer
{
    internal class DataHandler
    {
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
    }
}
