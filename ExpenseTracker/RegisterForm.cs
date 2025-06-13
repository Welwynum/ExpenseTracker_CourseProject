﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace ExpenseTracker
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rolli\OneDrive\Dokumenti\expenseTracker.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool checkConnection()
        {
            return(connect.State == ConnectionState.Closed) ? true : false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave the application?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "") {
                MessageBox.Show("Please fill in all of the fields before proceeding", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            else {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectUsername = "SELECT * FROM users WHERE username =@usern";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect)) {
                            checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count != 0)
                            {
                                string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(tempUsern + " is existing already", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length < 8) {
                                MessageBox.Show("Nope, at least 8 characters are needed", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_cPassword.Text)
                            {
                                MessageBox.Show("Nope, passwords are not the same, they should match", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username, password, date_create) VALUES (@usern, @pass, @date)";

                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertUser.Parameters.AddWithValue("@date", today);
                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registration successful!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();


                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex){
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            
            }
        }
        
    }
}
