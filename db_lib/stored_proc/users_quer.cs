using System;
using System.Collections.Generic;
using System.Text;

namespace db_lib.stored_proc
{
    public class users_quer
    {
     public string Quer_AddUser { get; } = @"INSERT INTO users (user_name, password, level) VALUES (@user_name, @password, @level)";
    public string Quer_GetAllUsers { get; } = @"SELECT id, user_name, level FROM users";
    }
}
