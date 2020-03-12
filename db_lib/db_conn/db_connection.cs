using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using Dapper;

namespace db_lib.db_conn
{
    //for creating database connection and creating database file if it doesnt exist

    public class db_connection
    {
        // database name
        private string db_file_name = "My_admin_db.db";
        public string Db_file_name
        {
            get { return  db_file_name; }
        }




        public SQLiteConnection db_connect()
        {
            // connection to the database
            if (System.IO.File.Exists(Db_file_name))
            {
                return new SQLiteConnection($"Data Source={Db_file_name};Version=3;Compress=True;"); 
            }
            else
            {
                CreateDatabase();
                 return new SQLiteConnection($"Data Source={Db_file_name};Version=3;Compress=True;");
            }

            
        }

        private void CreateDatabase()
        {
            // creating database file in case it does not exist
            SQLiteConnection.CreateFile(Db_file_name);
            using (var cnn = db_connect())
            {
                cnn.Open();

                //users table
                cnn.Execute(@"CREATE TABLE users(
    id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
    user_name TEXT NOT NULL,
    password  TEXT NOT NULL,
    level INTEGER NOT NULL
); ");

                //adding default username to open the application, should be deleted after creating a new file
                cnn.Execute(@"INSERT INTO users (user_name, password, level) VALUES ('rimoun', '', 1)");




                //employees table
                cnn.Execute(

                @"CREATE TABLE employees (
                id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                code  INTEGER NOT NULL UNIQUE,
                name  TEXT NOT NULL,
                job   TEXT NOT NULL,
                dept  TEXT NOT NULL,
                section  TEXT);");

                //items table
                cnn.Execute(@"CREATE TABLE items(
                            id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                            name  TEXT NOT NULL,
                            is_active INTEGER NOT NULL);");

                //subcats table
                cnn.Execute(@"CREATE TABLE subcats (
                            id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                            item_id   INTEGER NOT NULL,
                            name  TEXT NOT NULL,
                            is_active INTEGER NOT NULL);");

                //transactions table
                cnn.Execute(@"CREATE TABLE transactions (

    id    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
    emp_no    INTEGER NOT NULL,
    item_id   INTEGER NOT NULL,
    subcat_id INTEGER,
    unit_price    NUMERIC NOT NULL,
    quantity  NUMERIC NOT NULL,
    user_id   INTEGER,
    date  TEXT NOT NULL,
    delivery_date TEXT,
    remarks   TEXT
); ");


                          }
        }

    }


}

