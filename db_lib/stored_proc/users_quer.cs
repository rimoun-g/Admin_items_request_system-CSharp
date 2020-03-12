using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class users_quer
    {
       
    //Users queries to be as a stored procedures

    // Add user to users table
    public string Quer_AddUser { get; } = @"INSERT INTO users (user_name, password, level) VALUES (@user_name, @password, @level)";
    // get all the users information except password
    public string Quer_GetAllUsers { get; } = @"SELECT id, user_name, level FROM users";
    // Get user information by its username 
    public string Quer_GetUserByName { get; } = @"SELECT id, user_name, password, level FROM users where user_name = @user_name";
    // update user information
    public string Quer_UpdateUser { get; } = @"Update users set user_name = @user_name, password = @password, level = @level WHERE id = @id;";

    // deleting user is not allowed to keep the transactions accurate 
    }
}
