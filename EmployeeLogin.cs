﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Employee;
using SCTAttendanceSystemUI.Forms;

namespace SCTAttendanceSystemUI
{
    public partial class EmployeeLogin : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;

        public EmployeeLogin()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);

            // Attach the KeyPress event handler to the textBoxIDNum
            textBoxIDNum.KeyPress += TextBoxIDNum_KeyPress;

            // Select the textBoxIDNum when the form loads
            textBoxIDNum.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void TextBoxIDNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed, attempt login
                string empnum = textBoxIDNum.Text;

                if (ValidateInputs(empnum))
                {
                    try
                    {
                        connection.Open();

                        // Perform the login authentication here
                        // You can execute SQL queries or stored procedures to check the credentials

                        // For example:
                        string query = "SELECT name FROM employee WHERE employeenum = @employeeNumber";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@employeeNumber", empnum);
                        string name = (string)command.ExecuteScalar();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Hide();
                                FormEmployeeDashboard empDashboard = new FormEmployeeDashboard(name);
                                empDashboard.ShowDialog();
                            }
                            else
                            {
                                // Login failed
                                MessageBox.Show("Invalid Employee Number!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception or display an error message
                        MessageBox.Show("Error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private bool ValidateInputs(string empnum)
        {
            // Perform any necessary validation here

            if (string.IsNullOrEmpty(empnum))
            {
                MessageBox.Show("Please enter Employee Number!");
                return false;
            }

            return true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void backBtn_MouseHover(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(164, 16, 48);
        }

        private void textBoxIDNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
