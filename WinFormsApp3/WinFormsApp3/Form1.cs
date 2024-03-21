using System.Text.RegularExpressions;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Event handler for the Password textbox's TextChanged event
        private void Password_TextChanged(object sender, EventArgs e)
        {
            // Show password strength indicators
            len.Show();
            uppercase.Show();
            number.Show();

            // Check password length
            if (password.Text.Length > 8)
                len.ForeColor = Color.Green;
            else
                len.ForeColor = Color.Red;

            // Check for uppercase letters
            if (password.Text.Any(char.IsUpper))
                uppercase.ForeColor = Color.Green;
            else
                uppercase.ForeColor = Color.Red;

            // Check for numbers
            if (password.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Red;
        }

        // Validating event handler for the password textbox
        private void password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Validate password length
            if (password.Text.Length <= 8)
            {
                MessageBox.Show("Password should be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.Focus();
                e.Cancel = true;
            }
        }

        // Validating event handler for the username textbox
        private void username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Validate username length
            if (username.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                e.Cancel = true;
            }
        }

        // Validating event handler for the email textbox
        private void email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Validate email format
            if (email.Text != string.Empty)
            {
                if (!IsValidEmail(email.Text))
                {
                    MessageBox.Show("Email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        // Method to validate email format using regular expression
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        // Event handler for the Register button click event
        private void button2_Click(object sender, EventArgs e)
        {
            // Open SQL connection
            using (cn = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
            {
                cn.Open();

                // Checking if the username already exists
                using (cmd = new SqlCommand("SELECT COUNT(1) FROM Users where username = @username", cn))
                {
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Inserting user information into the database
                        using (cmd = new SqlCommand("INSERT INTO Users (username, emailTxt, password, image) VALUES (@username, @emailTxt, @password, NULLIF(CONVERT(varbinary(max), @image), ''))", cn))
                        {
                            cmd.Parameters.AddWithValue("@username", username.Text);
                            cmd.Parameters.AddWithValue("@emailTxt", email.Text);
                            cmd.Parameters.AddWithValue("@password", password.Text);
                            cmd.Parameters.AddWithValue("@image", "");
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Hide();
                            Form2 login = new Form2();
                            login.Show();
                        }
                    }
                }
            }
        }

        // Event handler for the Login button click event
        private void button1_Click(object sender, EventArgs e)
        {
            // Show the login form
            Form2 login = new Form2();
            login.Show();
        }
    }
}
