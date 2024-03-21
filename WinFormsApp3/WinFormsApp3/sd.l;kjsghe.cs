using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3;

namespace WinFormsApp3
{
    // Authentication class
    public class authenticate
    {
        /* By having a dedicated User class, it becomes easier to extend and modify user-related properties 
        * or methods in the future without directly affecting the authentication logic. 
        * This modularity enhances code maintainability. */
        public class User
        {
            public string username { get; set; } // User's username property
            public byte[] image { get; set; } // User's image property (binary data)
            public string emailTxt { get; set; }

        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password); // for encapsulation purposes, call the private retrieveUserInformation method.
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC18\SQLEXPRESS; Initial Catalog=winforms; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection

                    string loginQuery = "SELECT COUNT(1) FROM Users WHERE username=@username AND password=@password";
                    string imageQuery = "SELECT image FROM Users WHERE username=@Username AND password=@Password";

                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand imageCmd = new SqlCommand(imageQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            imageCmd.CommandType = CommandType.Text;

                            loginCmd.Parameters.AddWithValue("@username", username);
                            loginCmd.Parameters.AddWithValue("@password", password);
                            imageCmd.Parameters.AddWithValue("@username", username);
                            imageCmd.Parameters.AddWithValue("@password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                            if (count == 1)
                            {
                                using (SqlDataReader reader = imageCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        byte[] imageData = reader["image"] as byte[];
                                        return new User { username = username, image = imageData };
                                    }
                                }
                            }

                            return null; // Return null if no user is found with the specified username and password
                        }
                    }
                }
            }
        }

    }
}