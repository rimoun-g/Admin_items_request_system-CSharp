using Dapper;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using db_lib.db_conn;
using db_lib.stored_proc;
using System.Linq;

namespace DataLayer.code
{
    public class user_code: db_connection, Iuser
    {
        users_quer users_Quer = new users_quer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user">add user class with all information</param>
        /// <returns>the user class</returns>
        public user AddUser(user user)
        {

            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(users_Quer.Quer_AddUser, new { user.user_name, user.password ,user.level,});

                return user;
            }
        }

        /// <summary>
        /// add a new user to the users table
        /// </summary>
        /// <param name="name">user name</param>
        /// <param name="password">password</param>
        /// <param name="level">administration level</param>
        public void add_user(string name, string password, int level)
        {
            
            user new_user = new user();
            new_user.level = level;
            new_user.user_name = name;
            new_user.password = sha256(password);
            AddUser(new_user);

        }
        /// <summary>
        /// update a specific user based on its id
        /// </summary>
        /// <param name="user">user class</param>
        /// <returns>user class</returns>
        public user UpdateUser(user user)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var rows = cnn.Execute(users_Quer.Quer_UpdateUser, new {user.id, user.user_name, user.password, user.level });

                return user;
            }
        }


        /// <summary>
        /// collecting information for user update function
        /// </summary>
        /// <param name="inv_user">user class</param>
        /// <param name="pw">setting the user password</param>
        public void Update_user(user inv_user, string pw)
        {
            user update_user = new user();
            update_user.id = inv_user.id;
            update_user.level = inv_user.level;
            update_user.user_name = inv_user.user_name;
            update_user.password = sha256(pw);
            UpdateUser(update_user);

        }
        /// <summary>
        /// getting all users from the users table
        /// </summary>
        /// <returns>returns a list of user class</returns>
        public List<user> GetAllUsers()
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                var result = cnn.Query<user>(users_Quer.Quer_GetAllUsers);

                return result.ToList();
            }
        }

        /// <summary>
        /// hashing the password using SHA256 encryption
        /// </summary>
        /// <param name="randomString"></param>
        /// <returns>returns the has of the password</returns>
        public string sha256(string randomString)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        /// <summary>
        /// get the user information using its username
        /// </summary>
        /// <param name="user_name"></param>
        /// <returns>returns the user information included in user class</returns>
        public user GetUserByName(string user_name)
        {
            using (var cnn = db_connect())
            {
                cnn.Open();
                user result = cnn.Query<user>(users_Quer.Quer_GetUserByName, new { user_name }).FirstOrDefault();

                return result;
            }
        }
    }
}
